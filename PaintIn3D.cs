/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CW.Common;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 43: PaintIn3D.dll - Assembly: PaintIn3D, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55955-56118
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace PaintIn3D
{
	[AddComponentMenu("Paint in 3D/P3D Button Clear All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonClearAll")]
	public class P3dButtonClearAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 55956
	{
		// Fields
		[SerializeField]
		private bool clearStates; // 0x18
	
		// Properties
		public bool ClearStates { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		public P3dButtonClearAll() {} // 0x00000001842726E8-0x00000001842726F4
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001892F1708-0x00000001892F1710
		[ContextMenu("Clear All")]
		public void ClearAll() {} // 0x00000001892F157C-0x00000001892F1708
	}

	[AddComponentMenu("Paint in 3D/P3D Button Redo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonRedoAll")]
	public class P3dButtonRedoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 55957
	{
		// Constructors
		public P3dButtonRedoAll() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001892F1710-0x00000001892F1718
		[ContextMenu("Redo All")]
		public void RedoAll() {} // 0x00000001892F1710-0x00000001892F1718
		protected virtual void Update() {} // 0x00000001892F1718-0x00000001892F17B4
	}

	[AddComponentMenu("Paint in 3D/P3D Button Undo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonUndoAll")]
	public class P3dButtonUndoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 55958
	{
		// Constructors
		public P3dButtonUndoAll() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001892F17B4-0x00000001892F17BC
		[ContextMenu("Undo All")]
		public void UndoAll() {} // 0x00000001892F17B4-0x00000001892F17BC
		protected virtual void Update() {} // 0x00000001892F17BC-0x00000001892F1858
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterEvent")]
	public class P3dChangeCounterEvent : MonoBehaviour // TypeDefIndex: 55959
	{
		// Fields
		[SerializeField]
		private List<P3dChangeCounter> counters; // 0x18
		[SerializeField]
		private Vector2 range; // 0x20
		[SerializeField]
		private bool inside; // 0x28
		[SerializeField]
		private UnityEvent onInside; // 0x30
		[SerializeField]
		private UnityEvent onOutside; // 0x38
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x00000001892F1904-0x00000001892F1988 
		public Vector2 Range { get => default; set {} } // 0x0000000183D71660-0x0000000183D71680 0x0000000183D4ED30-0x0000000183D4ED40
		public bool Inside { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public UnityEvent OnInside { get => default; } // 0x00000001892F1988-0x00000001892F19F8 
		public UnityEvent OnOutside { get => default; } // 0x00000001892F19F8-0x00000001892F1A68 
		public float Ratio { get => default; } // 0x00000001892F1A68-0x00000001892F1AD0 
	
		// Constructors
		public P3dChangeCounterEvent() {} // 0x00000001892F18EC-0x00000001892F1904
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F18C8-0x00000001892F18EC
		private void UpdateInside(float ratio) {} // 0x00000001892F1858-0x00000001892F18C8
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChangeCounterFill : MonoBehaviour // TypeDefIndex: 55960
	{
		// Fields
		[SerializeField]
		private List<P3dChangeCounter> counters; // 0x18
		[SerializeField]
		private bool inverse; // 0x20
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x00000001892F1BB8-0x00000001892F1C3C 
		public bool Inverse { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		public P3dChangeCounterFill() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001892F1AD0-0x00000001892F1B18
		protected virtual void Update() {} // 0x00000001892F1B18-0x00000001892F1BB8
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterText")]
	public class P3dChangeCounterText : MonoBehaviour // TypeDefIndex: 55962
	{
		// Fields
		[SerializeField]
		private List<P3dChangeCounter> counters; // 0x18
		[SerializeField]
		private bool inverse; // 0x20
		[SerializeField]
		private int decimalPlaces; // 0x24
		[Multiline]
		[SerializeField]
		private string format; // 0x28
		[SerializeField]
		private StringEvent onString; // 0x30
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x00000001892F1E50-0x00000001892F1ED4 
		public bool Inverse { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public int DecimalPlaces { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public string Format { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public StringEvent OnString { get => default; } // 0x00000001892F1ED4-0x00000001892F1F44 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 55961
		{
			// Constructors
			public StringEvent() {} // 0x00000001893033B4-0x0000000189303490
		}
	
		// Constructors
		public P3dChangeCounterText() {} // 0x00000001892F1E08-0x00000001892F1E50
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F1C3C-0x00000001892F1E08
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterEvent")]
	public class P3dChannelCounterEvent : MonoBehaviour // TypeDefIndex: 55964
	{
		// Fields
		[SerializeField]
		private List<P3dChannelCounter> counters; // 0x18
		[SerializeField]
		private ChannelType channel; // 0x20
		[SerializeField]
		private Vector2 range; // 0x24
		[SerializeField]
		private bool inside; // 0x2C
		[SerializeField]
		private UnityEvent onInside; // 0x30
		[SerializeField]
		private UnityEvent onOutside; // 0x38
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x00000001892F1FF0-0x00000001892F2074 
		public ChannelType Channel { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public Vector2 Range { get => default; set {} } // 0x0000000183D50A80-0x0000000183D50AA0 0x0000000183D71680-0x0000000183D71690
		public bool Inside { get => default; set {} } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
		public UnityEvent OnInside { get => default; } // 0x00000001892F2074-0x00000001892F20E4 
		public UnityEvent OnOutside { get => default; } // 0x00000001892F20E4-0x00000001892F2154 
		public float Ratio { get => default; } // 0x00000001892F2154-0x00000001892F2228 
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 55963
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterEvent() {} // 0x00000001892F1FD8-0x00000001892F1FF0
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F1FB4-0x00000001892F1FD8
		private void UpdateInside(float ratio) {} // 0x00000001892F1F44-0x00000001892F1FB4
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChannelCounterFill : MonoBehaviour // TypeDefIndex: 55966
	{
		// Fields
		[SerializeField]
		private List<P3dChannelCounter> counters; // 0x18
		[SerializeField]
		private ChannelType channel; // 0x20
		[SerializeField]
		private bool inverse; // 0x24
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x00000001892F237C-0x00000001892F2400 
		public ChannelType Channel { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool Inverse { get => default; set {} } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 55965
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterFill() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001892F2228-0x00000001892F2270
		protected virtual void Update() {} // 0x00000001892F2270-0x00000001892F237C
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterText")]
	public class P3dChannelCounterText : MonoBehaviour // TypeDefIndex: 55969
	{
		// Fields
		[SerializeField]
		private List<P3dChannelCounter> counters; // 0x18
		[SerializeField]
		private ChannelType channel; // 0x20
		[SerializeField]
		private bool inverse; // 0x24
		[SerializeField]
		private int decimalPlaces; // 0x28
		[Multiline]
		[SerializeField]
		private string format; // 0x30
		[SerializeField]
		private StringEvent onString; // 0x38
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x00000001892F2684-0x00000001892F2708 
		public ChannelType Channel { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool Inverse { get => default; set {} } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
		public int DecimalPlaces { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public string Format { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public StringEvent OnString { get => default; } // 0x00000001892F2708-0x00000001892F2778 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 55967
		{
			// Constructors
			public StringEvent() {} // 0x0000000189303378-0x00000001893033B4
		}
	
		public enum ChannelType // TypeDefIndex: 55968
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterText() {} // 0x00000001892F263C-0x00000001892F2684
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F2400-0x00000001892F263C
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterEvent")]
	public class P3dColorCounterEvent : MonoBehaviour // TypeDefIndex: 55970
	{
		// Fields
		[SerializeField]
		private List<P3dColorCounter> counters; // 0x18
		[SerializeField]
		private P3dColor color; // 0x20
		[SerializeField]
		private Vector2 range; // 0x28
		[SerializeField]
		private bool inside; // 0x30
		[SerializeField]
		private UnityEvent onInside; // 0x38
		[SerializeField]
		private UnityEvent onOutside; // 0x40
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x00000001892F2824-0x00000001892F28A8 
		public P3dColor Color { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Vector2 Range { get => default; set {} } // 0x0000000183D51910-0x0000000183D51930 0x0000000183D4ED70-0x0000000183D4ED80
		public bool Inside { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public UnityEvent OnInside { get => default; } // 0x00000001892F28A8-0x00000001892F2918 
		public UnityEvent OnOutside { get => default; } // 0x00000001892F2918-0x00000001892F2988 
		public float Ratio { get => default; } // 0x00000001892F2988-0x00000001892F29FC 
	
		// Constructors
		public P3dColorCounterEvent() {} // 0x00000001892F280C-0x00000001892F2824
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F27E8-0x00000001892F280C
		private void UpdateInside(float ratio) {} // 0x00000001892F2778-0x00000001892F27E8
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dColorCounterFill : MonoBehaviour // TypeDefIndex: 55971
	{
		// Fields
		[SerializeField]
		private List<P3dColorCounter> counters; // 0x18
		[SerializeField]
		private P3dColor color; // 0x20
		[SerializeField]
		private bool inverse; // 0x28
		[NonSerialized]
		private Image cachedImage; // 0x30
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x00000001892F2AF8-0x00000001892F2B7C 
		public P3dColor Color { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool Inverse { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
	
		// Constructors
		public P3dColorCounterFill() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001892F29FC-0x00000001892F2A44
		protected virtual void Update() {} // 0x00000001892F2A44-0x00000001892F2AF8
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterText")]
	public class P3dColorCounterText : MonoBehaviour // TypeDefIndex: 55973
	{
		// Fields
		[SerializeField]
		private List<P3dColorCounter> counters; // 0x18
		[SerializeField]
		private P3dColor color; // 0x20
		[SerializeField]
		private bool inverse; // 0x28
		[SerializeField]
		private int decimalPlaces; // 0x2C
		[Multiline]
		[SerializeField]
		private string format; // 0x30
		[SerializeField]
		private StringEvent onString; // 0x38
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x00000001892F2D94-0x00000001892F2E18 
		public P3dColor Color { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool Inverse { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public int DecimalPlaces { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public string Format { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public StringEvent OnString { get => default; } // 0x00000001892F2E18-0x00000001892F2E88 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 55972
		{
			// Constructors
			public StringEvent() {} // 0x000000018930333C-0x0000000189303378
		}
	
		// Constructors
		public P3dColorCounterText() {} // 0x00000001892F2D4C-0x00000001892F2D94
	
		// Methods
		protected virtual void Update() {} // 0x00000001892F2B7C-0x00000001892F2D4C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Debug")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDebug")]
	public class P3dPaintDebug : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad // TypeDefIndex: 55974
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private float duration; // 0x28
		[SerializeField]
		private float size; // 0x2C
	
		// Properties
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
		public float Duration { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public float Size { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
	
		// Constructors
		public P3dPaintDebug() {} // 0x00000001892FF9C8-0x00000001892FFA00
	
		// Methods
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x00000001892FF3C4-0x00000001892FF56C
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x00000001892FF2A4-0x00000001892FF3C4
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x00000001892FF7A4-0x00000001892FF9C8
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x00000001892FF56C-0x00000001892FF7A4
		private UnityEngine.Color GetColor(bool preview, float pressure, UnityEngine.Color color) => default; // 0x00000001892FF260-0x00000001892FF2A4
		private void DrawArrow(Vector3 position, Quaternion rotation, UnityEngine.Color tint) {} // 0x00000001892FED98-0x00000001892FF260
	}

	public class P3dCommandDecal : P3dCommand // TypeDefIndex: 55975
	{
		// Fields
		public P3dBlendMode Blend; // 0x70
		public bool In3D; // 0xA8
		public Vector3 Position; // 0xAC
		public Vector3 EndPosition; // 0xB8
		public Vector3 Position2; // 0xC4
		public Vector3 EndPosition2; // 0xD0
		public int Extrusions; // 0xDC
		public bool Clip; // 0xE0
		public Matrix4x4 Matrix; // 0xE4
		public Vector3 Direction; // 0x124
		public UnityEngine.Color Color; // 0x130
		public float Opacity; // 0x140
		public float Hardness; // 0x144
		public float Wrapping; // 0x148
		public P3dHashedTexture Texture; // 0x150
		public P3dHashedTexture Shape; // 0x160
		public Vector4 ShapeChannel; // 0x170
		public Vector2 NormalFront; // 0x180
		public Vector2 NormalBack; // 0x188
		public P3dHashedTexture TileTexture; // 0x190
		public Matrix4x4 TileMatrix; // 0x1A0
		public float TileOpacity; // 0x1E0
		public float TileTransition; // 0x1E4
		public Matrix4x4 MaskMatrix; // 0x1E8
		public P3dHashedTexture MaskShape; // 0x228
		public Vector4 MaskChannel; // 0x238
		public Vector3 MaskStretch; // 0x248
		public static P3dCommandDecal Instance; // 0x00
		private static Stack<P3dCommandDecal> pool; // 0x08
		private static Material cachedSpotMaterial; // 0x10
		private static Material cachedLineMaterial; // 0x18
		private static Material cachedQuadMaterial; // 0x20
		private static Material cachedLineClipMaterial; // 0x28
		private static Material cachedQuadClipMaterial; // 0x30
		private static int cachedSpotMaterialHash; // 0x38
		private static int cachedLineMaterialHash; // 0x3C
		private static int cachedQuadMaterialHash; // 0x40
		private static int cachedLineClipMaterialHash; // 0x44
		private static int cachedQuadClipMaterialHash; // 0x48
		private static int _In3D; // 0x4C
		private static int _Position; // 0x50
		private static int _EndPosition; // 0x54
		private static int _Position2; // 0x58
		private static int _EndPosition2; // 0x5C
		private static int _Matrix; // 0x60
		private static int _Direction; // 0x64
		private static int _Color; // 0x68
		private static int _Opacity; // 0x6C
		private static int _Hardness; // 0x70
		private static int _Wrapping; // 0x74
		private static int _Texture; // 0x78
		private static int _Shape; // 0x7C
		private static int _ShapeChannel; // 0x80
		private static int _NormalFront; // 0x84
		private static int _NormalBack; // 0x88
		private static int _TileTexture; // 0x8C
		private static int _TileMatrix; // 0x90
		private static int _TileOpacity; // 0x94
		private static int _TileTransition; // 0x98
		private static int _MaskMatrix; // 0x9C
		private static int _MaskTexture; // 0xA0
		private static int _MaskChannel; // 0xA4
		private static int _MaskStretch; // 0xA8
	
		// Properties
		public override bool RequireMesh { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		static P3dCommandDecal() {} // 0x00000001892F43F0-0x00000001892F4A58
		public P3dCommandDecal() {} // 0x00000001892F4A58-0x00000001892F4A98
	
		// Methods
		public override void Apply(Material material) {} // 0x00000001892F2FA8-0x00000001892F3740
		public override void Pool() {} // 0x00000001892F37AC-0x00000001892F381C
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x00000001892F41C0-0x00000001892F43F0
		public override P3dCommand SpawnCopy() => default; // 0x00000001892F3E3C-0x00000001892F41C0
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x00000001892F2F4C-0x00000001892F2FA8
		public void SetShape(Quaternion rotation, Vector3 size, float angle) {} // 0x00000001892F3CB4-0x00000001892F3E3C
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x01FD7C00 */) {} // 0x0000000183D71710-0x0000000183D71740
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x01FD7C01 */, bool clip = false /* Metadata: 0x01FD7C02 */) {} // 0x0000000183D71740-0x0000000183D71790
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x01FD7C03 */) {} // 0x0000000183D71690-0x0000000183D71710
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x01FD7C04 */, bool clip = false /* Metadata: 0x01FD7C05 */) {} // 0x0000000183D71790-0x0000000183D71810
		public void ClearMask() {} // 0x00000001892F3740-0x00000001892F37AC
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch) {} // 0x00000001892F381C-0x00000001892F3918
		public void ApplyAspect(Texture texture) {} // 0x00000001892F2E88-0x00000001892F2F4C
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition) {} // 0x00000001892F3918-0x00000001892F3CB4
	}

	public class P3dCommandFill : P3dCommand // TypeDefIndex: 55976
	{
		// Fields
		public P3dBlendMode Blend; // 0x70
		public P3dHashedTexture Texture; // 0xA8
		public UnityEngine.Color Color; // 0xB8
		public float Opacity; // 0xC8
		public float Minimum; // 0xCC
		public static P3dCommandFill Instance; // 0x00
		private static Stack<P3dCommandFill> pool; // 0x08
		private static Material cachedMaterial; // 0x10
		private static int cachedMaterialHash; // 0x18
		private static int _Buffer; // 0x1C
		private static int _BufferSize; // 0x20
		private static int _Texture; // 0x24
		private static int _Color; // 0x28
		private static int _Opacity; // 0x2C
		private static int _Minimum; // 0x30
	
		// Properties
		public override bool RequireMesh { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		static P3dCommandFill() {} // 0x00000001892F52C8-0x00000001892F5500
		public P3dCommandFill() {} // 0x00000001892F5500-0x00000001892F5540
	
		// Methods
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) => default; // 0x00000001892F4E8C-0x00000001892F4FF4
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) {} // 0x00000001892F4C40-0x00000001892F4E8C
		public override void Apply(Material material) {} // 0x00000001892F4A98-0x00000001892F4C40
		public override void Pool() {} // 0x00000001892F4FF4-0x00000001892F5064
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x000000018350B670-0x000000018350B680
		public override P3dCommand SpawnCopy() => default; // 0x00000001892F51C4-0x00000001892F52C8
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x00000001892F2F4C-0x00000001892F2FA8
		public Material SetMaterial(P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) => default; // 0x00000001892F5064-0x00000001892F51C4
	}

	public class P3dCommandReplace : P3dCommand // TypeDefIndex: 55977
	{
		// Fields
		public P3dHashedTexture Texture; // 0x70
		public UnityEngine.Color Color; // 0x80
		public static P3dCommandReplace Instance; // 0x00
		private static Stack<P3dCommandReplace> pool; // 0x08
		private static Material cachedMaterial; // 0x10
		private static int cachedMaterialHash; // 0x18
		private static int _Texture; // 0x1C
		private static int _Color; // 0x20
	
		// Properties
		public override bool RequireMesh { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		static P3dCommandReplace() {} // 0x00000001892F64B8-0x00000001892F6640
		public P3dCommandReplace() {} // 0x00000001892F6640-0x00000001892F6680
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint) {} // 0x00000001892F61F4-0x00000001892F62E4
		public static void BlitFast(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint) {} // 0x00000001892F6120-0x00000001892F61F4
		public override void Apply(Material material) {} // 0x00000001892F6014-0x00000001892F6120
		public override void Pool() {} // 0x00000001892F62E4-0x00000001892F6354
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x000000018350B670-0x000000018350B680
		public override P3dCommand SpawnCopy() => default; // 0x00000001892F6420-0x00000001892F64B8
		public Material SetMaterial(Texture texture, UnityEngine.Color color) => default; // 0x00000001892F6354-0x00000001892F6420
	}

	public class P3dCommandReplaceChannels : P3dCommand // TypeDefIndex: 55978
	{
		// Fields
		public P3dHashedTexture TextureR; // 0x70
		public P3dHashedTexture TextureG; // 0x80
		public P3dHashedTexture TextureB; // 0x90
		public P3dHashedTexture TextureA; // 0xA0
		public Vector4 ChannelR; // 0xB0
		public Vector4 ChannelG; // 0xC0
		public Vector4 ChannelB; // 0xD0
		public Vector4 ChannelA; // 0xE0
		public static P3dCommandReplaceChannels Instance; // 0x00
		private static Stack<P3dCommandReplaceChannels> pool; // 0x08
		private static Material cachedMaterial; // 0x10
		private static int cachedMaterialHash; // 0x18
		private static int _TextureR; // 0x1C
		private static int _TextureG; // 0x20
		private static int _TextureB; // 0x24
		private static int _TextureA; // 0x28
		private static int _ChannelR; // 0x2C
		private static int _ChannelG; // 0x30
		private static int _ChannelB; // 0x34
		private static int _ChannelA; // 0x38
	
		// Properties
		public override bool RequireMesh { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		static P3dCommandReplaceChannels() {} // 0x00000001892F5D44-0x00000001892F5FD4
		public P3dCommandReplaceChannels() {} // 0x00000001892F5FD4-0x00000001892F6014
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA, Vector4 channels) {} // 0x00000001892F58A4-0x00000001892F5A24
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA) {} // 0x00000001892F5740-0x00000001892F58A4
		public override void Apply(Material material) {} // 0x00000001892F5540-0x00000001892F5740
		public override void Pool() {} // 0x00000001892F5A24-0x00000001892F5A94
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x000000018350B670-0x000000018350B680
		public override P3dCommand SpawnCopy() => default; // 0x00000001892F5C24-0x00000001892F5D44
		public Material SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA) => default; // 0x00000001892F5A94-0x00000001892F5C24
	}

	public class P3dCommandSphere : P3dCommand // TypeDefIndex: 55979
	{
		// Fields
		public P3dBlendMode Blend; // 0x70
		public bool In3D; // 0xA8
		public Vector3 Position; // 0xAC
		public Vector3 EndPosition; // 0xB8
		public Vector3 Position2; // 0xC4
		public Vector3 EndPosition2; // 0xD0
		public int Extrusions; // 0xDC
		public bool Clip; // 0xE0
		public Matrix4x4 Matrix; // 0xE4
		public UnityEngine.Color Color; // 0x124
		public float Opacity; // 0x134
		public float Hardness; // 0x138
		public P3dHashedTexture TileTexture; // 0x140
		public Matrix4x4 TileMatrix; // 0x150
		public float TileOpacity; // 0x190
		public float TileTransition; // 0x194
		public Matrix4x4 MaskMatrix; // 0x198
		public P3dHashedTexture MaskShape; // 0x1D8
		public Vector4 MaskChannel; // 0x1E8
		public Vector3 MaskStretch; // 0x1F8
		public static P3dCommandSphere Instance; // 0x00
		private static Stack<P3dCommandSphere> pool; // 0x08
		private static Material cachedSpotMaterial; // 0x10
		private static Material cachedLineMaterial; // 0x18
		private static Material cachedQuadMaterial; // 0x20
		private static Material cachedLineClipMaterial; // 0x28
		private static Material cachedQuadClipMaterial; // 0x30
		private static int cachedSpotMaterialHash; // 0x38
		private static int cachedLineMaterialHash; // 0x3C
		private static int cachedQuadMaterialHash; // 0x40
		private static int cachedLineClipMaterialHash; // 0x44
		private static int cachedQuadClipMaterialHash; // 0x48
		private static int _In3D; // 0x4C
		private static int _Position; // 0x50
		private static int _EndPosition; // 0x54
		private static int _Position2; // 0x58
		private static int _EndPosition2; // 0x5C
		private static int _Matrix; // 0x60
		private static int _Color; // 0x64
		private static int _Opacity; // 0x68
		private static int _Hardness; // 0x6C
		private static int _TileTexture; // 0x70
		private static int _TileMatrix; // 0x74
		private static int _TileOpacity; // 0x78
		private static int _TileTransition; // 0x7C
		private static int _MaskMatrix; // 0x80
		private static int _MaskTexture; // 0x84
		private static int _MaskChannel; // 0x88
		private static int _MaskStretch; // 0x8C
	
		// Properties
		public override bool RequireMesh { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		static P3dCommandSphere() {} // 0x00000001892F77C4-0x00000001892F7CEC
		public P3dCommandSphere() {} // 0x00000001892F7CEC-0x00000001892F7D2C
	
		// Methods
		public override void Apply(Material material) {} // 0x00000001892F6744-0x00000001892F6D10
		public override void Pool() {} // 0x00000001892F6D7C-0x00000001892F6DEC
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x00000001892F75FC-0x00000001892F77C4
		public override P3dCommand SpawnCopy() => default; // 0x00000001892F7334-0x00000001892F75FC
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x00000001892F2F4C-0x00000001892F2FA8
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x01FD7C06 */) {} // 0x0000000183D71710-0x0000000183D71740
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x01FD7C07 */, bool clip = false /* Metadata: 0x01FD7C08 */) {} // 0x0000000183D71740-0x0000000183D71790
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x01FD7C09 */) {} // 0x0000000183D71690-0x0000000183D71710
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x01FD7C0A */, bool clip = false /* Metadata: 0x01FD7C0B */) {} // 0x0000000183D71790-0x0000000183D71810
		public void ClearMask() {} // 0x00000001892F6D10-0x00000001892F6D7C
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch) {} // 0x00000001892F6DEC-0x00000001892F6EE8
		public void ApplyAspect(Texture texture) {} // 0x00000001892F6680-0x00000001892F6744
		public void SetShape(float radius) {} // 0x00000001892F7268-0x00000001892F7334
		public void SetShape(Quaternion rotation, Vector3 size, float angle) {} // 0x00000001892F712C-0x00000001892F7268
		public void SetMaterial(P3dBlendMode blendMode, float hardness, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition) {} // 0x00000001892F6EE8-0x00000001892F712C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Between")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitBetween")]
	public class P3dHitBetween : MonoBehaviour // TypeDefIndex: 55984
	{
		// Fields
		[SerializeField]
		private PhaseType paintIn; // 0x18
		[SerializeField]
		private float interval; // 0x1C
		[SerializeField]
		private Transform pointA; // 0x20
		[SerializeField]
		private Transform pointB; // 0x28
		[SerializeField]
		private float fraction; // 0x30
		[SerializeField]
		private LayerMask layers; // 0x34
		[SerializeField]
		private OrientationType orientation; // 0x38
		[SerializeField]
		private Camera _camera; // 0x40
		[SerializeField]
		private Transform customTransform; // 0x48
		[SerializeField]
		private NormalType normal; // 0x50
		[SerializeField]
		private float offset; // 0x54
		[SerializeField]
		private bool preview; // 0x58
		[SerializeField]
		private int priority; // 0x5C
		[Range(0f, 1f)]
		[SerializeField]
		private float pressure; // 0x60
		[SerializeField]
		private EmitType emit; // 0x64
		[SerializeField]
		private Transform point; // 0x68
		[SerializeField]
		private LineRenderer line; // 0x70
		[SerializeField]
		private P3dPointConnector connector; // 0x78
		[NonSerialized]
		private float current; // 0x80
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float Interval { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public Transform PointA { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Transform PointB { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public float Fraction { get => default; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 
		public LayerMask Layers { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public OrientationType Orientation { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public Camera Camera { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public Transform CustomTransform { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public NormalType Normal { get => default; set {} } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public float Offset { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
		public bool Preview { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		public int Priority { get => default; set {} } // 0x0000000183D4EEF0-0x0000000183D4EF00 0x0000000183D4EF40-0x0000000183D4EF50
		public float Pressure { get => default; set {} } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000183D50D80-0x0000000183D50D90
		public EmitType Draw { get => default; set {} } // 0x0000000183D50B30-0x0000000183D50B40 0x0000000183D50B40-0x0000000183D50B50
		public Transform Point { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public LineRenderer Line { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public P3dPointConnector Connector { get => default; } // 0x00000001892F89C4-0x00000001892F8A34 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 55980
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 55981
		{
			WorldUp = 0,
			CameraUp = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum NormalType // TypeDefIndex: 55982
		{
			HitNormal = 0,
			RayDirection = 1
		}
	
		public enum EmitType // TypeDefIndex: 55983
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		// Constructors
		public P3dHitBetween() {} // 0x00000001892F89A0-0x00000001892F89C4
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow() {} // 0x00000001892F7FE0-0x00000001892F7FEC
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892F7FA0-0x00000001892F7FC4
		[ContextMenu("Reset Connections")]
		public void ResetConnections() {} // 0x00000001892F80D4-0x00000001892F80F4
		protected virtual void OnEnable() {} // 0x00000001892F80B0-0x00000001892F80D4
		protected virtual void OnDisable() {} // 0x00000001892F7FEC-0x00000001892F80B0
		protected virtual void Update() {} // 0x00000001892F8950-0x00000001892F89A0
		protected virtual void LateUpdate() {} // 0x00000001892F7FD8-0x00000001892F7FE0
		protected virtual void FixedUpdate() {} // 0x00000001892F7FC4-0x00000001892F7FD8
		private void SubmitHit(bool preview) {} // 0x00000001892F80F4-0x00000001892F86F4
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, out Vector3 finalPosition, out Quaternion finalRotation) {
			finalPosition = default;
			finalRotation = default;
		} // 0x00000001892F7D2C-0x00000001892F7FA0
		private void UpdatePointAndLine() {} // 0x00000001892F8764-0x00000001892F8950
		private void UpdateHit() {} // 0x00000001892F86F4-0x00000001892F8764
	}

	public class P3dHitCache // TypeDefIndex: 55985
	{
		// Fields
		[NonSerialized]
		private bool cached; // 0x10
		[NonSerialized]
		private List<IHitPoint> hitPoints; // 0x18
		[NonSerialized]
		private List<IHitLine> hitLines; // 0x20
		[NonSerialized]
		private List<IHitTriangle> hitTriangles; // 0x28
		[NonSerialized]
		private List<IHitQuad> hitQuads; // 0x30
		[NonSerialized]
		private List<IHitCoord> hitCoords; // 0x38
		[NonSerialized]
		private static List<IHit> hits; // 0x00
	
		// Properties
		public bool Cached { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public P3dHitCache() {} // 0x00000001892F96CC-0x00000001892F9870
		static P3dHitCache() {} // 0x00000001892F9640-0x00000001892F96CC
	
		// Methods
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation) {} // 0x00000001892F90B8-0x00000001892F91DC
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x00000001892F8F58-0x00000001892F90B8
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation) {} // 0x00000001892F94F0-0x00000001892F9640
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x00000001892F9368-0x00000001892F94F0
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x00000001892F91DC-0x00000001892F9368
		public void InvokeCoord(GameObject gameObject, bool preview, int priority, float pressure, P3dHit hit, Quaternion rotation) {} // 0x00000001892F8E2C-0x00000001892F8F58
		public void Clear() {} // 0x00000001892F8D5C-0x00000001892F8E2C
		private void Cache(GameObject gameObject) {} // 0x00000001892F8A34-0x00000001892F8D5C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Collisions")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitCollisions")]
	public class P3dHitCollisions : MonoBehaviour // TypeDefIndex: 55989
	{
		// Fields
		[SerializeField]
		private EmitType emit; // 0x18
		[SerializeField]
		private float raycastDistance; // 0x1C
		[SerializeField]
		private LayerMask layers; // 0x20
		[SerializeField]
		private bool onlyUseFirstContact; // 0x24
		[SerializeField]
		private float delay; // 0x28
		[SerializeField]
		private OrientationType orientation; // 0x2C
		[SerializeField]
		private Camera _camera; // 0x30
		[SerializeField]
		private bool preview; // 0x38
		[SerializeField]
		private float threshold; // 0x3C
		[SerializeField]
		private PressureType pressureMode; // 0x40
		[SerializeField]
		private float pressureMin; // 0x44
		[SerializeField]
		private float pressureMax; // 0x48
		[Range(0f, 1f)]
		[SerializeField]
		private float pressureConstant; // 0x4C
		[SerializeField]
		private float pressureMultiplier; // 0x50
		[SerializeField]
		private float offset; // 0x54
		[SerializeField]
		private int priority; // 0x58
		[SerializeField]
		private GameObject root; // 0x60
		[SerializeField]
		private float cooldown; // 0x68
		[NonSerialized]
		private P3dHitCache hitCache; // 0x70
	
		// Properties
		public EmitType Emit { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float RaycastDistance { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public LayerMask Layers { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool OnlyUseFirstContact { get => default; set {} } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
		public float Delay { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public OrientationType Orientation { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public Camera Camera { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public bool Preview { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public float Threshold { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
		public PressureType PressureMode { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public float PressureMin { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public float PressureMax { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float PressureConstant { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public float PressureMultiplier { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public float Offset { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
		public int Priority { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public GameObject Root { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001892FA034-0x00000001892FA064
		public P3dHitCache HitCache { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 55986
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 55987
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum PressureType // TypeDefIndex: 55988
		{
			Constant = 0,
			ImpactSpeed = 1
		}
	
		// Constructors
		public P3dHitCollisions() {} // 0x00000001892F9F90-0x00000001892FA034
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892F9DEC-0x00000001892F9E0C
		protected virtual void OnCollisionEnter(UnityEngine.Collision collision) {} // 0x00000001892F9E0C-0x00000001892F9E14
		protected virtual void OnCollisionStay(UnityEngine.Collision collision) {} // 0x00000001892F9E0C-0x00000001892F9E14
		protected virtual void Update() {} // 0x00000001892F9F60-0x00000001892F9F90
		private bool TryGetRaycastHit(ContactPoint contact, ref RaycastHit hit) => default; // 0x00000001892F9E14-0x00000001892F9F60
		private void CheckCollision(UnityEngine.Collision collision) {} // 0x00000001892F9870-0x00000001892F9DEC
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Nearby")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitNearby")]
	public class P3dHitNearby : MonoBehaviour // TypeDefIndex: 55991
	{
		// Fields
		[SerializeField]
		private PhaseType paintIn; // 0x18
		[SerializeField]
		private float interval; // 0x1C
		[SerializeField]
		private bool preview; // 0x20
		[SerializeField]
		private int priority; // 0x24
		[Range(0f, 1f)]
		[SerializeField]
		private float pressure; // 0x28
		[SerializeField]
		private P3dPointConnector connector; // 0x30
		[NonSerialized]
		private float current; // 0x38
		[SerializeField]
		private Vector3 lastPosition; // 0x3C
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float Interval { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public bool Preview { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public int Priority { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public float Pressure { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public P3dPointConnector Connector { get => default; } // 0x00000001892FA2D0-0x00000001892FA340 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 55990
		{
			ManuallyOnly = -1,
			Update = 0,
			FixedUpdate = 1
		}
	
		// Constructors
		public P3dHitNearby() {} // 0x00000001892FA2B8-0x00000001892FA2D0
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow() {} // 0x00000001892FA09C-0x00000001892FA0A8
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892FA064-0x00000001892FA088
		[ContextMenu("Reset Connections")]
		public void ResetConnections() {} // 0x00000001892FA0CC-0x00000001892FA0EC
		protected virtual void OnEnable() {} // 0x00000001892FA0A8-0x00000001892FA0CC
		protected virtual void Update() {} // 0x00000001892FA268-0x00000001892FA2B8
		protected virtual void FixedUpdate() {} // 0x00000001892FA088-0x00000001892FA09C
		private void SubmitHit(bool preview) {} // 0x00000001892FA0EC-0x00000001892FA1F8
		private void UpdateHit() {} // 0x00000001892FA1F8-0x00000001892FA268
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Particles")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitParticles")]
	[RequireComponent(typeof(ParticleSystem))]
	public class P3dHitParticles : MonoBehaviour // TypeDefIndex: 55996
	{
		// Fields
		[SerializeField]
		private EmitType emit; // 0x18
		[SerializeField]
		private float raycastDistance; // 0x1C
		[SerializeField]
		private LayerMask layers; // 0x20
		[SerializeField]
		private OrientationType orientation; // 0x24
		[SerializeField]
		private Camera _camera; // 0x28
		[SerializeField]
		private NormalType normal; // 0x30
		[SerializeField]
		private float offset; // 0x34
		[SerializeField]
		private int skip; // 0x38
		[SerializeField]
		private bool preview; // 0x3C
		[SerializeField]
		private int priority; // 0x40
		[SerializeField]
		private PressureType pressureMode; // 0x44
		[SerializeField]
		private float pressureMin; // 0x48
		[SerializeField]
		private float pressureMax; // 0x4C
		[Range(0f, 1f)]
		[SerializeField]
		private float pressureConstant; // 0x50
		[SerializeField]
		private float pressureMultiplier; // 0x54
		[SerializeField]
		private GameObject root; // 0x58
		[NonSerialized]
		private ParticleSystem cachedParticleSystem; // 0x60
		[NonSerialized]
		private bool cachedParticleSystemSet; // 0x68
		[NonSerialized]
		private static List<ParticleCollisionEvent> particleCollisionEvents; // 0x00
		[NonSerialized]
		private P3dHitCache hitCache; // 0x70
		[NonSerialized]
		private int skipCounter; // 0x78
	
		// Properties
		public EmitType Emit { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float RaycastDistance { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public LayerMask Layers { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public OrientationType Orientation { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public Camera Camera { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public NormalType Normal { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public float Offset { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
		public int Skip { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public bool Preview { get => default; set {} } // 0x0000000183D4F460-0x0000000183D4F470 0x0000000183D4F470-0x0000000183D4F480
		public int Priority { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public PressureType PressureMode { get => default; set {} } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public float PressureMin { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float PressureMax { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public float PressureConstant { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public float PressureMultiplier { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
		public GameObject Root { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x00000001892FADF0-0x00000001892FAE20
		public P3dHitCache HitCache { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 55992
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 55993
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum NormalType // TypeDefIndex: 55994
		{
			ParticleVelocity = 0,
			CollisionNormal = 1
		}
	
		public enum PressureType // TypeDefIndex: 55995
		{
			Constant = 0,
			Distance = 1,
			Speed = 2
		}
	
		// Constructors
		public P3dHitParticles() {} // 0x00000001892FAD6C-0x00000001892FADF0
		static P3dHitParticles() {} // 0x00000001892FACE0-0x00000001892FAD6C
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892F9DEC-0x00000001892F9E0C
		private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit) => default; // 0x00000001892FAB2C-0x00000001892FACE0
		protected virtual void OnParticleCollision(GameObject hitGameObject) {} // 0x00000001892FA340-0x00000001892FAB2C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreen")]
	public class P3dHitScreen : P3dHitScreenBase // TypeDefIndex: 55999
	{
		// Fields
		[SerializeField]
		private FrequencyType frequency; // 0x70
		[SerializeField]
		private float interval; // 0x74
		[SerializeField]
		private P3dPointConnector connector; // 0x78
		[NonSerialized]
		private List<Link> links; // 0x80
	
		// Properties
		public FrequencyType Frequency { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public float Interval { get => default; set {} } // 0x0000000183D56C30-0x0000000183D56C40 0x0000000183D58A80-0x0000000183D58A90
		public P3dPointConnector Connector { get => default; } // 0x00000001892FD8E8-0x00000001892FD958 
	
		// Nested types
		protected class Link : CwInputManager.Link // TypeDefIndex: 55997
		{
			// Fields
			public float Age; // 0x18
			public bool Down; // 0x1C
			public int State; // 0x20
			public float Distance; // 0x24
			public Vector2 ScreenDelta; // 0x28
			public Vector2 ScreenOld; // 0x30
			public List<Vector2> History; // 0x38
	
			// Constructors
			public Link() {} // 0x00000001892F094C-0x00000001892F09C4
	
			// Methods
			public void Move(Vector2 screenNew) {} // 0x00000001892F0888-0x00000001892F08C0
			private bool TryMove(Vector2 screenNew) => default; // 0x00000001892F08C0-0x00000001892F094C
			public override void Clear() {} // 0x00000001892F0824-0x00000001892F0888
		}
	
		public enum FrequencyType // TypeDefIndex: 55998
		{
			PixelInterval = 0,
			ScaledPixelInterval = 1,
			TimeInterval = 2,
			OnceOnRelease = 3,
			OnceOnPress = 4,
			OnceEveryFrame = 5
		}
	
		// Constructors
		public P3dHitScreen() {} // 0x00000001892FD854-0x00000001892FD8E8
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892FCD78-0x00000001892FCD9C
		[ContextMenu("Reset Connections")]
		public void ResetConnections() {} // 0x00000001892F80D4-0x00000001892F80F4
		protected override void OnEnable() {} // 0x00000001892FD08C-0x00000001892FD1E0
		protected virtual void Update() {} // 0x00000001892FD834-0x00000001892FD854
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x00000001892FCE6C-0x00000001892FD084
		protected override void HandleFingerUp(CwInputManager.Finger finger) {} // 0x00000001892FCD9C-0x00000001892FCE6C
		private void PaintSmooth(Link link, bool down, float pixelSpacing) {} // 0x00000001892FD484-0x00000001892FD760
		protected virtual void OnFingerUp(Link link) {} // 0x000000018350B670-0x000000018350B680
		private void PaintInterval(Link link, bool down) {} // 0x00000001892FD26C-0x00000001892FD35C
		private void PaintRelease(Link link, bool up) {} // 0x00000001892FD3E8-0x00000001892FD484
		private void PaintPress(Link link, bool down) {} // 0x00000001892FD35C-0x00000001892FD3E8
		private void PaintEvery(Link link, bool down) {} // 0x00000001892FD1E0-0x00000001892FD26C
		private void RecordAndPaintAt(Link link, Vector2 screenNew, Vector2 screenOld, bool preview, float pressure, object owner) {} // 0x00000001892FD760-0x00000001892FD834
	}

	public abstract class P3dHitScreenBase : MonoBehaviour // TypeDefIndex: 56005
	{
		// Fields
		[SerializeField]
		private Camera _camera; // 0x18
		[SerializeField]
		private LayerMask layers; // 0x20
		[SerializeField]
		private ButtonTypes requiredButtons; // 0x24
		[SerializeField]
		private KeyCode requiredKey; // 0x28
		[SerializeField]
		private LayerMask guiLayers; // 0x2C
		[FormerlySerializedAs("draw")]
		[SerializeField]
		private EmitType emit; // 0x30
		[SerializeField]
		private RotationType rotateTo; // 0x34
		[FormerlySerializedAs("normal")]
		[SerializeField]
		private DirectionType normalDirection; // 0x38
		[FormerlySerializedAs("orientation")]
		[SerializeField]
		private RelativeType normalRelativeTo; // 0x3C
		[SerializeField]
		private Transform customTransform; // 0x40
		[FormerlySerializedAs("offset")]
		[SerializeField]
		private float normalOffset; // 0x48
		[SerializeField]
		private float mouseOffset; // 0x4C
		[SerializeField]
		private float touchOffset; // 0x50
		[SerializeField]
		protected bool storeStates; // 0x54
		[SerializeField]
		protected bool showPreview; // 0x55
		[SerializeField]
		private int priority; // 0x58
		[NonSerialized]
		protected List<CwInputManager.Finger> fingers; // 0x60
		protected bool keyPressed; // 0x68
	
		// Properties
		public Camera Camera { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public LayerMask Layers { get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public ButtonTypes RequiredButtons { get; set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public KeyCode RequiredKey { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public LayerMask GuiLayers { get; set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public EmitType Emit { get; set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public RotationType RotateTo { get; set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public DirectionType NormalDirection { get; set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public RelativeType NormalRelativeTo { get; set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public Transform CustomTransform { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public float NormalOffset { get; set; } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float MouseOffset { get; set; } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public float TouchOffset { get; set; } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public bool StoreStates { get; set; } // 0x0000000183D4F320-0x0000000183D4F330 0x0000000183D4F350-0x0000000183D4F360
		public bool ShowPreview { get; set; } // 0x0000000183D4F310-0x0000000183D4F320 0x0000000183D4F340-0x0000000183D4F350
		public int Priority { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public bool NeedsDrawAngle { get; } // 0x00000001892FC000-0x00000001892FC014 
	
		// Nested types
		public enum RotationType // TypeDefIndex: 56000
		{
			Normal = 0,
			World = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum RelativeType // TypeDefIndex: 56001
		{
			WorldUp = 0,
			CameraUp = 1,
			DrawAngle = 2
		}
	
		public enum DirectionType // TypeDefIndex: 56002
		{
			HitNormal = 0,
			RayDirection = 1,
			CameraDirection = 2
		}
	
		public enum EmitType // TypeDefIndex: 56003
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		[Flags]
		public enum ButtonTypes // TypeDefIndex: 56004
		{
			LeftMouse = 1,
			RightMouse = 2,
			MiddleMouse = 4,
			Touch = 32
		}
	
		// Constructors
		protected P3dHitScreenBase() {} // 0x00000001892FBF58-0x00000001892FC000
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001892FB858-0x00000001892FBA18
		protected virtual void LateUpdate() {} // 0x00000001892FB590-0x00000001892FB7A4
		protected virtual void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void HandleFingerUp(CwInputManager.Finger finger) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDisable() {} // 0x00000001892FB7A4-0x00000001892FB858
		private bool FingerWentDown(CwInputManager.Finger finger) => default; // 0x00000001892FB3E4-0x00000001892FB4C0
		private void HandleFingerDown(CwInputManager.Finger finger) {} // 0x00000001892FB4C0-0x00000001892FB590
		protected virtual void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D) {} // 0x00000001892FB26C-0x00000001892FB3E4
		protected void PaintAt(P3dPointConnector connector, P3dHitCache hitCache, Vector2 screenPosition, Vector2 screenPositionOld, bool preview, float pressure, object owner) {} // 0x00000001892FBA18-0x00000001892FBF58
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, Camera camera, Vector2 screenPositionOld, ref Vector3 finalPosition, ref Quaternion finalRotation) {} // 0x00000001892FAE20-0x00000001892FB26C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenFill")]
	public class P3dHitScreenFill : P3dHitScreen // TypeDefIndex: 56006
	{
		// Fields
		[SerializeField]
		private float fillSpacing; // 0x88
	
		// Properties
		public float FillSpacing { get => default; set {} } // 0x0000000183D56E70-0x0000000183D56E80 0x0000000183D56E90-0x0000000183D56EA0
	
		// Constructors
		public P3dHitScreenFill() {} // 0x00000001892FC6D0-0x00000001892FC6E4
	
		// Methods
		protected override void OnFingerUp(Link link) {} // 0x00000001892FC3FC-0x00000001892FC6D0
		private static Rect GetArea(List<Vector2> points) => default; // 0x00000001892FC1B8-0x00000001892FC3FC
		private static double LineSide(Vector2 a, Vector2 b, Vector2 p) => default; // 0x0000000183D71810-0x0000000183D71870
		private static bool Contains(List<Vector2> points, Vector2 xy) => default; // 0x00000001892FC014-0x00000001892FC1B8
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Line")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenLine")]
	public class P3dHitScreenLine : P3dHitScreenBase // TypeDefIndex: 56008
	{
		// Fields
		[SerializeField]
		private FrequencyType frequency; // 0x70
		[SerializeField]
		private float interval; // 0x74
		[Range(0f, 1f)]
		[SerializeField]
		private float position; // 0x78
		[SerializeField]
		private float pixelOffset; // 0x7C
		[SerializeField]
		private P3dPointConnector connector; // 0x80
	
		// Properties
		public FrequencyType Frequency { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public float Interval { get => default; set {} } // 0x0000000183D56C30-0x0000000183D56C40 0x0000000183D58A80-0x0000000183D58A90
		public float Position { get => default; set {} } // 0x0000000183D56C20-0x0000000183D56C30 0x0000000183D58AA0-0x0000000183D58AB0
		public float PixelOffset { get => default; set {} } // 0x0000000183D51B20-0x0000000183D51B30 0x0000000183D5BDD0-0x0000000183D5BDE0
		public P3dPointConnector Connector { get => default; } // 0x00000001892FCCFC-0x00000001892FCD78 
	
		// Nested types
		public enum FrequencyType // TypeDefIndex: 56007
		{
			StartAndEnd = 0,
			PixelInterval = 1,
			ScaledPixelInterval = 2,
			StretchedPixelInterval = 3,
			StretchedScaledPixelInterval = 4,
			Once = 5
		}
	
		// Constructors
		public P3dHitScreenLine() {} // 0x00000001892FCCE4-0x00000001892FCCFC
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892FC6E4-0x00000001892FC708
		[ContextMenu("Reset Connections")]
		public void ResetConnections() {} // 0x00000001892FCC9C-0x00000001892FCCC0
		protected override void OnEnable() {} // 0x00000001892FC880-0x00000001892FC8B4
		protected virtual void Update() {} // 0x00000001892FCCC0-0x00000001892FCCE4
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x00000001892FC708-0x00000001892FC880
		private void PaintStartEnd(CwInputManager.Finger finger, bool up) {} // 0x00000001892FC9F8-0x00000001892FCB20
		private void PaintStartInterval(CwInputManager.Finger finger, bool up, float pixelSpacing, bool stretch) {} // 0x00000001892FCB20-0x00000001892FCC9C
		private void PaintOne(CwInputManager.Finger finger, bool up, float frac, float pixelOff) {} // 0x00000001892FC8B4-0x00000001892FC9F8
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Through")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitThrough")]
	public class P3dHitThrough : MonoBehaviour // TypeDefIndex: 56011
	{
		// Fields
		[SerializeField]
		private PhaseType paintIn; // 0x18
		[SerializeField]
		private float interval; // 0x1C
		[SerializeField]
		private Transform pointA; // 0x20
		[SerializeField]
		private Transform pointB; // 0x28
		[SerializeField]
		private OrientationType orientation; // 0x30
		[SerializeField]
		private Camera _camera; // 0x38
		[Range(0f, 1f)]
		[SerializeField]
		private float pressure; // 0x40
		[SerializeField]
		private bool preview; // 0x44
		[SerializeField]
		private int priority; // 0x48
		[SerializeField]
		private LineRenderer line; // 0x50
		[SerializeField]
		private P3dLineConnector connector; // 0x58
		[NonSerialized]
		private float current; // 0x60
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float Interval { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public Transform PointA { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Transform PointB { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public OrientationType Orientation { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public Camera Camera { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public float Pressure { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public bool Preview { get => default; set {} } // 0x0000000183D4F170-0x0000000183D4F180 0x0000000183D4F180-0x0000000183D4F190
		public int Priority { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public LineRenderer Line { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public P3dLineConnector Connector { get => default; } // 0x00000001892FDF3C-0x00000001892FDFAC 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 56009
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 56010
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		// Constructors
		public P3dHitThrough() {} // 0x00000001892FDF24-0x00000001892FDF3C
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow() {} // 0x00000001892FD998-0x00000001892FD9A4
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache() {} // 0x00000001892FD958-0x00000001892FD97C
		[ContextMenu("Reset Connections")]
		public void ResetConnections() {} // 0x00000001892FD9C8-0x00000001892FD9E8
		protected virtual void OnEnable() {} // 0x00000001892FD9A4-0x00000001892FD9C8
		protected virtual void Update() {} // 0x00000001892FDED4-0x00000001892FDF24
		protected virtual void LateUpdate() {} // 0x00000001892FD990-0x00000001892FD998
		protected virtual void FixedUpdate() {} // 0x00000001892FD97C-0x00000001892FD990
		private void SubmitHit(bool preview) {} // 0x00000001892FD9E8-0x00000001892FDD08
		private void UpdateHit() {} // 0x00000001892FDD08-0x00000001892FDD70
		private void UpdatePointAndLine() {} // 0x00000001892FDD70-0x00000001892FDED4
	}

	public interface IClone // TypeDefIndex: 56012
	{
		// Methods
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}

	public interface IHit // TypeDefIndex: 56013
	{
	}

	public interface IHitCoord : IHit // TypeDefIndex: 56014
	{
		// Methods
		void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation);
	}

	public interface IHitLine : IHit // TypeDefIndex: 56015
	{
		// Methods
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip);
	}

	public interface IHitPoint : IHit // TypeDefIndex: 56016
	{
		// Methods
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}

	public interface IHitQuad : IHit // TypeDefIndex: 56017
	{
		// Methods
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip);
	}

	public interface IHitTriangle : IHit // TypeDefIndex: 56018
	{
		// Methods
		void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation);
	}

	public interface IBrowsable // TypeDefIndex: 56019
	{
		// Methods
		string GetCategory();
		string GetTitle();
		Texture2D GetIcon();
		UnityEngine.Object GetObject();
	}

	[AddComponentMenu("")]
	public class P3dHitScreen_InEditor : P3dHitScreen // TypeDefIndex: 56020
	{
		// Constructors
		public P3dHitScreen_InEditor() {} // 0x00000001892FD084-0x00000001892FD08C
	
		// Methods
		protected override void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D) {} // 0x000000018350B670-0x000000018350B680
		protected override void LateUpdate() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("Paint in 3D/P3D Material")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterial")]
	public class P3dMaterial : MonoBehaviour, IBrowsable // TypeDefIndex: 56021
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		[SerializeField]
		private List<Texture> textures; // 0x28
		private static List<P3dMaterial> cachedMaterials; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Texture2D Icon { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public List<Texture> Textures { get => default; } // 0x00000001892FE0AC-0x00000001892FE130 
		public static List<P3dMaterial> CachedMaterials { get => default; } // 0x00000001892FDFF8-0x00000001892FE0AC 
	
		// Constructors
		public P3dMaterial() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void ClearCache() {} // 0x00000001892FDFAC-0x00000001892FDFF8
		public string GetCategory() => default; // 0x0000000181041090-0x00000001810410A0
		public string GetTitle() => default; // 0x0000000184276114-0x000000018427611C
		public Texture2D GetIcon() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public UnityEngine.Object GetObject() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	[AddComponentMenu("")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPreset")]
	public class P3dPreset : MonoBehaviour // TypeDefIndex: 56022
	{
		// Fields
		[SerializeField]
		private string title; // 0x18
		[SerializeField]
		private bool addMaterialCloner; // 0x20
		private static List<P3dPreset> cachedPresets; // 0x00
	
		// Properties
		public string Title { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool AddMaterialCloner { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		public P3dPreset() {} // 0x0000000183A1E660-0x0000000183A1E670
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dSeamFixer")]
	public class P3dSeamFixer : ScriptableObject // TypeDefIndex: 56028
	{
		// Fields
		[SerializeField]
		private Mesh source; // 0x18
		[SerializeField]
		private Mesh mesh; // 0x20
		[SerializeField]
		private List<Pair> meshes; // 0x28
		[SerializeField]
		private P3dCoord coord; // 0x30
		[SerializeField]
		private float threshold; // 0x34
		[SerializeField]
		private float border; // 0x38
		private static Dictionary<Mesh, Mesh> cacheFirst; // 0x00
		private static Dictionary<Mesh, Mesh> cacheSecond; // 0x08
		private static Dictionary<Mesh, Mesh> cacheThird; // 0x10
		private static Dictionary<Mesh, Mesh> cacheFourth; // 0x18
	
		// Properties
		public List<Pair> Meshes { get => default; } // 0x0000000189302F48-0x0000000189302FCC 
		public P3dCoord Coord { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public float Threshold { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
		public float Border { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000183D51010-0x0000000183D51020
	
		// Nested types
		[Serializable]
		public class Pair // TypeDefIndex: 56023
		{
			// Fields
			public Mesh Source; // 0x10
			public Mesh Output; // 0x18
	
			// Constructors
			public Pair() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class Ring // TypeDefIndex: 56024
		{
			// Fields
			public List<Point> Points; // 0x10
	
			// Constructors
			public Ring() {} // 0x00000001893032C4-0x000000018930333C
	
			// Methods
			public Point GetPoint(int index) => default; // 0x0000000189303244-0x00000001893032C4
		}
	
		private class Edge // TypeDefIndex: 56025
		{
			// Fields
			public bool Used; // 0x10
			public Point PointA; // 0x18
			public Point PointB; // 0x20
			public bool Flip; // 0x28
	
			// Constructors
			public Edge() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool Match(Point a, Point b) => default; // 0x00000001892F0804-0x00000001892F0824
		}
	
		private class Point // TypeDefIndex: 56026
		{
			// Fields
			public int Index; // 0x10
			public Vector2 Coord; // 0x14
			public Insertion Outer; // 0x20
			public List<Edge> Edges; // 0x28
	
			// Constructors
			public Point() {} // 0x00000001893031CC-0x0000000189303244
		}
	
		private class Insertion // TypeDefIndex: 56027
		{
			// Fields
			public int Index; // 0x10
			public int NewIndex; // 0x14
			public Vector2 NewCoord; // 0x18
	
			// Constructors
			public Insertion() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public P3dSeamFixer() {} // 0x0000000189302F30-0x0000000189302F48
		static P3dSeamFixer() {} // 0x0000000189302DB4-0x0000000189302F30
	
		// Methods
		public static Mesh GetCachedMesh(Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x01FD7C50 */) => default; // 0x0000000189302848-0x000000018930294C
		private static Mesh TryGetCachedMesh(Dictionary<Mesh, Mesh> cache, Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x01FD7C51 */) => default; // 0x0000000189302C18-0x0000000189302DB4
		public void AddMesh(Mesh mesh) {} // 0x00000001892FFAEC-0x00000001892FFBA4
		public void ConvertLegacy() {} // 0x00000001892FFF08-0x00000001892FFFF4
		[ContextMenu("Generate")]
		public void Generate() {} // 0x0000000189302508-0x0000000189302848
		public static void Generate(Mesh source, Mesh output, P3dCoord coord, float threshold, float border) {} // 0x0000000189301730-0x0000000189302508
		private static void AddCoord(List<Vector4> coords, Insertion insertion, bool write) {} // 0x00000001892FFA00-0x00000001892FFAEC
		private static void FixSeams(Mesh source, Mesh output, List<List<int>> submeshes, List<Ring> rings, List<Insertion> insertions, P3dCoord coord) {} // 0x00000001892FFFF4-0x0000000189301730
		private static void TraceEdges(Ring ring, Point point) {} // 0x0000000189302AF8-0x0000000189302C18
		private static void AddPoint(Dictionary<Vector2, Point> points, Vector2 coord, int index) {} // 0x00000001892FFBA4-0x00000001892FFCA4
		private static void AddTriangle(List<Edge> edges, Point pointA, Point pointB, Point pointC) {} // 0x00000001892FFD50-0x00000001892FFF08
		private static void AddTriangle2(List<Edge> edges, Point pointA, Point pointB, Point pointC, bool flip) {} // 0x00000001892FFCA4-0x00000001892FFD50
		private static void RemoveOrAddEdge(List<Edge> edges, Point pointA, Point pointB, bool flip) {} // 0x000000018930294C-0x0000000189302AF8
	}

	[AddComponentMenu("Paint in 3D/P3D Shape")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dShape")]
	public class P3dShape : MonoBehaviour, IBrowsable // TypeDefIndex: 56029
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dShape> cachedShapes; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Texture2D Icon { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public static List<P3dShape> CachedShapes { get => default; } // 0x0000000189303018-0x00000001893030CC 
	
		// Constructors
		public P3dShape() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void ClearCache() {} // 0x0000000189302FCC-0x0000000189303018
		public string GetCategory() => default; // 0x0000000181041090-0x00000001810410A0
		public string GetTitle() => default; // 0x0000000184276114-0x000000018427611C
		public Texture2D GetIcon() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public UnityEngine.Object GetObject() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	[AddComponentMenu("Paint in 3D/P3D Tool")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTool")]
	public class P3dTool : MonoBehaviour, IBrowsable // TypeDefIndex: 56030
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dTool> cachedTools; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Texture2D Icon { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public static List<P3dTool> CachedTools { get => default; } // 0x0000000189303118-0x00000001893031CC 
	
		// Constructors
		public P3dTool() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void ClearCache() {} // 0x00000001893030CC-0x0000000189303118
		public string GetCategory() => default; // 0x0000000181041090-0x00000001810410A0
		public string GetTitle() => default; // 0x0000000184276114-0x000000018427611C
		public Texture2D GetIcon() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public UnityEngine.Object GetObject() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	[Serializable]
	public class P3dModifyAngleRandom : P3dModifier // TypeDefIndex: 56032
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float min; // 0x18
		[SerializeField]
		private float max; // 0x1C
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float Max { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public BlendType Blend { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56031
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyAngleRandom() {} // 0x0000000183D71870-0x0000000183D71890
		static P3dModifyAngleRandom() {} // 0x00000001892FE17C-0x00000001892FE214
	
		// Methods
		protected override void OnModifyAngle(ref float angle, float pressure) {} // 0x00000001892FE130-0x00000001892FE17C
	}

	[Serializable]
	public class P3dModifyColorRandom : P3dModifier // TypeDefIndex: 56034
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private Gradient gradient; // 0x18
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public Gradient Gradient { get => default; } // 0x00000001892FE368-0x00000001892FE3DC 
		public BlendType Blend { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56033
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyColorRandom() {} // 0x0000000183D71890-0x0000000183D718A0
		static P3dModifyColorRandom() {} // 0x00000001892FE2D0-0x00000001892FE368
	
		// Methods
		protected override void OnModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x00000001892FE214-0x00000001892FE2D0
	}

	public class P3dModifyHardnessPressure : P3dModifier // TypeDefIndex: 56036
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float hardness; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Hardness { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public BlendType Blend { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56035
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessPressure() {} // 0x0000000183D718A0-0x0000000183D718B0
		static P3dModifyHardnessPressure() {} // 0x00000001892FE420-0x00000001892FE4B8
	
		// Methods
		protected override void OnModifyHardness(ref float currentHardness, float pressure) {} // 0x00000001892FE3DC-0x00000001892FE420
	}

	[Serializable]
	public class P3dModifyHardnessRandom : P3dModifier // TypeDefIndex: 56038
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float min; // 0x18
		[SerializeField]
		private float max; // 0x1C
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float Max { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public BlendType Blend { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56037
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessRandom() {} // 0x0000000183D718B0-0x0000000183D718D0
		static P3dModifyHardnessRandom() {} // 0x00000001892FE4B8-0x00000001892FE550
	
		// Methods
		protected override void OnModifyHardness(ref float hardness, float pressure) {} // 0x00000001892FE130-0x00000001892FE17C
	}

	[Serializable]
	public class P3dModifyOpacityPressure : P3dModifier // TypeDefIndex: 56040
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float opacity; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Opacity { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public BlendType Blend { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56039
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityPressure() {} // 0x0000000183D718A0-0x0000000183D718B0
		static P3dModifyOpacityPressure() {} // 0x00000001892FE550-0x00000001892FE5E8
	
		// Methods
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure) {} // 0x00000001892FE3DC-0x00000001892FE420
	}

	[Serializable]
	public class P3dModifyOpacityRandom : P3dModifier // TypeDefIndex: 56042
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float min; // 0x18
		[SerializeField]
		private float max; // 0x1C
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float Max { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public BlendType Blend { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56041
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityRandom() {} // 0x0000000183D718B0-0x0000000183D718D0
		static P3dModifyOpacityRandom() {} // 0x00000001892FE5E8-0x00000001892FE680
	
		// Methods
		protected override void OnModifyOpacity(ref float opacity, float pressure) {} // 0x00000001892FE130-0x00000001892FE17C
	}

	[Serializable]
	public class P3dModifyPositionRandom : P3dModifier // TypeDefIndex: 56043
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
	
		// Constructors
		public P3dModifyPositionRandom() {} // 0x0000000183D718A0-0x0000000183D718B0
		static P3dModifyPositionRandom() {} // 0x00000001892FE728-0x00000001892FE7C0
	
		// Methods
		protected override void OnModifyPosition(ref Vector3 position, float pressure) {} // 0x00000001892FE680-0x00000001892FE728
	}

	[Serializable]
	public class P3dModifyRadiusPressure : P3dModifier // TypeDefIndex: 56045
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public BlendType Blend { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56044
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusPressure() {} // 0x0000000183D718A0-0x0000000183D718B0
		static P3dModifyRadiusPressure() {} // 0x00000001892FE7C0-0x00000001892FE858
	
		// Methods
		protected override void OnModifyRadius(ref float currentRadius, float pressure) {} // 0x00000001892FE3DC-0x00000001892FE420
	}

	[Serializable]
	public class P3dModifyRadiusRandom : P3dModifier // TypeDefIndex: 56047
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float min; // 0x18
		[SerializeField]
		private float max; // 0x1C
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float Max { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public BlendType Blend { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56046
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusRandom() {} // 0x0000000183D718B0-0x0000000183D718D0
		static P3dModifyRadiusRandom() {} // 0x00000001892FE858-0x00000001892FE8F0
	
		// Methods
		protected override void OnModifyRadius(ref float radius, float pressure) {} // 0x00000001892FE130-0x00000001892FE17C
	}

	[Serializable]
	public class P3dModifyScaleRandom : P3dModifier // TypeDefIndex: 56049
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private Vector3 min; // 0x18
		[SerializeField]
		private Vector3 max; // 0x24
		[SerializeField]
		private BlendType blend; // 0x30
		[SerializeField]
		private bool uniform; // 0x34
	
		// Properties
		public Vector3 Min { get => default; set {} } // 0x0000000183D52510-0x0000000183D52530 0x0000000183D52530-0x0000000183D52540
		public Vector3 Max { get => default; set {} } // 0x0000000183D59780-0x0000000183D597A0 0x0000000183D5A9E0-0x0000000183D5A9F0
		public BlendType Blend { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public bool Uniform { get => default; set {} } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 56048
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyScaleRandom() {} // 0x0000000183D718D0-0x0000000183D71910
		static P3dModifyScaleRandom() {} // 0x00000001892FEAA0-0x00000001892FEB38
	
		// Methods
		protected override void OnModifyScale(ref Vector3 scale, float pressure) {} // 0x00000001892FE8F0-0x00000001892FEAA0
	}

	[Serializable]
	public class P3dModifyTexturePressure : P3dModifier // TypeDefIndex: 56050
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private Texture texture; // 0x18
		[SerializeField]
		private float pressureMin; // 0x20
		[SerializeField]
		private float pressureMax; // 0x24
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float PressureMin { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public float PressureMax { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
	
		// Constructors
		public P3dModifyTexturePressure() {} // 0x0000000183D71910-0x0000000183D71930
		static P3dModifyTexturePressure() {} // 0x00000001892FEB58-0x00000001892FEBF0
	
		// Methods
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure) {} // 0x00000001892FEB38-0x00000001892FEB58
	}

	[Serializable]
	public class P3dModifyTextureRandom : P3dModifier // TypeDefIndex: 56051
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private List<Texture> textures; // 0x18
	
		// Properties
		public List<Texture> Textures { get => default; } // 0x00000001892FED14-0x00000001892FED98 
	
		// Constructors
		public P3dModifyTextureRandom() {} // 0x0000000183D71890-0x0000000183D718A0
		static P3dModifyTextureRandom() {} // 0x00000001892FEC7C-0x00000001892FED14
	
		// Methods
		protected override void OnModifyTexture(ref Texture texture, float pressure) {} // 0x00000001892FEBF0-0x00000001892FEC7C
	}

	[Serializable]
	public struct P3dBlendMode // TypeDefIndex: 56052
	{
		// Fields
		public const int ALPHA_BLEND = 0; // Metadata: 0x01FD7C6D
		public const int ALPHA_BLEND_INVERSE = 1; // Metadata: 0x01FD7C6E
		public const int PREMULTIPLIED = 2; // Metadata: 0x01FD7C6F
		public const int ADDITIVE = 3; // Metadata: 0x01FD7C70
		public const int ADDITIVE_SOFT = 4; // Metadata: 0x01FD7C71
		public const int SUBTRACTIVE = 5; // Metadata: 0x01FD7C72
		public const int SUBTRACTIVE_SOFT = 6; // Metadata: 0x01FD7C73
		public const int REPLACE = 7; // Metadata: 0x01FD7C74
		public const int REPLACE_ORIGINAL = 8; // Metadata: 0x01FD7C75
		public const int REPLACE_CUSTOM = 9; // Metadata: 0x01FD7C76
		public const int MULTIPLY_INVERSE_RGB = 10; // Metadata: 0x01FD7C77
		public const int BLUR = 11; // Metadata: 0x01FD7C78
		public const int NORMAL_BLEND = 12; // Metadata: 0x01FD7C79
		public const int NORMAL_REPLACE = 13; // Metadata: 0x01FD7C7A
		public const int FLOW = 14; // Metadata: 0x01FD7C7B
		public const int NORMAL_REPLACE_ORIGINAL = 15; // Metadata: 0x01FD7C7C
		public const int NORMAL_REPLACE_CUSTOM = 16; // Metadata: 0x01FD7C7D
		public const int COUNT = 17; // Metadata: 0x01FD7C7E
		public static readonly string[] NAMES; // 0x00
		public int Index; // 0x00
		public UnityEngine.Color Color; // 0x04
		public Texture Texture; // 0x18
		public float Kernel; // 0x20
		public Vector4 Channels; // 0x24
		private static int _Channels; // 0x08
		private static int _ReplaceColor; // 0x0C
		private static int _ReplaceTexture; // 0x10
		private static int _ReplaceTextureSize; // 0x14
		private static int _Kernel; // 0x18
	
		// Constructors
		static P3dBlendMode() {
			NAMES = default;
			_Channels = default;
			_ReplaceColor = default;
			_ReplaceTexture = default;
			_ReplaceTextureSize = default;
			_Kernel = default;
		} // 0x00000001892F1204-0x00000001892F1574
	
		// Methods
		public static P3dBlendMode AlphaBlend(Vector4 channels) => default; // 0x00000001892F0A9C-0x00000001892F0AE0
		public static P3dBlendMode AlphaBlendInverse(Vector4 channels) => default; // 0x00000001892F0A54-0x00000001892F0A9C
		public static P3dBlendMode Premultiplied(Vector4 channels) => default; // 0x00000001892F104C-0x00000001892F1094
		public static P3dBlendMode Additive(Vector4 channels) => default; // 0x00000001892F0A0C-0x00000001892F0A54
		public static P3dBlendMode AdditiveSoft(Vector4 channels) => default; // 0x00000001892F09C4-0x00000001892F0A0C
		public static P3dBlendMode Subtractive(Vector4 channels) => default; // 0x00000001892F11BC-0x00000001892F1204
		public static P3dBlendMode SubtractiveSoft(Vector4 channels) => default; // 0x00000001892F1174-0x00000001892F11BC
		public static P3dBlendMode Replace(Vector4 channels) => default; // 0x00000001892F112C-0x00000001892F1174
		public static P3dBlendMode ReplaceOriginal(Vector4 channels) => default; // 0x00000001892F10E4-0x00000001892F112C
		public static P3dBlendMode ReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels) => default; // 0x00000001892F1094-0x00000001892F10E4
		public static P3dBlendMode MultiplyInverseRGB(Vector4 channels) => default; // 0x00000001892F0EDC-0x00000001892F0F24
		public static P3dBlendMode Blur(float kernel, Vector4 channels) => default; // 0x00000001892F0D00-0x00000001892F0D44
		public static P3dBlendMode NormalBlend(Vector4 channels) => default; // 0x00000001892F0F24-0x00000001892F0F6C
		public static P3dBlendMode NormalReplace(Vector4 channels) => default; // 0x00000001892F1004-0x00000001892F104C
		public static P3dBlendMode Flow(float kernel, Vector4 channels) => default; // 0x00000001892F0DC0-0x00000001892F0E04
		public static P3dBlendMode NormalReplaceOriginal(Vector4 channels) => default; // 0x00000001892F0FBC-0x00000001892F1004
		public static P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels) => default; // 0x00000001892F0F6C-0x00000001892F0FBC
		public void Apply(Material material) {} // 0x00000001892F0AE0-0x00000001892F0D00
		public static string GetName(int index) => default; // 0x00000001892F0E70-0x00000001892F0EDC
		public static bool operator ==(P3dBlendMode a, int b) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public static bool operator !=(P3dBlendMode a, int b) => default; // 0x00000001892F1574-0x00000001892F157C
		public static implicit operator int(P3dBlendMode a) => default; // 0x0000000183D4E980-0x0000000183D4E990
		public override int GetHashCode() => default; // 0x00000001892F0E04-0x00000001892F0E70
		public override bool Equals(object obj) => default; // 0x00000001892F0D44-0x00000001892F0DC0
	}

	public static class P3dBlit // TypeDefIndex: 56053
	{
		// Fields
		private static Material cachedWhite; // 0x00
		private static bool cachedWhiteSet; // 0x08
		private static Material cachedTexture; // 0x10
		private static bool cachedTextureSet; // 0x18
		private static Material cachedNormal; // 0x20
		private static bool cachedNormalSet; // 0x28
		private static Material cachedPremultiply; // 0x30
		private static bool cachedPremultiplySet; // 0x38
		private static int _Buffer; // 0x3C
		private static int _BufferSize; // 0x40
		private static int _Texture; // 0x44
		private static int _Color; // 0x48
	
		// Constructors
		static P3dBlit() {} // 0x0000000189303F44-0x0000000189304018
	
		// Methods
		public static void White(RenderTexture rendertexture, Mesh mesh, int submesh, P3dCoord coord) {} // 0x0000000189303D04-0x0000000189303F44
		public static void Texture(RenderTexture rendertexture, Mesh mesh, int submesh, Texture texture, P3dCoord coord) {} // 0x0000000189303A84-0x0000000189303D04
		public static void Normal(RenderTexture rendertexture, Texture texture) {} // 0x000000018930377C-0x00000001893038C4
		public static void Premultiply(RenderTexture rendertexture, Texture texture, UnityEngine.Color tint) {} // 0x00000001893038C4-0x0000000189303A84
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounter")]
	public class P3dChangeCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 56054
	{
		// Fields
		public static LinkedList<P3dChangeCounter> Instances; // 0x00
		private LinkedListNode<P3dChangeCounter> instancesNode; // 0x98
		[Range(0f, 1f)]
		[SerializeField]
		private float threshold; // 0xA0
		[SerializeField]
		private Texture texture; // 0xA8
		[SerializeField]
		private UnityEngine.Color color; // 0xB0
		[SerializeField]
		private int count; // 0xC0
		[SerializeField]
		private P3dReader changeReader; // 0xC8
		[SerializeField]
		protected NativeArray<Color32> changePixels; // 0xD0
	
		// Properties
		public float Threshold { get => default; set {} } // 0x0000000183D58340-0x0000000183D58350 0x0000000189304DE4-0x0000000189304E14
		public Texture Texture { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000189304D60-0x0000000189304DE4
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D6C040-0x0000000183D6C050 0x0000000189304D10-0x0000000189304D60
		public int Count { get => default; } // 0x0000000183D57EF0-0x0000000183D57F00 
		public float Ratio { get => default; } // 0x0000000189304CEC-0x0000000189304D10 
		public P3dReader ChangeReader { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
	
		// Constructors
		public P3dChangeCounter() {} // 0x0000000189304CB8-0x0000000189304CEC
		static P3dChangeCounter() {} // 0x0000000189304C3C-0x0000000189304CB8
	
		// Methods
		public void MarkChangeReaderAsDirty() {} // 0x00000001893046DC-0x00000001893046F4
		public static long GetTotal(ICollection<P3dChangeCounter> counters = null) => default; // 0x000000018930423C-0x00000001893043D0
		public static long GetCount(ICollection<P3dChangeCounter> counters = null) => default; // 0x0000000189304018-0x00000001893041B0
		public static float GetRatio(ICollection<P3dChangeCounter> counters = null) => default; // 0x00000001893041B0-0x000000018930423C
		private void HandleCompleteChange(NativeArray<Color32> pixels) {} // 0x00000001893043D0-0x0000000189304538
		protected override void HandleComplete(int boost) {} // 0x0000000189304538-0x00000001893046DC
		protected override void OnEnable() {} // 0x0000000189304874-0x0000000189304978
		protected override void OnDisable() {} // 0x000000018930476C-0x0000000189304874
		protected override void OnDestroy() {} // 0x00000001893046F4-0x000000018930476C
		protected override void Update() {} // 0x0000000189304978-0x0000000189304C3C
	}

	public enum P3dChannel // TypeDefIndex: 56055
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Alpha = 3
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounter")]
	public class P3dChannelCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 56056
	{
		// Fields
		public static LinkedList<P3dChannelCounter> Instances; // 0x00
		private LinkedListNode<P3dChannelCounter> instancesNode; // 0x98
		[Range(0f, 1f)]
		[SerializeField]
		private float threshold; // 0xA0
		[SerializeField]
		private int countR; // 0xA4
		[SerializeField]
		private int countG; // 0xA8
		[SerializeField]
		private int countB; // 0xAC
		[SerializeField]
		private int countA; // 0xB0
	
		// Properties
		public float Threshold { get => default; set {} } // 0x0000000183D58340-0x0000000183D58350 0x0000000189305F70-0x0000000189305F98
		public int CountR { get => default; } // 0x0000000183D51870-0x0000000183D51880 
		public int CountG { get => default; } // 0x0000000183D51860-0x0000000183D51870 
		public int CountB { get => default; } // 0x0000000183D51880-0x0000000183D51890 
		public int CountA { get => default; } // 0x0000000183D59C80-0x0000000183D59C90 
		public float RatioR { get => default; } // 0x0000000189305F4C-0x0000000189305F70 
		public float RatioG { get => default; } // 0x0000000189305E74-0x0000000189305E98 
		public float RatioB { get => default; } // 0x0000000189305E50-0x0000000189305E74 
		public float RatioA { get => default; } // 0x0000000189305E2C-0x0000000189305E50 
		public Vector4 RatioRGBA { get => default; } // 0x0000000189305E98-0x0000000189305F4C 
	
		// Constructors
		public P3dChannelCounter() {} // 0x0000000189305E18-0x0000000189305E2C
		static P3dChannelCounter() {} // 0x0000000189305D9C-0x0000000189305E18
	
		// Methods
		public static long GetTotal(ICollection<P3dChannelCounter> counters = null) => default; // 0x00000001893059BC-0x0000000189305B50
		public static long GetCountR(ICollection<P3dChannelCounter> counters = null) => default; // 0x00000001893052DC-0x0000000189305474
		public static long GetCountG(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189305144-0x00000001893052DC
		public static long GetCountB(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189304FAC-0x0000000189305144
		public static long GetCountA(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189304E14-0x0000000189304FAC
		public static float GetRatioR(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189305930-0x00000001893059BC
		public static float GetRatioG(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018930558C-0x0000000189305618
		public static float GetRatioB(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189305500-0x000000018930558C
		public static float GetRatioA(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189305474-0x0000000189305500
		public static Vector4 GetRatioRGBA(ICollection<P3dChannelCounter> counters = null) => default; // 0x0000000189305618-0x0000000189305930
		protected override void OnEnable() {} // 0x0000000189305D10-0x0000000189305D9C
		protected override void OnDisable() {} // 0x0000000189305C80-0x0000000189305D10
		protected override void HandleComplete(int boost) {} // 0x0000000189305B50-0x0000000189305C80
	}

	public abstract class P3dClone : MonoBehaviour, IClone // TypeDefIndex: 56057
	{
		// Fields
		[NonSerialized]
		public static int MatrixCount; // 0x00
		[NonSerialized]
		public static int ClonerCount; // 0x04
		[NonSerialized]
		private static List<Matrix4x4> tempPosMatrices; // 0x08
		[NonSerialized]
		private static List<Matrix4x4> tempRotMatrices; // 0x10
		[NonSerialized]
		private static List<IClone> tempCloners; // 0x18
		private static LinkedList<P3dClone> instances; // 0x20
		private LinkedListNode<P3dClone> instancesNode; // 0x18
	
		// Properties
		public static LinkedList<P3dClone> Instances { get; } // 0x00000001893070A0-0x00000001893070F0 
	
		// Constructors
		protected P3dClone() {} // 0x000000018426FE60-0x000000018426FE68
		static P3dClone() {} // 0x0000000189306F04-0x00000001893070A0
	
		// Methods
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
		public static void BuildCloners(List<IClone> cloners = null) {} // 0x00000001893066D4-0x0000000189306B08
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex) {} // 0x0000000189306B08-0x0000000189306E08
		protected virtual void OnEnable() {} // 0x0000000189306E88-0x0000000189306F04
		protected virtual void OnDisable() {} // 0x0000000189306E08-0x0000000189306E88
	}

	[AddComponentMenu("Paint in 3D/P3D Clone Mirror")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCloneMirror")]
	public class P3dCloneMirror : P3dClone // TypeDefIndex: 56058
	{
		// Fields
		[SerializeField]
		private bool flip; // 0x20
	
		// Properties
		public bool Flip { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		public P3dCloneMirror() {} // 0x0000000189306688-0x00000001893066D4
	
		// Methods
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix) {} // 0x0000000189305F98-0x0000000189306688
	}

	[AddComponentMenu("Paint in 3D/P3D Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColor")]
	public class P3dColor : MonoBehaviour // TypeDefIndex: 56060
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private List<Contribution> contributions; // 0x28
		private static LinkedList<P3dColor> instances; // 0x00
		private LinkedListNode<P3dColor> instancesNode; // 0x30
	
		// Properties
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
		public static LinkedList<P3dColor> Instances { get => default; } // 0x0000000189308654-0x00000001893086A4 
		public int Total { get => default; } // 0x00000001893087DC-0x0000000189308944 
		public int Solid { get => default; } // 0x00000001893086EC-0x00000001893087DC 
		public float Ratio { get => default; } // 0x00000001893086A4-0x00000001893086EC 
	
		// Nested types
		[SerializeField]
		private class Contribution // TypeDefIndex: 56059
		{
			// Fields
			public P3dColorCounter Counter; // 0x10
			public int Solid; // 0x18
	
			// Constructors
			public Contribution() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public P3dColor() {} // 0x000000018426FE60-0x000000018426FE68
		static P3dColor() {} // 0x00000001893085D8-0x0000000189308654
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001893082F0-0x00000001893084A8
		protected virtual void OnDisable() {} // 0x0000000189308128-0x00000001893082F0
		public void Contribute(P3dColorCounter counter, int solid) {} // 0x000000018930805C-0x0000000189308128
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution) => default; // 0x00000001893084A8-0x00000001893085D8
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounter")]
	public class P3dColorCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 56062
	{
		// Fields
		public static LinkedList<P3dColorCounter> Instances; // 0x00
		private LinkedListNode<P3dColorCounter> instancesNode; // 0x98
		[Range(0f, 1f)]
		[SerializeField]
		private float threshold; // 0xA0
		[NonSerialized]
		private List<Contribution> contributions; // 0xA8
	
		// Properties
		public float Threshold { get => default; set {} } // 0x0000000183D58340-0x0000000183D58350 0x0000000189305F70-0x0000000189305F98
		public List<Contribution> Contributions { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
	
		// Nested types
		public class Contribution // TypeDefIndex: 56061
		{
			// Fields
			public P3dColor Color; // 0x10
			public int Count; // 0x18
			public float Ratio; // 0x1C
			public byte R; // 0x20
			public byte G; // 0x21
			public byte B; // 0x22
			public byte A; // 0x23
			public static Stack<Contribution> Pool; // 0x00
	
			// Constructors
			public Contribution() {} // 0x000000018350B670-0x000000018350B680
			static Contribution() {} // 0x00000001893034CC-0x0000000189303558
		}
	
		// Constructors
		public P3dColorCounter() {} // 0x0000000189307FCC-0x000000018930805C
		static P3dColorCounter() {} // 0x0000000189307F50-0x0000000189307FCC
	
		// Methods
		public static long GetTotal(ICollection<P3dColorCounter> counters = null) => default; // 0x0000000189307734-0x00000001893078C8
		public static long GetCount(P3dColor color, ICollection<P3dColorCounter> counters = null) => default; // 0x00000001893074F4-0x00000001893076A4
		public static float GetRatio(P3dColor color, ICollection<P3dColorCounter> counters = null) => default; // 0x00000001893076A4-0x0000000189307734
		public int Count(P3dColor color) => default; // 0x0000000189307390-0x00000001893074F4
		public float Ratio(P3dColor color) => default; // 0x0000000189307F18-0x0000000189307F50
		protected override void OnEnable() {} // 0x0000000189307BC0-0x0000000189307C4C
		protected override void OnDisable() {} // 0x0000000189307B24-0x0000000189307BC0
		protected override void HandleComplete(int boost) {} // 0x00000001893078C8-0x0000000189307B24
		private void ClearContributions() {} // 0x00000001893070F0-0x00000001893071E0
		private void PrepareContributions() {} // 0x0000000189307C4C-0x0000000189307F18
		private void Contribute(int scale) {} // 0x00000001893071E0-0x0000000189307390
	}

	[Serializable]
	public abstract class P3dCommand // TypeDefIndex: 56063
	{
		// Fields
		public int Index; // 0x10
		public bool Preview; // 0x14
		public int Priority; // 0x18
		public P3dHashedMaterial Material; // 0x20
		public int Pass; // 0x30
		public P3dHashedModel Model; // 0x38
		public int Submesh; // 0x48
		public P3dHashedTexture LocalMaskTexture; // 0x50
		public Vector4 LocalMaskChannel; // 0x60
		private static int _LocalMaskTexture; // 0x00
		private static int _LocalMaskChannel; // 0x04
	
		// Properties
		public abstract bool RequireMesh { get; }
	
		// Constructors
		protected P3dCommand() {} // 0x000000018350B670-0x000000018350B680
		static P3dCommand() {} // 0x0000000189308E10-0x0000000189308E8C
	
		// Methods
		public static void BuildMaterial(ref Material material, ref int materialHash, string path, string keyword = null) {} // 0x0000000189308A94-0x0000000189308B34
		public static int Compare(P3dCommand a, P3dCommand b) => default; // 0x0000000189308B34-0x0000000189308B90
		public void SetState(bool preview, int priority) {} // 0x0000000183D71930-0x0000000183D71940
		public virtual void Apply(Material material) {} // 0x0000000189308944-0x0000000189308A00
		public abstract void Pool();
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);
		public abstract P3dCommand SpawnCopy();
		public P3dCommand SpawnCopyLocal(Transform transform) => default; // 0x0000000189308B90-0x0000000189308CD0
		public P3dCommand SpawnCopyWorld(Transform transform) => default; // 0x0000000189308CD0-0x0000000189308E10
		protected T SpawnCopy<T>(Stack<T> pool)
			where T : P3dCommand, new() => default;
		public virtual void Apply(P3dPaintableTexture paintableTexture) {} // 0x0000000189308A00-0x0000000189308A94
	}

	public static class P3dCommon // TypeDefIndex: 56065
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/PaintIn3D#"; // Metadata: 0x01FD7C8D
		public const string ComponentMenuPrefix = "Paint in 3D/P3D "; // Metadata: 0x01FD7CBF
		public const string ComponentHitMenuPrefix = "Paint in 3D/Hit/P3D "; // Metadata: 0x01FD7CD0
		public static Action<Camera> OnCameraDraw; // 0x00
		private static int _Coord; // 0x08
		private static Mesh sphereMesh; // 0x10
		private static bool sphereMeshSet; // 0x18
		private static Mesh quadMesh; // 0x20
		private static bool quadMeshSet; // 0x28
		private static Texture2D tempReadTexture; // 0x30
	
		// Constructors
		static P3dCommon() {} // 0x000000018930B6C8-0x000000018930B8A8
	
		// Methods
		public static float RatioToPercentage(float ratio01, int decimalPlaces) => default; // 0x000000018930B0F8-0x000000018930B1A4
		public static RenderTexture GetRenderTexture(RenderTexture other) => default; // 0x000000018930AAE8-0x000000018930ABA0
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, RenderTexture other) => default; // 0x000000018930A988-0x000000018930AA6C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc) => default; // 0x000000018930ABA0-0x000000018930AC1C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB) => default; // 0x000000018930AA6C-0x000000018930AAE8
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture) => default; // 0x000000018930B608-0x000000018930B610
		public static Quaternion NormalToCameraRotation(Vector3 normal, Camera optionalCamera = null) => default; // 0x000000018930AFB4-0x000000018930B0F8
		public static Vector3 GetCameraUp(Camera camera = null) => default; // 0x0000000189309994-0x0000000189309A58
		public static bool CanReadPixels(TextureFormat format) => default; // 0x00000001893091F0-0x0000000189309208
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture) {} // 0x000000018930B1A4-0x000000018930B39C
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture) {} // 0x000000018930B39C-0x000000018930B608
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary) => default; // 0x0000000189309424-0x00000001893096A8
		public static bool HasMipMaps(Texture texture) => default; // 0x000000018930AD34-0x000000018930AE34
		public static Mesh GetSphereMesh() => default; // 0x000000018930AC1C-0x000000018930AD34
		public static Mesh GetMesh(GameObject root, Mesh mesh = null) => default; // 0x0000000189309AE0-0x0000000189309BEC
		public static Mesh GetQuadMesh() => default; // 0x000000018930A0D0-0x000000018930A1EC
		public static UnityEngine.Color GetPixel(RenderTexture renderTexture, Vector2 uv, bool mipMaps = false /* Metadata: 0x01FD7C83 */) => default; // 0x0000000189309BEC-0x0000000189309EB4
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x01FD7C84 */, bool mipMaps = false /* Metadata: 0x01FD7C85 */, int width = 0 /* Metadata: 0x01FD7C86 */, int height = 0 /* Metadata: 0x01FD7C87 */) => default; // 0x000000018930A738-0x000000018930A988
		public static void SaveBytes(string saveName, byte[] data, bool save = true /* Metadata: 0x01FD7C88 */) {} // 0x000000018930B610-0x000000018930B68C
		public static byte[] LoadBytes(string saveName) => default; // 0x000000018930AE8C-0x000000018930AEEC
		public static bool SaveExists(string saveName) => default; // 0x000000018930B68C-0x000000018930B694
		public static void ClearSave(string saveName, bool save = true /* Metadata: 0x01FD7C89 */) {} // 0x0000000189309208-0x0000000189309244
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition) => default; // 0x0000000189309EB4-0x0000000189309F38
		public static Vector3 GetPosition(Vector3 positionA, Vector3 positionB, Vector3 positionC) => default; // 0x0000000189309F38-0x0000000189309FEC
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2) => default; // 0x0000000189309FEC-0x000000018930A0D0
		public static float GetRadius(Vector3 size) => default; // 0x000000018930A4A4-0x000000018930A4DC
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition) => default; // 0x000000018930A1EC-0x000000018930A2E0
		public static float GetRadius(Vector3 size, Vector3 positionA, Vector3 positionB, Vector3 positionC) => default; // 0x000000018930A2E0-0x000000018930A4A4
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2) => default; // 0x000000018930A4DC-0x000000018930A738
		public static Vector3 ScaleAspect(Vector3 size, float aspect) => default; // 0x000000018930B694-0x000000018930B6C8
		public static float GetAspect(Texture textureA, Texture textureB = null) => default; // 0x00000001893098BC-0x0000000189309994
		public static void Blit(RenderTexture renderTexture, Texture other) {} // 0x0000000189308FF0-0x0000000189309060
		public static void Blit(RenderTexture renderTexture, Material material, int pass) {} // 0x0000000189309060-0x00000001893090E8
		public static Vector4 IndexToVector(int index) => default; // 0x000000018930AE34-0x000000018930AE8C
		public static void Draw(Material material, int pass, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord) {} // 0x00000001893097A4-0x00000001893098BC
		public static void Draw(Material material, int pass) {} // 0x00000001893096A8-0x00000001893097A4
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps) => default; // 0x0000000189309384-0x0000000189309424
		public static Material GetMaterial(Renderer renderer, int materialIndex = 0 /* Metadata: 0x01FD7C8A */) => default; // 0x0000000189309A58-0x0000000189309AE0
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x01FD7C8B */) => default; // 0x0000000189309244-0x0000000189309384
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1 /* Metadata: 0x01FD7C8C */) => default; // 0x0000000189308E8C-0x0000000189308FF0
		public static Shader LoadShader(string shaderName) => default; // 0x000000018930AEEC-0x000000018930AFB4
		public static Material BuildMaterial(Shader shader) => default; // 0x00000001893090E8-0x0000000189309148
		public static Material BuildMaterial(string shaderName, string keyword = null) => default; // 0x0000000189309148-0x00000001893091F0
	}

	public enum P3dCoord // TypeDefIndex: 56066
	{
		First = 0,
		Second = 1,
		Third = 2,
		Fourth = 3
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCoordCopier")]
	public class P3dCoordCopier : ScriptableObject // TypeDefIndex: 56068
	{
		// Fields
		[SerializeField]
		private Mesh source; // 0x18
		[SerializeField]
		private Coord first; // 0x20
		[SerializeField]
		private Coord second; // 0x24
		[SerializeField]
		private Coord third; // 0x28
		[SerializeField]
		private Coord fourth; // 0x2C
		[SerializeField]
		private Mesh mesh; // 0x30
		[NonSerialized]
		private static List<BoneWeight> boneWeights; // 0x00
		[NonSerialized]
		private static List<Color32> colors; // 0x08
		[NonSerialized]
		private static List<Vector3> positions; // 0x10
		[NonSerialized]
		private static List<Vector3> normals; // 0x18
		[NonSerialized]
		private static List<Vector4> tangents; // 0x20
		[NonSerialized]
		private static List<Vector4> coords0; // 0x28
		[NonSerialized]
		private static List<Vector4> coords1; // 0x30
		[NonSerialized]
		private static List<Vector4> coords2; // 0x38
		[NonSerialized]
		private static List<Vector4> coords3; // 0x40
		[NonSerialized]
		private static List<Vector4> coordsNone; // 0x48
		[NonSerialized]
		private static List<int> indices; // 0x50
	
		// Properties
		public Mesh Source { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Coord First { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public Coord Second { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public Coord Third { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public Coord Fourth { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
	
		// Nested types
		public enum Coord // TypeDefIndex: 56067
		{
			First = 0,
			Second = 1,
			Third = 2,
			Fourth = 3,
			None = 4
		}
	
		// Constructors
		public P3dCoordCopier() {} // 0x000000018930C4DC-0x000000018930C500
		static P3dCoordCopier() {} // 0x000000018930C0CC-0x000000018930C4DC
	
		// Methods
		public List<Vector4> GetCoords(Coord coord) => default; // 0x000000018930BFC8-0x000000018930C074
		public void Generate() {} // 0x000000018930B8A8-0x000000018930BFC8
		protected virtual void OnDestroy() {} // 0x000000018930C074-0x000000018930C0CC
	}

	[AddComponentMenu("Paint in 3D/P3D Gradually Fade")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dGraduallyFade")]
	public class P3dGraduallyFade : MonoBehaviour // TypeDefIndex: 56069
	{
		// Fields
		[SerializeField]
		private P3dPaintableTexture paintableTexture; // 0x18
		[Range(0f, 1f)]
		[SerializeField]
		private float threshold; // 0x20
		[SerializeField]
		private float speed; // 0x24
		[SerializeField]
		private P3dBlendMode blendMode; // 0x28
		[SerializeField]
		private Texture blendTexture; // 0x60
		[SerializeField]
		private P3dPaintableTexture blendPaintableTexture; // 0x68
		[SerializeField]
		private UnityEngine.Color blendColor; // 0x70
		[SerializeField]
		private Texture maskTexture; // 0x80
		[SerializeField]
		private P3dPaintableTexture maskPaintableTexture; // 0x88
		[SerializeField]
		private P3dChannel maskChannel; // 0x90
		[SerializeField]
		private float counter; // 0x94
	
		// Properties
		public P3dPaintableTexture PaintableTexture { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float Threshold { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public float Speed { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000183D71940-0x0000000183D71970 0x000000018930C950-0x000000018930C97C
		public Texture BlendTexture { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public P3dPaintableTexture BlendPaintableTexture { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public UnityEngine.Color BlendColor { get => default; set {} } // 0x0000000183D5AAE0-0x0000000183D5AAF0 0x0000000183D6C100-0x0000000183D6C110
		public Texture MaskTexture { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public P3dPaintableTexture MaskPaintableTexture { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public P3dChannel MaskChannel { get => default; set {} } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
	
		// Constructors
		public P3dGraduallyFade() {} // 0x000000018930C88C-0x000000018930C950
	
		// Methods
		protected virtual void Update() {} // 0x000000018930C500-0x000000018930C88C
	}

	[Serializable]
	public struct P3dGroup // TypeDefIndex: 56070
	{
		// Fields
		[SerializeField]
		private int index; // 0x00
	
		// Constructors
		public P3dGroup(int newIndex) {
			index = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	
		// Methods
		public static implicit operator int(P3dGroup group) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static implicit operator P3dGroup(int index) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public override string ToString() => default; // 0x000000018930CF08-0x000000018930CF10
	}

	public class P3dGroupData : ScriptableObject // TypeDefIndex: 56073
	{
		// Fields
		[SerializeField]
		private int index; // 0x18
		[SerializeField]
		private List<TextureData> textureDatas; // 0x20
		[Multiline(10)]
		[SerializeField]
		private string shaderData; // 0x28
		private List<Entry> entries; // 0x30
	
		// Properties
		public int Index { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public List<TextureData> TextureDatas { get => default; } // 0x000000018930CE84-0x000000018930CF08 
		public string ShaderData { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Nested types
		[Serializable]
		public class TextureData // TypeDefIndex: 56071
		{
			// Fields
			public string Name; // 0x10
			public P3dBlendMode BlendMode; // 0x18
	
			// Constructors
			public TextureData() {} // 0x00000001893193FC-0x0000000189319494
		}
	
		private class Entry // TypeDefIndex: 56072
		{
			// Fields
			public string Path; // 0x10
			public string Property; // 0x18
	
			// Constructors
			public Entry() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public P3dGroupData() {} // 0x000000018930CE04-0x000000018930CE84
	
		// Methods
		public void TryGetShaderSlotName(string shaderPath, ref string propertyName) {} // 0x000000018930CA6C-0x000000018930CE04
		public bool Supports(Shader shader) => default; // 0x000000018930C9F0-0x000000018930CA6C
		public string GetName(bool prefixNumber) => default; // 0x000000018930C97C-0x000000018930C9F0
	}

	[Serializable]
	public struct P3dHash // TypeDefIndex: 56074
	{
		// Fields
		[SerializeField]
		private int v; // 0x00
	
		// Constructors
		public P3dHash(int newValue) {
			v = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018930CF10-0x000000018930CF6C
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public static implicit operator int(P3dHash hash) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static implicit operator P3dHash(int index) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public override string ToString() => default; // 0x000000018930CF08-0x000000018930CF10
	}

	[Serializable]
	public struct P3dHashedMaterial // TypeDefIndex: 56075
	{
		// Fields
		[NonSerialized]
		private Material instance; // 0x00
		[SerializeField]
		private int hash; // 0x08
	
		// Constructors
		public P3dHashedMaterial(Material newInstance, int newHash) {
			instance = default;
			hash = default;
		} // 0x0000000184274600-0x000000018427461C
	
		// Methods
		public bool TryGetInstance(out Material model) {
			model = default;
			return default;
		} // 0x000000018930CF6C-0x000000018930D034
	}

	[Serializable]
	public struct P3dHashedModel // TypeDefIndex: 56076
	{
		// Fields
		[NonSerialized]
		private P3dModel instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedModel(P3dModel newInstance) => default; // 0x000000018930D12C-0x000000018930D1C0
		public bool TryGetInstance(out P3dModel model) {
			model = default;
			return default;
		} // 0x000000018930D034-0x000000018930D12C
	}

	[Serializable]
	public struct P3dHashedTexture // TypeDefIndex: 56077
	{
		// Fields
		[NonSerialized]
		private Texture instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedTexture(Texture newInstance) => default; // 0x000000018930D2AC-0x000000018930D370
		public static implicit operator Texture(P3dHashedTexture hashed) => default; // 0x000000018930D288-0x000000018930D2AC
		public bool TryGetInstance(out Texture texture) {
			texture = default;
			return default;
		} // 0x000000018930D1C0-0x000000018930D288
	}

	public struct P3dHit // TypeDefIndex: 56078
	{
		// Fields
		public Transform Root; // 0x00
		public Vector2 First; // 0x08
		public Vector2 Second; // 0x10
	
		// Constructors
		public P3dHit(RaycastHit hit) {
			Root = default;
			First = default;
			Second = default;
		} // 0x000000018930D370-0x000000018930D400
	}

	[Serializable]
	public class P3dLineConnector // TypeDefIndex: 56080
	{
		// Fields
		[SerializeField]
		private float hitSpacing; // 0x10
		[SerializeField]
		private int hitLimit; // 0x14
		[SerializeField]
		protected bool connectHits; // 0x18
		[SerializeField]
		protected bool clipConnected; // 0x19
		[NonSerialized]
		private List<Link> links; // 0x20
		[NonSerialized]
		private static Stack<Link> linkPool; // 0x00
		[NonSerialized]
		protected P3dHitCache hitCache; // 0x28
	
		// Properties
		public float HitSpacing { get => default; set {} } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public int HitLimit { get => default; set {} } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public bool ConnectHits { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool ClipConnected { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public P3dHitCache HitCache { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		private class Link // TypeDefIndex: 56079
		{
			// Fields
			public object Owner; // 0x10
			public Vector3 Position; // 0x18
			public Vector3 EndPosition; // 0x24
			public float Age; // 0x30
			public bool Preview; // 0x34
	
			// Constructors
			public Link() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public P3dLineConnector() {} // 0x000000018930DFEC-0x000000018930E0A0
		static P3dLineConnector() {} // 0x000000018930DF60-0x000000018930DFEC
	
		// Methods
		public void ClearHitCache() {} // 0x000000018930D50C-0x000000018930D52C
		public void ResetConnections() {} // 0x000000018930D52C-0x000000018930D614
		public void BreakHits(object owner) {} // 0x000000018930D400-0x000000018930D50C
		public void SubmitLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, object owner) {} // 0x000000018930D614-0x000000018930DD7C
		public void Update() {} // 0x000000018930DE30-0x000000018930DF60
		private bool TryGetLink(object owner, ref Link link) => default; // 0x000000018930DD7C-0x000000018930DE30
	}

	[AddComponentMenu("Paint in 3D/P3D Mask")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMask")]
	public class P3dMask : MonoBehaviour // TypeDefIndex: 56081
	{
		// Fields
		[SerializeField]
		private Texture texture; // 0x18
		[SerializeField]
		private P3dChannel channel; // 0x20
		[SerializeField]
		private Vector2 stretch; // 0x24
		private static LinkedList<P3dMask> instances; // 0x00
		private LinkedListNode<P3dMask> instancesNode; // 0x30
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public P3dChannel Channel { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public Vector2 Stretch { get => default; set {} } // 0x0000000183D50A80-0x0000000183D50AA0 0x0000000183D71680-0x0000000183D71690
		public static LinkedList<P3dMask> Instances { get => default; } // 0x000000018930E4B8-0x000000018930E508 
		public Matrix4x4 Matrix { get => default; } // 0x000000018930E508-0x000000018930E560 
	
		// Constructors
		public P3dMask() {} // 0x000000018930E49C-0x000000018930E4B8
		static P3dMask() {} // 0x000000018930E420-0x000000018930E49C
	
		// Methods
		public static P3dMask Find(Vector3 position, LayerMask layers) => default; // 0x000000018930E0A0-0x000000018930E328
		protected virtual void OnEnable() {} // 0x000000018930E3A4-0x000000018930E420
		protected virtual void OnDisable() {} // 0x000000018930E328-0x000000018930E3A4
	}

	[AddComponentMenu("Paint in 3D/P3D Material Cloner")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterialCloner")]
	[RequireComponent(typeof(Renderer))]
	[RequireComponent(typeof(P3dPaintable))]
	public class P3dMaterialCloner : MonoBehaviour // TypeDefIndex: 56082
	{
		// Fields
		[SerializeField]
		private int index; // 0x18
		[NonSerialized]
		private Renderer cachedRenderer; // 0x20
		[NonSerialized]
		private bool cachedRendererSet; // 0x28
		[NonSerialized]
		private P3dPaintable cachedPaintable; // 0x30
		[NonSerialized]
		private bool cachedPaintableSet; // 0x38
		[SerializeField]
		private bool activated; // 0x39
		[SerializeField]
		private Material current; // 0x40
		[SerializeField]
		private Material original; // 0x48
	
		// Properties
		public int Index { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public Renderer CachedRenderer { get => default; } // 0x000000018930E984-0x000000018930E9DC 
		public P3dPaintable CachedPaintable { get => default; } // 0x000000018930E92C-0x000000018930E984 
		public Material Original { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public Material Current { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public bool Activated { get => default; } // 0x0000000183D4F300-0x0000000183D4F310 
	
		// Constructors
		public P3dMaterialCloner() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[ContextMenu("Activate")]
		public void Activate() {} // 0x000000018930E560-0x000000018930E674
		[ContextMenu("Deactivate")]
		public void Deactivate() {} // 0x000000018930E674-0x000000018930E6FC
		public void ReplaceAll(Material from, Material to) {} // 0x000000018930E6FC-0x000000018930E84C
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial) {} // 0x000000018930E84C-0x000000018930E92C
	}

	public static class P3dMeshCache // TypeDefIndex: 56084
	{
		// Fields
		private static Dictionary<Mesh, MeshData> cachedData; // 0x00
	
		// Nested types
		private class MeshData // TypeDefIndex: 56083
		{
			// Fields
			private Vector3[] positions; // 0x10
			private int[] indices; // 0x18
			private int total; // 0x20
	
			// Constructors
			public MeshData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Update(Mesh mesh) {} // 0x000000018930370C-0x000000018930377C
			public bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC) => default; // 0x0000000189303558-0x000000018930370C
		}
	
		// Constructors
		static P3dMeshCache() {} // 0x000000018930EBF4-0x000000018930EC80
	
		// Methods
		public static bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC) => default; // 0x000000018930E9DC-0x000000018930EBF4
	}

	[AddComponentMenu("Paint in 3D/P3D Model")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dModel")]
	[RequireComponent(typeof(Renderer))]
	public class P3dModel : MonoBehaviour // TypeDefIndex: 56086
	{
		// Fields
		[SerializeField]
		protected P3dPaintable paintable; // 0x18
		[SerializeField]
		protected bool includeScale; // 0x20
		[SerializeField]
		protected UseMeshType useMesh; // 0x24
		[SerializeField]
		protected P3dHash hash; // 0x28
		[NonSerialized]
		private Renderer cachedRenderer; // 0x30
		[NonSerialized]
		private bool cachedRendererSet; // 0x38
		[NonSerialized]
		private SkinnedMeshRenderer cachedSkinned; // 0x40
		[NonSerialized]
		private MeshFilter cachedFilter; // 0x48
		[NonSerialized]
		private bool cachedSkinnedSet; // 0x50
		[NonSerialized]
		private Transform cachedTransform; // 0x58
		[NonSerialized]
		private GameObject cachedGameObject; // 0x60
		[NonSerialized]
		private Material[] materials; // 0x68
		[NonSerialized]
		private bool materialsSet; // 0x70
		[NonSerialized]
		private Mesh bakedMesh; // 0x78
		[NonSerialized]
		private bool bakedMeshSet; // 0x80
		[NonSerialized]
		protected bool prepared; // 0x81
		[NonSerialized]
		private Mesh preparedMesh; // 0x88
		[NonSerialized]
		private Matrix4x4 preparedMatrix; // 0x90
		[NonSerialized]
		private int[] preparedTriangles; // 0xD0
		[NonSerialized]
		private Vector3[] preparedPositions; // 0xD8
		[NonSerialized]
		private Vector2[] preparedCoord0; // 0xE0
		[NonSerialized]
		private Vector2[] preparedCoord1; // 0xE8
		[NonSerialized]
		private static List<P3dModel> tempModels; // 0x00
		private static LinkedList<P3dModel> instances; // 0x08
		private LinkedListNode<P3dModel> instancesNode; // 0xF0
	
		// Properties
		public virtual P3dPaintable Paintable { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public virtual bool IncludeScale { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public UseMeshType UseMesh { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public P3dHash Hash { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x000000018931002C-0x0000000189310080
		public static LinkedList<P3dModel> Instances { get => default; } // 0x000000018930FF94-0x000000018930FFE4 
		public bool Prepared { get => default; set {} } // 0x0000000183D5A210-0x0000000183D5A220 0x0000000183D5A220-0x0000000183D5A230
		public Mesh PreparedMesh { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public GameObject CachedGameObject { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public Renderer CachedRenderer { get => default; } // 0x000000018930FF6C-0x000000018930FF94 
		public Material[] Materials { get => default; } // 0x000000018930FFE4-0x000000018931002C 
	
		// Nested types
		public enum UseMeshType // TypeDefIndex: 56085
		{
			AsIs = 0,
			AutoSeamFix = 1
		}
	
		// Constructors
		public P3dModel() {} // 0x0000000183A1E660-0x0000000183A1E670
		static P3dModel() {} // 0x000000018930FE8C-0x000000018930FF6C
	
		// Methods
		public int GetMaterialIndex(Material material) => default; // 0x000000018930F0F8-0x000000018930F248
		private void CacheRenderer() {} // 0x000000018930EC80-0x000000018930ED54
		[ContextMenu("Dirty Materials")]
		public void DirtyMaterials() {} // 0x0000000183D71970-0x0000000183D71980
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask) => default; // 0x000000018930ED54-0x000000018930F0F8
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC) {} // 0x000000018930F5D8-0x000000018930F7D0
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC) {} // 0x000000018930F248-0x000000018930F410
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC) {} // 0x000000018930F410-0x000000018930F5D8
		public int GetSubmesh(P3dPaintableTexture paintableTexture) => default; // 0x000000018930FBF8-0x000000018930FCA0
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix, P3dCoord coord) {} // 0x000000018930F7D0-0x000000018930FBF8
		protected virtual void OnEnable() {} // 0x000000018930FDAC-0x000000018930FE8C
		protected virtual void OnDisable() {} // 0x000000018930FD24-0x000000018930FDAC
		protected virtual void OnDestroy() {} // 0x000000018930FCA0-0x000000018930FD24
	}

	[Serializable]
	public abstract class P3dModifier // TypeDefIndex: 56087
	{
		// Fields
		[SerializeField]
		private bool preview; // 0x10
		[SerializeField]
		private bool unique; // 0x11
	
		// Properties
		public bool Preview { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool Unique { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
	
		// Constructors
		protected P3dModifier() {} // 0x0000000183D71890-0x0000000183D718A0
	
		// Methods
		public void ModifyAngle(ref float angle, float pressure) {} // 0x0000000189310B44-0x0000000189310BD0
		protected virtual void OnModifyAngle(ref float angle, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x0000000189310BD0-0x0000000189310C54
		protected virtual void OnModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyHardness(ref float hardness, float pressure) {} // 0x0000000189310C54-0x0000000189310CE0
		protected virtual void OnModifyHardness(ref float hardness, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyOpacity(ref float opacity, float pressure) {} // 0x0000000189310CE0-0x0000000189310D6C
		protected virtual void OnModifyOpacity(ref float opacity, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyRadius(ref float radius, float pressure) {} // 0x0000000189310DF8-0x0000000189310E84
		protected virtual void OnModifyRadius(ref float radius, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyScale(ref Vector3 scale, float pressure) {} // 0x0000000189310E84-0x0000000189310F10
		protected virtual void OnModifyScale(ref Vector3 scale, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyTexture(ref Texture texture, float pressure) {} // 0x0000000189310F10-0x0000000189310F94
		protected virtual void OnModifyTexture(ref Texture texture, float pressure) {} // 0x000000018350B670-0x000000018350B680
		public void ModifyPosition(ref Vector3 position, float pressure) {} // 0x0000000189310D6C-0x0000000189310DF8
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class P3dModifierList // TypeDefIndex: 56088
	{
		// Fields
		[SerializeReference]
		private List<P3dModifier> modifiers; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000189310A80-0x0000000189310AC0 
		public List<P3dModifier> Instances { get => default; } // 0x0000000189310AC0-0x0000000189310B44 
	
		// Constructors
		public P3dModifierList() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void ModifyAngle(ref float angle, bool preview, float pressure) {} // 0x0000000189310080-0x00000001893101C0
		public void ModifyColor(ref UnityEngine.Color color, bool preview, float pressure) {} // 0x00000001893101C0-0x0000000189310300
		public void ModifyHardness(ref float hardness, bool preview, float pressure) {} // 0x0000000189310300-0x0000000189310440
		public void ModifyOpacity(ref float opacity, bool preview, float pressure) {} // 0x0000000189310440-0x0000000189310580
		public void ModifyRadius(ref float radius, bool preview, float pressure) {} // 0x00000001893106C0-0x0000000189310800
		public void ModifyScale(ref Vector3 scale, bool preview, float pressure) {} // 0x0000000189310800-0x0000000189310940
		public void ModifyTexture(ref Texture texture, bool preview, float pressure) {} // 0x0000000189310940-0x0000000189310A80
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure) {} // 0x0000000189310580-0x00000001893106C0
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintable")]
	[RequireComponent(typeof(Renderer))]
	public class P3dPaintable : P3dModel // TypeDefIndex: 56090
	{
		// Fields
		[SerializeField]
		private ActivationType activation; // 0xF8
		[SerializeField]
		private Vector3 baseScale; // 0xFC
		[SerializeField]
		private List<Renderer> otherRenderers; // 0x108
		[SerializeField]
		private UnityEvent onActivating; // 0x110
		[SerializeField]
		private UnityEvent onActivated; // 0x118
		[SerializeField]
		private bool activated; // 0x120
		[NonSerialized]
		private HashSet<P3dPaintableTexture> paintableTextures; // 0x128
		[NonSerialized]
		private static List<P3dMaterialCloner> materialCloners; // 0x00
		[NonSerialized]
		private List<P3dPaintableTexture> tempPaintableTextures; // 0x130
	
		// Properties
		public override P3dPaintable Paintable { get => default; set {} } // 0x0000000189317C60-0x0000000189317C80 0x000000018350B670-0x000000018350B680
		public ActivationType Activation { get => default; set {} } // 0x0000000183D6C5F0-0x0000000183D6C600 0x0000000183D6C600-0x0000000183D6C610
		public Vector3 BaseScale { get => default; set {} } // 0x0000000183D58D80-0x0000000183D58DA0 0x0000000183D719A0-0x0000000183D719C0
		public List<Renderer> OtherRenderers { get => default; set {} } // 0x0000000183D56D30-0x0000000183D56D40 0x000000018589D950-0x000000018589D964
		public UnityEvent OnActivating { get => default; } // 0x0000000189317BE4-0x0000000189317C60 
		public UnityEvent OnActivated { get => default; } // 0x0000000189317B68-0x0000000189317BE4 
		public bool Activated { get => default; } // 0x0000000183D57B30-0x0000000183D57B40 
		public HashSet<P3dPaintableTexture> PaintableTextures { get => default; } // 0x0000000183D56F00-0x0000000183D56F10 
	
		// Nested types
		public enum ActivationType // TypeDefIndex: 56089
		{
			Awake = 0,
			OnEnable = 1,
			Start = 2,
			OnFirstUse = 3
		}
	
		// Constructors
		public P3dPaintable() {} // 0x0000000189317A6C-0x0000000189317B68
		static P3dPaintable() {} // 0x00000001893179E0-0x0000000189317A6C
	
		// Methods
		public void RemoveComponents() {} // 0x00000001893176F4-0x000000018931785C
		public void ScaleSize(ref int width, ref int height) {} // 0x000000018931785C-0x000000018931796C
		[ContextMenu("Activate")]
		public void Activate() {} // 0x0000000189316CC0-0x0000000189316F24
		private void AddPaintableTextures(Transform root) {} // 0x0000000189316F24-0x000000018931716C
		[ContextMenu("Deactivate")]
		public void Deactivate() {} // 0x0000000189317310-0x0000000189317638
		public void ClearAll(UnityEngine.Color color) {} // 0x0000000189317188-0x00000001893171A8
		public void ClearAll(Texture texture, UnityEngine.Color color) {} // 0x00000001893171A8-0x0000000189317310
		public void Register(P3dPaintableTexture paintableTexture) {} // 0x000000018931769C-0x00000001893176F4
		public void Unregister(P3dPaintableTexture paintableTexture) {} // 0x0000000189317988-0x00000001893179E0
		protected virtual void Awake() {} // 0x000000018931716C-0x0000000189317188
		protected override void OnEnable() {} // 0x0000000189317638-0x000000018931769C
		protected virtual void Start() {} // 0x000000018931796C-0x0000000189317988
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Manager")]
	[DefaultExecutionOrder(100)]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableManager")]
	public class P3dPaintableManager : MonoBehaviour // TypeDefIndex: 56091
	{
		// Fields
		private static LinkedList<P3dPaintableManager> instances; // 0x00
		private LinkedListNode<P3dPaintableManager> instancesNode; // 0x18
	
		// Properties
		public static LinkedList<P3dPaintableManager> Instances { get => default; } // 0x0000000189311C20-0x0000000189311C70 
	
		// Constructors
		public P3dPaintableManager() {} // 0x000000018426FE60-0x000000018426FE68
		static P3dPaintableManager() {} // 0x0000000189311BA4-0x0000000189311C20
	
		// Methods
		public static P3dPaintableManager GetOrCreateInstance() => default; // 0x000000018931124C-0x0000000189311398
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture) {} // 0x00000001893116CC-0x00000001893118D0
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture) {} // 0x00000001893110D0-0x000000018931124C
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group) {} // 0x00000001893115D0-0x00000001893116CC
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group) {} // 0x00000001893118D0-0x00000001893119B0
		public static P3dCommand Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture) => default; // 0x00000001893119B0-0x0000000189311A60
		protected virtual void OnEnable() {} // 0x0000000189311554-0x00000001893115D0
		protected virtual void OnDisable() {} // 0x00000001893114D8-0x0000000189311554
		protected virtual void LateUpdate() {} // 0x0000000189311398-0x00000001893114D8
		private void ClearAll() {} // 0x0000000189310F94-0x00000001893110D0
		private void UpdateAll() {} // 0x0000000189311A60-0x0000000189311BA4
	}

	public class P3dPaintableState // TypeDefIndex: 56092
	{
		// Fields
		public RenderTexture Texture; // 0x10
		public List<P3dCommand> Commands; // 0x18
		private static Stack<P3dPaintableState> pool; // 0x00
	
		// Constructors
		public P3dPaintableState() {} // 0x000000018931218C-0x0000000189312204
		static P3dPaintableState() {} // 0x0000000189312100-0x000000018931218C
	
		// Methods
		public static P3dPaintableState Pop() => default; // 0x0000000189311DE8-0x0000000189311E9C
		public void Write(RenderTexture current) {} // 0x0000000189311E9C-0x0000000189311F84
		public void Write(List<P3dCommand> commands) {} // 0x0000000189311F84-0x0000000189311FE4
		public void Write(RenderTexture current, List<P3dCommand> commands) {} // 0x0000000189311FE4-0x0000000189312100
		private void Clear() {} // 0x0000000189311C70-0x0000000189311D70
		public void Pool() {} // 0x0000000189311D70-0x0000000189311DE8
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Texture")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableTexture")]
	public class P3dPaintableTexture : MonoBehaviour // TypeDefIndex: 56102
	{
		// Fields
		[SerializeField]
		private P3dSlot slot; // 0x18
		[FormerlySerializedAs("channel")]
		[SerializeField]
		private P3dCoord coord; // 0x28
		[SerializeField]
		private P3dGroup group; // 0x2C
		[FormerlySerializedAs("state")]
		[SerializeField]
		private UndoRedoType undoRedo; // 0x30
		[SerializeField]
		private int stateLimit; // 0x34
		[SerializeField]
		private SaveLoadType saveLoad; // 0x38
		[SerializeField]
		private string saveName; // 0x40
		[SerializeField]
		private int width; // 0x48
		[SerializeField]
		private int height; // 0x4C
		[SerializeField]
		private Texture texture; // 0x50
		[SerializeField]
		private UnityEngine.Color color; // 0x58
		[SerializeField]
		private RenderTextureFormat format; // 0x68
		[SerializeField]
		private MipType mipMaps; // 0x6C
		[SerializeField]
		private FilterType filter; // 0x70
		[SerializeField]
		private AnisoType aniso; // 0x74
		[SerializeField]
		private WrapType wrapU; // 0x78
		[SerializeField]
		private WrapType wrapV; // 0x7C
		[SerializeField]
		private ExistingType existing; // 0x80
		[SerializeField]
		private ConversionType conversion; // 0x84
		[SerializeField]
		private Texture localMaskTexture; // 0x88
		[SerializeField]
		private P3dChannel localMaskChannel; // 0x90
		[SerializeField]
		private string shaderKeyword; // 0x98
		[SerializeField]
		protected P3dHash hash; // 0xA0
		[SerializeField]
		private bool isDummy; // 0xA4
		[SerializeField]
		private string output; // 0xA8
		public static Action<P3dPaintableTexture> OnInstanceAdded; // 0x08
		public static Action<P3dPaintableTexture> OnInstanceRemoved; // 0x10
		[SerializeField]
		private bool activated; // 0xC0
		[SerializeField]
		private RenderTexture current; // 0xC8
		[SerializeField]
		private RenderTexture preview; // 0xD0
		[NonSerialized]
		private List<P3dPaintableState> paintableStates; // 0xD8
		[NonSerialized]
		private int stateIndex; // 0xE0
		[NonSerialized]
		private P3dPaintable paintable; // 0xE8
		[NonSerialized]
		private bool paintableSet; // 0xF0
		[NonSerialized]
		private Material material; // 0xF8
		[NonSerialized]
		private bool materialSet; // 0x100
		[NonSerialized]
		private Texture oldTexture; // 0x108
		[NonSerialized]
		private List<P3dCommand> paintCommands; // 0x110
		[NonSerialized]
		private List<P3dCommand> previewCommands; // 0x118
		[NonSerialized]
		private List<P3dCommand> localCommands; // 0x120
		[NonSerialized]
		private static List<P3dPaintableTexture> tempPaintableTextures; // 0x18
		private static LinkedList<P3dPaintableTexture> instances; // 0x20
		private LinkedListNode<P3dPaintableTexture> instancesNode; // 0x128
		private static int _Buffer; // 0x28
		private static int _BufferSize; // 0x2C
	
		// Properties
		public P3dSlot Slot { get => default; set {} } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000189316CB0-0x0000000189316CC0
		public P3dCoord Coord { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public P3dGroup Group { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public UndoRedoType UndoRedo { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public int StateLimit { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public SaveLoadType SaveLoad { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public string SaveName { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public int Width { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public int Height { get => default; set {} } // 0x0000000183D4EDF0-0x0000000183D4EE00 0x0000000183D4EE30-0x0000000183D4EE40
		public Texture Texture { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D50820-0x0000000183D50830 0x0000000183D71980-0x0000000183D71990
		public RenderTextureFormat Format { get => default; set {} } // 0x0000000183D4EEE0-0x0000000183D4EEF0 0x0000000183D4EF30-0x0000000183D4EF40
		public MipType MipMaps { get => default; set {} } // 0x0000000183D4F400-0x0000000183D4F410 0x0000000183D4F450-0x0000000183D4F460
		public FilterType Filter { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public AnisoType Aniso { get => default; set {} } // 0x0000000183D4F0D0-0x0000000183D4F0E0 0x0000000183D4F100-0x0000000183D4F110
		public WrapType WrapU { get => default; set {} } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000183D4ECC0-0x0000000183D4ECD0
		public WrapType WrapV { get => default; set {} } // 0x0000000183D4EC90-0x0000000183D4ECA0 0x0000000183D4ED10-0x0000000183D4ED20
		public ExistingType Existing { get => default; set {} } // 0x0000000183D4EC20-0x0000000183D4EC30 0x0000000183D4ECA0-0x0000000183D4ECB0
		public ConversionType Conversion { get => default; set {} } // 0x0000000183D4F370-0x0000000183D4F380 0x0000000183D4F390-0x0000000183D4F3A0
		public Texture LocalMaskTexture { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public P3dChannel LocalMaskChannel { get => default; set {} } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
		public string ShaderKeyword { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public P3dHash Hash { get => default; set {} } // 0x0000000183D50E50-0x0000000183D50E60 0x0000000189316C5C-0x0000000189316CB0
		public bool IsDummy { get => default; set {} } // 0x0000000183D58450-0x0000000183D58460 0x0000000183D71990-0x0000000183D719A0
		public string Output { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public static LinkedList<P3dPaintableTexture> Instances { get => default; } // 0x0000000189316910-0x0000000189316960 
		public bool Activated { get => default; } // 0x0000000183D583F0-0x0000000183D58400 
		public bool CanUndo { get => default; } // 0x00000001893168A8-0x00000001893168BC 
		public bool CanRedo { get => default; } // 0x0000000189316850-0x00000001893168A8 
		public List<P3dPaintableState> States { get => default; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 
		public int StateIndex { get => default; } // 0x0000000183D50ED0-0x0000000183D50EE0 
		public Material Material { get => default; } // 0x0000000189316960-0x0000000189316990 
		public P3dPaintable Paintable { get => default; } // 0x0000000189316990-0x0000000189316A20 
		public RenderTexture Current { get => default; set {} } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x0000000189316C04-0x0000000189316C5C
		public RenderTexture Preview { get => default; } // 0x0000000183D50050-0x0000000183D50060 
		public bool CommandsPending { get => default; } // 0x00000001893168BC-0x0000000189316910 
	
		// Events
		public event Action<P3dCommand> OnAddCommand;
		public static event Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal;
		public event Action<bool> OnModified;
	
		// Nested types
		public enum UndoRedoType // TypeDefIndex: 56093
		{
			None = 0,
			FullTextureCopy = 1,
			LocalCommandCopy = 2
		}
	
		public enum SaveLoadType // TypeDefIndex: 56094
		{
			Manual = 0,
			Automatic = 1,
			SemiManual = 2
		}
	
		public enum MipType // TypeDefIndex: 56095
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum FilterType // TypeDefIndex: 56096
		{
			Auto = -1,
			Point = 0,
			Bilinear = 1,
			Trilinear = 2
		}
	
		public enum AnisoType // TypeDefIndex: 56097
		{
			Auto = -1,
			Off = 0,
			One = 1,
			Four = 4,
			Eight = 8,
			Sixteen = 16
		}
	
		public enum WrapType // TypeDefIndex: 56098
		{
			Auto = -1,
			Repeat = 0,
			Clamp = 1,
			Mirror = 2,
			MirrorOnce = 3
		}
	
		public enum ExistingType // TypeDefIndex: 56099
		{
			Ignore = 0,
			Use = 1,
			UseAndKeep = 2
		}
	
		public enum ConversionType // TypeDefIndex: 56100
		{
			None = 0,
			Normal = 1,
			Premultiply = 2
		}
	
		[Serializable]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture> // TypeDefIndex: 56101
		{
			// Constructors
			public PaintableTextureEvent() {} // 0x00000001893193C0-0x00000001893193FC
		}
	
		// Constructors
		public P3dPaintableTexture() {} // 0x00000001893164A4-0x000000018931666C
		static P3dPaintableTexture() {} // 0x0000000189316364-0x00000001893164A4
	
		// Methods
		public static List<P3dPaintableTexture> FilterAll(P3dModel model, P3dGroup group) => default; // 0x00000001893148B4-0x0000000189314B08
		[ContextMenu("Clear States")]
		public void ClearStates() {} // 0x0000000189313ACC-0x0000000189313B7C
		[ContextMenu("Store State")]
		public void StoreState() {} // 0x0000000189315F40-0x0000000189315FCC
		[ContextMenu("Undo")]
		public void Undo() {} // 0x000000018931619C-0x0000000189316294
		[ContextMenu("Redo")]
		public void Redo() {} // 0x0000000189315A1C-0x0000000189315AE4
		public void SetColor(string html) {} // 0x0000000189315E34-0x0000000189315E48
		public Vector2 GetCoord(ref P3dHit hit) => default; // 0x0000000189314B08-0x0000000189314B3C
		public Vector2 GetCoord(ref RaycastHit hit) => default; // 0x0000000189314B3C-0x0000000189314B68
		private bool StatesContainTextureOrCommands() => default; // 0x0000000189315E48-0x0000000189315F40
		private bool LastStateWithTextureOr0(ref int startIndex) => default; // 0x000000018931515C-0x0000000189315228
		private void RebuildFromCommands() {} // 0x0000000189315680-0x0000000189315A1C
		private void AddState() {} // 0x000000018931378C-0x00000001893138C8
		private void TrimFuture() {} // 0x0000000189315FCC-0x00000001893160EC
		private void TrimPast() {} // 0x00000001893160EC-0x000000018931619C
		public void NotifyOnModified(bool preview) {} // 0x00000001893153BC-0x00000001893153D8
		public Texture2D GetReadableCopy(bool convertBack = false /* Metadata: 0x01FD7CF4 */) => default; // 0x0000000189314C14-0x0000000189314EB0
		public byte[] GetPngData(bool convertBack = false /* Metadata: 0x01FD7CF5 */) => default; // 0x0000000189314B68-0x0000000189314C14
		public byte[] GetTgaData(bool convertBack = false /* Metadata: 0x01FD7CF6 */) => default; // 0x0000000189314EB0-0x0000000189314F5C
		[ContextMenu("Clear")]
		public void Clear() {} // 0x0000000189313B7C-0x0000000189313BA8
		public void Clear(Texture texture, UnityEngine.Color tint, bool updateMips = true /* Metadata: 0x01FD7CF7 */) {} // 0x0000000189313BA8-0x0000000189313CDC
		[ContextMenu("Replace")]
		public void Replace() {} // 0x0000000189315BB8-0x0000000189315BDC
		public void Replace(Texture texture, UnityEngine.Color tint) {} // 0x0000000189315AE4-0x0000000189315BB8
		public bool Resize(int width, int height, bool copyContents = true /* Metadata: 0x01FD7CF8 */) => default; // 0x0000000189315BDC-0x0000000189315DB0
		[ContextMenu("Save")]
		public void Save() {} // 0x0000000189315E28-0x0000000189315E34
		public void Save(string saveName) {} // 0x0000000189315DB0-0x0000000189315E28
		[ContextMenu("Load")]
		public void Load() {} // 0x00000001893153AC-0x00000001893153BC
		public void Load(string saveName, bool replace = true /* Metadata: 0x01FD7CF9 */) {} // 0x0000000189315344-0x00000001893153AC
		public void LoadFromData(byte[] data, bool allowResize = true /* Metadata: 0x01FD7CFA */) {} // 0x0000000189315228-0x0000000189315344
		public void HidePreview() {} // 0x00000001893150A8-0x000000018931515C
		public static void HideAllPreviews() {} // 0x0000000189314F5C-0x00000001893150A8
		[ContextMenu("Clear Save")]
		public void ClearSave() {} // 0x0000000189313A7C-0x0000000189313ACC
		public static void ClearSave(string saveName) {} // 0x0000000189313A30-0x0000000189313A7C
		[ContextMenu("Update Material")]
		public void UpdateMaterial() {} // 0x0000000189316294-0x0000000189316364
		[ContextMenu("Copy Size")]
		public void CopySize() {} // 0x0000000189313CDC-0x0000000189313D80
		[ContextMenu("Copy Texture")]
		public void CopyTexture() {} // 0x0000000189313D80-0x0000000189313DBC
		[ContextMenu("Activate")]
		public void Activate() {} // 0x0000000189313138-0x00000001893135FC
		[ContextMenu("Deactivate")]
		public void Deactivate() {} // 0x0000000189313DBC-0x0000000189313ED8
		protected virtual void OnEnable() {} // 0x0000000189315588-0x0000000189315680
		protected virtual void OnDisable() {} // 0x00000001893154C4-0x0000000189315588
		protected virtual void OnApplicationPause(bool paused) {} // 0x00000001893153D8-0x000000018931540C
		protected virtual void OnDestroy() {} // 0x000000018931540C-0x00000001893154C4
		public void AddCommand(P3dCommand command) {} // 0x00000001893135FC-0x000000018931378C
		public void ClearCommands() {} // 0x00000001893138C8-0x0000000189313A30
		public void ExecuteCommands(bool sendNotifications, bool doSort) {} // 0x0000000189313ED8-0x0000000189314280
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, RenderTexture main, ref RenderTexture swap) {} // 0x0000000189314280-0x00000001893148B4
	}

	public abstract class P3dPaintableTextureMonitor : MonoBehaviour // TypeDefIndex: 56103
	{
		// Fields
		[SerializeField]
		private P3dPaintableTexture paintableTexture; // 0x18
		[SerializeField]
		private float interval; // 0x20
		[SerializeField]
		private bool async; // 0x24
		[SerializeField]
		protected int downsampleSteps; // 0x28
		[SerializeField]
		protected P3dPaintableTexture registeredPaintableTexture; // 0x38
		[SerializeField]
		private float cooldown; // 0x40
		[SerializeField]
		private P3dReader currentReader; // 0x48
		[SerializeField]
		protected NativeArray<Color32> currentPixels; // 0x50
	
		// Properties
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x0000000181041090-0x00000001810410A0 0x0000000189313114-0x0000000189313138
		public float Interval { get; set; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public bool Async { get; set; } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
		public int DownsampleSteps { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public bool Registered { get; } // 0x0000000189313030-0x0000000189313080 
		public P3dReader CurrentReader { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
	
		// Events
		public event Action OnUpdated;
	
		// Constructors
		protected P3dPaintableTextureMonitor() {} // 0x0000000189312F88-0x0000000189312F9C
	
		// Methods
		public void MarkCurrentReaderAsDirty() {} // 0x0000000189312A6C-0x0000000189312A7C
		[ContextMenu("Register")]
		public void Register() {} // 0x0000000189312C14-0x0000000189312CEC
		[ContextMenu("Unregister")]
		public void Unregister() {} // 0x0000000189312CEC-0x0000000189312DB8
		protected void InvokeOnUpdated() {} // 0x0000000189312A58-0x0000000189312A6C
		protected virtual void OnEnable() {} // 0x0000000189312B78-0x0000000189312C14
		protected virtual void OnDisable() {} // 0x0000000189312ADC-0x0000000189312B78
		protected virtual void OnDestroy() {} // 0x0000000189312A7C-0x0000000189312ADC
		protected virtual void Update() {} // 0x0000000189312DB8-0x0000000189312F88
		private void HandleCompleteCurrent(NativeArray<Color32> pixels) {} // 0x0000000189312940-0x0000000189312A44
		private void HandleModified(bool preview) {} // 0x0000000189312A44-0x0000000189312A58
		protected abstract void HandleComplete(int boost);
	}

	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor // TypeDefIndex: 56104
	{
		// Fields
		[FormerlySerializedAs("mesh")]
		[SerializeField]
		private Mesh maskMesh; // 0x60
		[SerializeField]
		private int maskSubmesh; // 0x68
		[SerializeField]
		private Texture maskTexture; // 0x70
		[SerializeField]
		private P3dChannel maskChannel; // 0x78
		[SerializeField]
		protected int total; // 0x7C
		[SerializeField]
		private P3dReader maskReader; // 0x80
		[SerializeField]
		protected NativeArray<byte> maskPixels; // 0x88
	
		// Properties
		public Mesh MaskMesh { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public int MaskSubmesh { get; set; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 0x0000000183D4EF30-0x0000000183D4EF40
		public Texture MaskTexture { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public P3dChannel MaskChannel { get; set; } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000183D4ECC0-0x0000000183D4ECD0
		public int Total { get; } // 0x0000000183D4EC90-0x0000000183D4ECA0 
		public P3dReader MaskReader { get; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
	
		// Constructors
		protected P3dPaintableTextureMonitorMask() {} // 0x0000000189312924-0x0000000189312940
	
		// Methods
		public void MarkMaskReaderAsDirty() {} // 0x0000000189312410-0x0000000189312428
		private void HandleCompleteMask(NativeArray<Color32> pixels) {} // 0x0000000189312204-0x0000000189312410
		protected override void OnEnable() {} // 0x0000000189312544-0x00000001893125E8
		protected override void OnDisable() {} // 0x00000001893124A0-0x0000000189312544
		protected override void OnDestroy() {} // 0x0000000189312428-0x00000001893124A0
		protected override void Update() {} // 0x00000001893125E8-0x0000000189312924
	}

	[Serializable]
	public class P3dPointConnector // TypeDefIndex: 56106
	{
		// Fields
		[SerializeField]
		private float hitSpacing; // 0x10
		[SerializeField]
		private int hitLimit; // 0x14
		[SerializeField]
		protected bool connectHits; // 0x18
		[SerializeField]
		protected bool clipConnected; // 0x19
		[NonSerialized]
		private List<Link> links; // 0x20
		[NonSerialized]
		private static Stack<Link> linkPool; // 0x00
		[NonSerialized]
		protected P3dHitCache hitCache; // 0x28
	
		// Properties
		public float HitSpacing { get => default; set {} } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public int HitLimit { get => default; set {} } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public bool ConnectHits { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool ClipConnected { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public P3dHitCache HitCache { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		private class Link // TypeDefIndex: 56105
		{
			// Fields
			public object Owner; // 0x10
			public Vector3 Position; // 0x18
			public float Age; // 0x24
			public bool Preview; // 0x28
			public Vector3 LastPosition; // 0x2C
			public float LastPressure; // 0x38
			public int LastPriority; // 0x3C
			public Quaternion LastRotation; // 0x40
	
			// Constructors
			public Link() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public P3dPointConnector() {} // 0x000000018931887C-0x0000000189318930
		static P3dPointConnector() {} // 0x00000001893187F0-0x000000018931887C
	
		// Methods
		public void ClearHitCache() {} // 0x000000018930D50C-0x000000018930D52C
		public void ResetConnections() {} // 0x0000000189317D8C-0x0000000189317E74
		public void BreakHits(object owner) {} // 0x0000000189317C80-0x0000000189317D8C
		public void SubmitLastPoint(GameObject gameObject, bool preview, object owner) {} // 0x0000000189317E74-0x00000001893180B8
		public void SubmitPoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner) {} // 0x00000001893180B8-0x000000018931860C
		public void Update() {} // 0x00000001893186C0-0x00000001893187F0
		private bool TryGetLink(object owner, ref Link link) => default; // 0x000000018931860C-0x00000001893186C0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Read Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dReadColor")]
	public class P3dReadColor : MonoBehaviour, IHitCoord // TypeDefIndex: 56108
	{
		// Fields
		[SerializeField]
		private P3dGroup group; // 0x18
		[SerializeField]
		private bool preview; // 0x1C
		[SerializeField]
		private UnityEngine.Color color; // 0x20
		[SerializeField]
		private ColorEvent onColor; // 0x30
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public bool Preview { get => default; set {} } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000183D54E10-0x0000000183D54E20
		public ColorEvent OnColor { get => default; } // 0x0000000189318AF8-0x0000000189318B68 
	
		// Nested types
		[Serializable]
		public class ColorEvent : UnityEvent<UnityEngine.Color> // TypeDefIndex: 56107
		{
			// Constructors
			public ColorEvent() {} // 0x0000000189303490-0x00000001893034CC
		}
	
		// Constructors
		public P3dReadColor() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x0000000189318930-0x0000000189318AF8
	}

	[Serializable]
	public class P3dReader // TypeDefIndex: 56109
	{
		// Fields
		[SerializeField]
		private AsyncGPUReadbackRequest request; // 0x10
		[SerializeField]
		private bool dirty; // 0x20
		[SerializeField]
		private bool requested; // 0x21
		[SerializeField]
		private RenderTexture buffer; // 0x28
		[SerializeField]
		private Vector2Int originalSize; // 0x30
		[SerializeField]
		private Vector2Int downsampledSize; // 0x38
		[SerializeField]
		private int downsampleSteps; // 0x40
		[SerializeField]
		private int downsampleBoost; // 0x44
		[SerializeField]
		private Texture2D tempTexture; // 0x48
	
		// Properties
		public bool Dirty { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		public bool Requested { get => default; } // 0x0000000183D4F070-0x0000000183D4F080 
		public Vector2Int OriginalSize { get => default; } // 0x0000000181003830-0x0000000181003840 
		public int DownsampleSteps { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		public Vector2Int DownsampledSize { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public int DownsampleBoost { get => default; } // 0x0000000183D4EE80-0x0000000183D4EE90 
	
		// Events
		public event Action<NativeArray<Color32>> OnComplete;
	
		// Constructors
		public P3dReader() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void MarkAsDirty() {} // 0x0000000183D59690-0x0000000183D596A0
		public void UpdateRequest() {} // 0x00000001893191C8-0x00000001893192A8
		public static bool NeedsUpdating<T>(P3dReader reader, NativeArray<T> array, RenderTexture texture, int downsampleSteps)
			where T : struct => default;
		public void Request(RenderTexture texture, int downsample, bool async) {} // 0x0000000189318EF8-0x00000001893191C8
		public void Release() {} // 0x0000000189318E58-0x0000000189318EF8
		private void CompleteDirectly() {} // 0x0000000189318B68-0x0000000189318E58
	}

	public static class P3dSerialization // TypeDefIndex: 56110
	{
		// Fields
		public static Dictionary<int, Material> HashToMaterial; // 0x00
		public static Dictionary<Material, int> MaterialToHash; // 0x08
		public static Dictionary<P3dHash, P3dModel> HashToModel; // 0x10
		public static Dictionary<P3dModel, P3dHash> ModelToHash; // 0x18
		public static Dictionary<P3dHash, Texture> HashToTexture; // 0x20
		public static Dictionary<Texture, P3dHash> TextureToHash; // 0x28
		public static Dictionary<P3dHash, P3dPaintableTexture> HashToPaintableTexture; // 0x30
		public static Dictionary<P3dPaintableTexture, P3dHash> PaintableTextureToHash; // 0x38
	
		// Constructors
		static P3dSerialization() {} // 0x000000018931D078-0x000000018931D3E0
	
		// Methods
		public static void TryRegister(P3dPaintableTexture paintableTexture, P3dHash hash) {} // 0x000000018931CFFC-0x000000018931D078
		public static void TryRegister(P3dModel model, P3dHash hash) {} // 0x000000018931CC80-0x000000018931CD08
		public static void TryRegister(Texture texture, P3dHash hash) {} // 0x000000018931CF80-0x000000018931CFFC
		public static void TryRegister<T>(T obj, P3dHash hash, Dictionary<P3dHash, T> hashToObj, Dictionary<T, P3dHash> objToHash)
			where T : UnityEngine.Object {}
		public static int TryRegister(Material material) => default; // 0x000000018931CD08-0x000000018931CF80
		private static int GetStableStringHash(string s) => default; // 0x000000018931CC2C-0x000000018931CC80
	}

	[Serializable]
	public struct P3dSlot // TypeDefIndex: 56111
	{
		// Fields
		public int Index; // 0x00
		public string Name; // 0x08
	
		// Constructors
		public P3dSlot(int newIndex, string newName) {
			Index = default;
			Name = default;
		} // 0x00000001871AED58-0x00000001871AED68
	
		// Methods
		public Texture FindTexture(GameObject gameObject) => default; // 0x000000018931D440-0x000000018931D570
		public bool IsTransformed(GameObject gameObject) => default; // 0x000000018931D59C-0x000000018931D74C
		public override bool Equals(object obj) => default; // 0x000000018931D3E0-0x000000018931D440
		public override int GetHashCode() => default; // 0x000000018931D570-0x000000018931D59C
		public static bool operator ==(P3dSlot a, P3dSlot b) => default; // 0x000000018931D74C-0x000000018931D768
		public static bool operator !=(P3dSlot a, P3dSlot b) => default; // 0x000000018931D768-0x000000018931D784
	}

	public static class P3dStateManager // TypeDefIndex: 56112
	{
		// Properties
		public static bool CanUndo { get; } // 0x000000018931DDB8-0x000000018931DEFC 
		public static bool CanRedo { get; } // 0x000000018931DC74-0x000000018931DDB8 
	
		// Methods
		public static void StoreAllStates() {} // 0x000000018931D9FC-0x000000018931DB38
		public static void ClearAllStates() {} // 0x000000018931D784-0x000000018931D8C0
		public static void UndoAll() {} // 0x000000018931DB38-0x000000018931DC74
		public static void RedoAll() {} // 0x000000018931D8C0-0x000000018931D9FC
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Texture Hash")]
	[DefaultExecutionOrder(-200)]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTextureHash")]
	public class P3dTextureHash : MonoBehaviour // TypeDefIndex: 56113
	{
		// Fields
		[SerializeField]
		private Texture texture; // 0x18
		[SerializeField]
		private P3dHash hash; // 0x20
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public P3dHash Hash { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x000000018931DFA0-0x000000018931E0A8
	
		// Constructors
		public P3dTextureHash() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018931DF4C-0x000000018931DFA0
		protected virtual void OnDestroy() {} // 0x000000018931DEFC-0x000000018931DF4C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Decal")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDecal")]
	public class P3dPaintDecal : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 56114
	{
		// Fields
		[SerializeField]
		private LayerMask layers; // 0x18
		[SerializeField]
		private P3dModel targetModel; // 0x20
		[SerializeField]
		private P3dGroup group; // 0x28
		[SerializeField]
		private P3dPaintableTexture targetTexture; // 0x30
		[SerializeField]
		private P3dBlendMode blendMode; // 0x38
		[SerializeField]
		private Texture texture; // 0x70
		[SerializeField]
		private Texture shape; // 0x78
		[SerializeField]
		private P3dChannel shapeChannel; // 0x80
		[SerializeField]
		private UnityEngine.Color color; // 0x84
		[Range(0f, 1f)]
		[SerializeField]
		private float opacity; // 0x94
		[Range(-180f, 180f)]
		[SerializeField]
		private float angle; // 0x98
		[SerializeField]
		private Vector3 scale; // 0x9C
		[SerializeField]
		private float radius; // 0xA8
		[SerializeField]
		private float hardness; // 0xAC
		[Range(0f, 1f)]
		[SerializeField]
		private float wrapping; // 0xB0
		[Range(0f, 2f)]
		[SerializeField]
		private float normalFront; // 0xB4
		[Range(0f, 2f)]
		[SerializeField]
		private float normalBack; // 0xB8
		[Range(0.001f, 0.5f)]
		[SerializeField]
		private float normalFade; // 0xBC
		[SerializeField]
		private Texture tileTexture; // 0xC0
		[SerializeField]
		private Transform tileTransform; // 0xC8
		[FormerlySerializedAs("tileBlend")]
		[Range(0f, 1f)]
		[SerializeField]
		private float tileOpacity; // 0xD0
		[Range(1f, 200f)]
		[SerializeField]
		private float tileTransition; // 0xD4
		[SerializeField]
		private P3dModifierList modifiers; // 0xD8
	
		// Properties
		public LayerMask Layers { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public P3dModel TargetModel { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public P3dGroup Group { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public P3dPaintableTexture TargetTexture { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000183D71A20-0x0000000183D71A50 0x000000018931AC68-0x000000018931AC94
		public Texture Texture { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public Texture Shape { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public P3dChannel ShapeChannel { get => default; set {} } // 0x0000000183D4EC20-0x0000000183D4EC30 0x0000000183D4ECA0-0x0000000183D4ECB0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D71A50-0x0000000183D71A60 0x0000000183D71A60-0x0000000183D71A70
		public float Opacity { get => default; set {} } // 0x0000000183D58E90-0x0000000183D58EA0 0x0000000183D59120-0x0000000183D59130
		public float Angle { get => default; set {} } // 0x0000000183D57D90-0x0000000183D57DA0 0x0000000183D57DB0-0x0000000183D57DC0
		public Vector3 Scale { get => default; set {} } // 0x0000000183D5AF20-0x0000000183D5AF40 0x0000000183D68F60-0x0000000183D68F80
		public float Radius { get => default; set {} } // 0x0000000183D58510-0x0000000183D58520 0x0000000183D6DF40-0x0000000183D6DF50
		public float Hardness { get => default; set {} } // 0x0000000183D58380-0x0000000183D58390 0x0000000183D6DF50-0x0000000183D6DF60
		public float Wrapping { get => default; set {} } // 0x0000000183D57F10-0x0000000183D57F20 0x0000000183D57F90-0x0000000183D57FA0
		public float NormalFront { get => default; set {} } // 0x0000000183D57F30-0x0000000183D57F40 0x0000000183D57FB0-0x0000000183D57FC0
		public float NormalBack { get => default; set {} } // 0x0000000183D599C0-0x0000000183D599D0 0x0000000183D50850-0x0000000183D50860
		public float NormalFade { get => default; set {} } // 0x0000000183D582F0-0x0000000183D58300 0x0000000183D71A70-0x0000000183D71A80
		public Texture TileTexture { get => default; set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public Transform TileTransform { get => default; set {} } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
		public float TileOpacity { get => default; set {} } // 0x0000000183D57560-0x0000000183D57570 0x0000000183D57580-0x0000000183D57590
		public float TileTransition { get => default; set {} } // 0x0000000183D57550-0x0000000183D57560 0x0000000183D57570-0x0000000183D57580
		public P3dModifierList Modifiers { get => default; } // 0x000000018931AC00-0x000000018931AC68 
	
		// Constructors
		public P3dPaintDecal() {} // 0x000000018931AAD8-0x000000018931AC00
	
		// Methods
		[ContextMenu("Flip Horizontal")]
		public void FlipHorizontal() {} // 0x0000000183D719C0-0x0000000183D719E0
		[ContextMenu("Flip Vertical")]
		public void FlipVertical() {} // 0x0000000183D719E0-0x0000000183D71A00
		public void IncrementOpacity(float delta) {} // 0x000000018931AA64-0x000000018931AA88
		public void IncrementAngle(float degrees) {} // 0x000000018931AA24-0x000000018931AA64
		public void MultiplyScale(float multiplier) {} // 0x000000018931AA88-0x000000018931AAD8
		public void MultiplyHardness(float multiplier) {} // 0x0000000183D71A00-0x0000000183D71A20
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x000000018931A090-0x000000018931A2F8
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x0000000189319E28-0x000000018931A090
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018931A5F4-0x000000018931A894
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018931A2F8-0x000000018931A5F4
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x0000000189319AA8-0x0000000189319E28
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation) => default; // 0x00000001893195E8-0x0000000189319AA8
		private void HandleMaskCommon(Vector3 worldPosition) {} // 0x000000018931A894-0x000000018931AA24
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintFill")]
	public class P3dPaintFill : MonoBehaviour, IHitCoord // TypeDefIndex: 56115
	{
		// Fields
		[SerializeField]
		private P3dGroup group; // 0x18
		[SerializeField]
		private P3dBlendMode blendMode; // 0x20
		[SerializeField]
		private Texture texture; // 0x58
		[SerializeField]
		private UnityEngine.Color color; // 0x60
		[Range(0f, 1f)]
		[SerializeField]
		private float opacity; // 0x70
		[Range(0f, 1f)]
		[SerializeField]
		private float minimum; // 0x74
		[SerializeField]
		private P3dModifierList modifiers; // 0x78
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000183D59150-0x0000000183D59180 0x000000018931B0D4-0x000000018931B100
		public Texture Texture { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D5A130-0x0000000183D5A140 0x0000000183D6C120-0x0000000183D6C130
		public float Opacity { get => default; set {} } // 0x0000000183D56C00-0x0000000183D56C10 0x0000000183D5BD20-0x0000000183D5BD30
		public float Minimum { get => default; set {} } // 0x0000000183D56C30-0x0000000183D56C40 0x0000000183D58A80-0x0000000183D58A90
		public P3dModifierList Modifiers { get => default; } // 0x000000018931B078-0x000000018931B0D4 
	
		// Constructors
		public P3dPaintFill() {} // 0x000000018931AFBC-0x000000018931B078
	
		// Methods
		public void IncrementOpacity(float delta) {} // 0x000000018931AFA0-0x000000018931AFBC
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018931AC94-0x000000018931AFA0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplace")]
	public class P3dPaintReplace : MonoBehaviour, IHitCoord // TypeDefIndex: 56116
	{
		// Fields
		[SerializeField]
		private P3dGroup group; // 0x18
		[SerializeField]
		private Texture texture; // 0x20
		[SerializeField]
		private UnityEngine.Color color; // 0x28
		[SerializeField]
		private P3dModifierList modifiers; // 0x38
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public Texture Texture { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000183D59E30-0x0000000183D59E40
		public P3dModifierList Modifiers { get => default; } // 0x000000018931B634-0x000000018931B690 
	
		// Constructors
		public P3dPaintReplace() {} // 0x000000018931B60C-0x000000018931B634
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018931B36C-0x000000018931B60C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace Channels")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplaceChannels")]
	public class P3dPaintReplaceChannels : MonoBehaviour, IHitCoord // TypeDefIndex: 56117
	{
		// Fields
		[SerializeField]
		private P3dGroup group; // 0x18
		[SerializeField]
		private Texture textureR; // 0x20
		[SerializeField]
		private Texture textureG; // 0x28
		[SerializeField]
		private Texture textureB; // 0x30
		[SerializeField]
		private Texture textureA; // 0x38
		[SerializeField]
		private Vector4 channelR; // 0x40
		[SerializeField]
		private Vector4 channelG; // 0x50
		[SerializeField]
		private Vector4 channelB; // 0x60
		[SerializeField]
		private Vector4 channelA; // 0x70
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public Texture TextureR { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Texture TextureG { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public Texture TextureB { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public Texture TextureA { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public Vector4 ChannelR { get => default; set {} } // 0x0000000183D5A160-0x0000000183D5A170 0x0000000183D5D610-0x0000000183D5D620
		public Vector4 ChannelG { get => default; set {} } // 0x0000000183D55950-0x0000000183D55960 0x0000000183D5D610-0x0000000183D5D620
		public Vector4 ChannelB { get => default; set {} } // 0x0000000183D5A130-0x0000000183D5A140 0x0000000183D5D610-0x0000000183D5D620
		public Vector4 ChannelA { get => default; set {} } // 0x0000000183D5AAE0-0x0000000183D5AAF0 0x0000000183D5D610-0x0000000183D5D620
	
		// Constructors
		public P3dPaintReplaceChannels() {} // 0x000000018931B34C-0x000000018931B36C
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018931B100-0x000000018931B34C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Sphere")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintSphere")]
	public class P3dPaintSphere : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 56118
	{
		// Fields
		[SerializeField]
		private LayerMask layers; // 0x18
		[SerializeField]
		private P3dGroup group; // 0x1C
		[SerializeField]
		private P3dModel targetModel; // 0x20
		[SerializeField]
		private P3dPaintableTexture targetTexture; // 0x28
		[SerializeField]
		private P3dBlendMode blendMode; // 0x30
		[SerializeField]
		private UnityEngine.Color color; // 0x68
		[Range(0f, 1f)]
		[SerializeField]
		private float opacity; // 0x78
		[Range(-180f, 180f)]
		[SerializeField]
		private float angle; // 0x7C
		[SerializeField]
		private Vector3 scale; // 0x80
		[SerializeField]
		private float radius; // 0x8C
		[SerializeField]
		private float hardness; // 0x90
		[SerializeField]
		private Texture tileTexture; // 0x98
		[SerializeField]
		private Transform tileTransform; // 0xA0
		[FormerlySerializedAs("tileBlend")]
		[Range(0f, 1f)]
		[SerializeField]
		private float tileOpacity; // 0xA8
		[Range(1f, 200f)]
		[SerializeField]
		private float tileTransition; // 0xAC
		[SerializeField]
		private P3dModifierList modifiers; // 0xB0
	
		// Properties
		public LayerMask Layers { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public P3dGroup Group { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public P3dModel TargetModel { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public P3dPaintableTexture TargetTexture { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000183D71AA0-0x0000000183D71AD0 0x000000018931CC00-0x000000018931CC2C
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D5D750-0x0000000183D5D760 0x0000000183D71AD0-0x0000000183D71AE0
		public float Opacity { get => default; set {} } // 0x0000000183D56C20-0x0000000183D56C30 0x0000000183D58AA0-0x0000000183D58AB0
		public float Angle { get => default; set {} } // 0x0000000183D51B20-0x0000000183D51B30 0x0000000183D5BDD0-0x0000000183D5BDE0
		public Vector3 Scale { get => default; set {} } // 0x0000000183D5B5B0-0x0000000183D5B5D0 0x0000000183D5B5F0-0x0000000183D5B610
		public float Radius { get => default; set {} } // 0x0000000183D58550-0x0000000183D58560 0x0000000183D71AE0-0x0000000183D71AF0
		public float Hardness { get => default; set {} } // 0x0000000183D58560-0x0000000183D58570 0x0000000183D5C110-0x0000000183D5C120
		public Texture TileTexture { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public Transform TileTransform { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public float TileOpacity { get => default; set {} } // 0x0000000183D58510-0x0000000183D58520 0x0000000183D6DF40-0x0000000183D6DF50
		public float TileTransition { get => default; set {} } // 0x0000000183D58380-0x0000000183D58390 0x0000000183D6DF50-0x0000000183D6DF60
		public P3dModifierList Modifiers { get => default; } // 0x000000018931CB98-0x000000018931CC00 
	
		// Constructors
		public P3dPaintSphere() {} // 0x000000018931CA94-0x000000018931CB98
	
		// Methods
		public void IncrementOpacity(float delta) {} // 0x000000018931CA28-0x000000018931CA44
		public void IncrementAngle(float degrees) {} // 0x000000018931C9EC-0x000000018931CA28
		public void MultiplyRadius(float multiplier) {} // 0x0000000183D71A80-0x0000000183D71AA0
		public void MultiplyScale(float multiplier) {} // 0x000000018931CA44-0x000000018931CA94
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x000000018931C058-0x000000018931C2C0
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x000000018931BDF0-0x000000018931C058
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018931C5BC-0x000000018931C85C
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018931C2C0-0x000000018931C5BC
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018931BA70-0x000000018931BDF0
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation) => default; // 0x000000018931B690-0x000000018931BA70
		private void HandleMaskCommon(Vector3 worldPosition) {} // 0x000000018931C85C-0x000000018931C9EC
	}
}
