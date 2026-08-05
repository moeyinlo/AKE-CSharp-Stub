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

// Image 44: PaintIn3D.dll - Assembly: PaintIn3D, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59562-59725
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace PaintIn3D
{
	[AddComponentMenu("Paint in 3D/P3D Button Clear All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonClearAll")]
	public class P3dButtonClearAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 59563
	{
		// Fields
		[SerializeField]
		private bool clearStates; // 0x18
	
		// Properties
		public bool ClearStates { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Constructors
		public P3dButtonClearAll(); // 0x0000000185394740-0x000000018539475C
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018A8E4350-0x000000018A8E4358
		[ContextMenu("Clear All")]
		public void ClearAll(); // 0x000000018A8E41C4-0x000000018A8E4350
	}

	[AddComponentMenu("Paint in 3D/P3D Button Redo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonRedoAll")]
	public class P3dButtonRedoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 59564
	{
		// Constructors
		public P3dButtonRedoAll(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018A8E4358-0x000000018A8E4360
		[ContextMenu("Redo All")]
		public void RedoAll(); // 0x000000018A8E4358-0x000000018A8E4360
		protected virtual void Update(); // 0x000000018A8E4360-0x000000018A8E43FC
	}

	[AddComponentMenu("Paint in 3D/P3D Button Undo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonUndoAll")]
	public class P3dButtonUndoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 59565
	{
		// Constructors
		public P3dButtonUndoAll(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018A8E43FC-0x000000018A8E4404
		[ContextMenu("Undo All")]
		public void UndoAll(); // 0x000000018A8E43FC-0x000000018A8E4404
		protected virtual void Update(); // 0x000000018A8E4404-0x000000018A8E44A0
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterEvent")]
	public class P3dChangeCounterEvent : MonoBehaviour // TypeDefIndex: 59566
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
		public List<P3dChangeCounter> Counters { get; } // 0x000000018A8E4558-0x000000018A8E45DC 
		public Vector2 Range { get; set; } // 0x0000000184DA5EA0-0x0000000184DA5EC0 0x0000000184D86500-0x0000000184D86510
		public bool Inside { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public UnityEvent OnInside { get; } // 0x000000018A8E45DC-0x000000018A8E464C 
		public UnityEvent OnOutside { get; } // 0x000000018A8E464C-0x000000018A8E46BC 
		public float Ratio { get; } // 0x000000018A8E46BC-0x000000018A8E4724 
	
		// Constructors
		public P3dChangeCounterEvent(); // 0x000000018A8E4534-0x000000018A8E4558
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E4510-0x000000018A8E4534
		private void UpdateInside(float ratio); // 0x000000018A8E44A0-0x000000018A8E4510
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChangeCounterFill : MonoBehaviour // TypeDefIndex: 59567
	{
		// Fields
		[SerializeField]
		private List<P3dChangeCounter> counters; // 0x18
		[SerializeField]
		private bool inverse; // 0x20
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChangeCounter> Counters { get; } // 0x000000018A8E480C-0x000000018A8E4890 
		public bool Inverse { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
	
		// Constructors
		public P3dChangeCounterFill(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A8E4724-0x000000018A8E476C
		protected virtual void Update(); // 0x000000018A8E476C-0x000000018A8E480C
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterText")]
	public class P3dChangeCounterText : MonoBehaviour // TypeDefIndex: 59569
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
		public List<P3dChangeCounter> Counters { get; } // 0x000000018A8E4AB8-0x000000018A8E4B3C 
		public bool Inverse { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public int DecimalPlaces { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public string Format { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public StringEvent OnString { get; } // 0x000000018A8E4B3C-0x000000018A8E4BAC 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 59568
		{
			// Constructors
			public StringEvent(); // 0x000000018A8F6090-0x000000018A8F616C
		}
	
		// Constructors
		public P3dChangeCounterText(); // 0x000000018A8E4A5C-0x000000018A8E4AB8
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E4890-0x000000018A8E4A5C
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterEvent")]
	public class P3dChannelCounterEvent : MonoBehaviour // TypeDefIndex: 59571
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018A8E4C64-0x000000018A8E4CE8 
		public ChannelType Channel { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public Vector2 Range { get; set; } // 0x0000000184D88060-0x0000000184D88080 0x0000000184DA5EC0-0x0000000184DA5ED0
		public bool Inside { get; set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
		public UnityEvent OnInside { get; } // 0x000000018A8E4CE8-0x000000018A8E4D58 
		public UnityEvent OnOutside { get; } // 0x000000018A8E4D58-0x000000018A8E4DC8 
		public float Ratio { get; } // 0x000000018A8E4DC8-0x000000018A8E4E9C 
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 59570
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterEvent(); // 0x000000018A8E4C40-0x000000018A8E4C64
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E4C1C-0x000000018A8E4C40
		private void UpdateInside(float ratio); // 0x000000018A8E4BAC-0x000000018A8E4C1C
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChannelCounterFill : MonoBehaviour // TypeDefIndex: 59573
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018A8E4FF0-0x000000018A8E5074 
		public ChannelType Channel { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public bool Inverse { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 59572
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterFill(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A8E4E9C-0x000000018A8E4EE4
		protected virtual void Update(); // 0x000000018A8E4EE4-0x000000018A8E4FF0
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterText")]
	public class P3dChannelCounterText : MonoBehaviour // TypeDefIndex: 59576
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018A8E530C-0x000000018A8E5390 
		public ChannelType Channel { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public bool Inverse { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
		public int DecimalPlaces { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public string Format { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public StringEvent OnString { get; } // 0x000000018A8E5390-0x000000018A8E5400 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 59574
		{
			// Constructors
			public StringEvent(); // 0x000000018A8F6054-0x000000018A8F6090
		}
	
		public enum ChannelType // TypeDefIndex: 59575
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterText(); // 0x000000018A8E52B0-0x000000018A8E530C
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E5074-0x000000018A8E52B0
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterEvent")]
	public class P3dColorCounterEvent : MonoBehaviour // TypeDefIndex: 59577
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018A8E54B8-0x000000018A8E553C 
		public P3dColor Color { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Vector2 Range { get; set; } // 0x0000000184D9E6E0-0x0000000184D9E700 0x0000000184D86520-0x0000000184D86530
		public bool Inside { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public UnityEvent OnInside { get; } // 0x000000018A8E553C-0x000000018A8E55AC 
		public UnityEvent OnOutside { get; } // 0x000000018A8E55AC-0x000000018A8E561C 
		public float Ratio { get; } // 0x000000018A8E561C-0x000000018A8E5690 
	
		// Constructors
		public P3dColorCounterEvent(); // 0x000000018A8E5494-0x000000018A8E54B8
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E5470-0x000000018A8E5494
		private void UpdateInside(float ratio); // 0x000000018A8E5400-0x000000018A8E5470
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dColorCounterFill : MonoBehaviour // TypeDefIndex: 59578
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018A8E578C-0x000000018A8E5810 
		public P3dColor Color { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool Inverse { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
	
		// Constructors
		public P3dColorCounterFill(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A8E5690-0x000000018A8E56D8
		protected virtual void Update(); // 0x000000018A8E56D8-0x000000018A8E578C
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterText")]
	public class P3dColorCounterText : MonoBehaviour // TypeDefIndex: 59580
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018A8E5A3C-0x000000018A8E5AC0 
		public P3dColor Color { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool Inverse { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public int DecimalPlaces { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public string Format { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public StringEvent OnString { get; } // 0x000000018A8E5AC0-0x000000018A8E5B30 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 59579
		{
			// Constructors
			public StringEvent(); // 0x000000018A8F6018-0x000000018A8F6054
		}
	
		// Constructors
		public P3dColorCounterText(); // 0x000000018A8E59E0-0x000000018A8E5A3C
	
		// Methods
		protected virtual void Update(); // 0x000000018A8E5810-0x000000018A8E59E0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Debug")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDebug")]
	public class P3dPaintDebug : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad // TypeDefIndex: 59581
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private float duration; // 0x28
		[SerializeField]
		private float size; // 0x2C
	
		// Properties
		public UnityEngine.Color Color { get; set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
		public float Duration { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public float Size { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
	
		// Constructors
		public P3dPaintDebug(); // 0x000000018A8F2698-0x000000018A8F26DC
	
		// Methods
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018A8F2094-0x000000018A8F223C
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018A8F1F74-0x000000018A8F2094
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018A8F2474-0x000000018A8F2698
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018A8F223C-0x000000018A8F2474
		private UnityEngine.Color GetColor(bool preview, float pressure, UnityEngine.Color color); // 0x000000018A8F1F30-0x000000018A8F1F74
		private void DrawArrow(Vector3 position, Quaternion rotation, UnityEngine.Color tint); // 0x000000018A8F1A68-0x000000018A8F1F30
	}

	public class P3dCommandDecal : P3dCommand // TypeDefIndex: 59582
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
		public override bool RequireMesh { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		static P3dCommandDecal(); // 0x000000018A8E7098-0x000000018A8E7700
		public P3dCommandDecal(); // 0x000000018A8E7700-0x000000018A8E7740
	
		// Methods
		public override void Apply(Material material); // 0x000000018A8E5C50-0x000000018A8E63E8
		public override void Pool(); // 0x000000018A8E6454-0x000000018A8E64C4
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x000000018A8E6E68-0x000000018A8E7098
		public override P3dCommand SpawnCopy(); // 0x000000018A8E6AE4-0x000000018A8E6E68
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018A8E5BF4-0x000000018A8E5C50
		public void SetShape(Quaternion rotation, Vector3 size, float angle); // 0x000000018A8E695C-0x000000018A8E6AE4
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x0234D01B */); // 0x0000000184DA5F50-0x0000000184DA5F80
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x0234D01C */, bool clip = false /* Metadata: 0x0234D01D */); // 0x0000000184DA5F80-0x0000000184DA5FD0
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x0234D01E */); // 0x0000000184DA5ED0-0x0000000184DA5F50
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x0234D01F */, bool clip = false /* Metadata: 0x0234D020 */); // 0x0000000184DA5FD0-0x0000000184DA6050
		public void ClearMask(); // 0x000000018A8E63E8-0x000000018A8E6454
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch); // 0x000000018A8E64C4-0x000000018A8E65C0
		public void ApplyAspect(Texture texture); // 0x000000018A8E5B30-0x000000018A8E5BF4
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition); // 0x000000018A8E65C0-0x000000018A8E695C
	}

	public class P3dCommandFill : P3dCommand // TypeDefIndex: 59583
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
		public override bool RequireMesh { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		static P3dCommandFill(); // 0x000000018A8E7F70-0x000000018A8E81A8
		public P3dCommandFill(); // 0x000000018A8E81A8-0x000000018A8E81E8
	
		// Methods
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018A8E7B34-0x000000018A8E7C9C
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018A8E78E8-0x000000018A8E7B34
		public override void Apply(Material material); // 0x000000018A8E7740-0x000000018A8E78E8
		public override void Pool(); // 0x000000018A8E7C9C-0x000000018A8E7D0C
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x00000001841E1670-0x00000001841E1680
		public override P3dCommand SpawnCopy(); // 0x000000018A8E7E6C-0x000000018A8E7F70
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018A8E5BF4-0x000000018A8E5C50
		public Material SetMaterial(P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018A8E7D0C-0x000000018A8E7E6C
	}

	public class P3dCommandReplace : P3dCommand // TypeDefIndex: 59584
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
		public override bool RequireMesh { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		static P3dCommandReplace(); // 0x000000018A8E9160-0x000000018A8E92E8
		public P3dCommandReplace(); // 0x000000018A8E92E8-0x000000018A8E9328
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint); // 0x000000018A8E8E9C-0x000000018A8E8F8C
		public static void BlitFast(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint); // 0x000000018A8E8DC8-0x000000018A8E8E9C
		public override void Apply(Material material); // 0x000000018A8E8CBC-0x000000018A8E8DC8
		public override void Pool(); // 0x000000018A8E8F8C-0x000000018A8E8FFC
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x00000001841E1670-0x00000001841E1680
		public override P3dCommand SpawnCopy(); // 0x000000018A8E90C8-0x000000018A8E9160
		public Material SetMaterial(Texture texture, UnityEngine.Color color); // 0x000000018A8E8FFC-0x000000018A8E90C8
	}

	public class P3dCommandReplaceChannels : P3dCommand // TypeDefIndex: 59585
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
		public override bool RequireMesh { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		static P3dCommandReplaceChannels(); // 0x000000018A8E89EC-0x000000018A8E8C7C
		public P3dCommandReplaceChannels(); // 0x000000018A8E8C7C-0x000000018A8E8CBC
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA, Vector4 channels); // 0x000000018A8E854C-0x000000018A8E86CC
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA); // 0x000000018A8E83E8-0x000000018A8E854C
		public override void Apply(Material material); // 0x000000018A8E81E8-0x000000018A8E83E8
		public override void Pool(); // 0x000000018A8E86CC-0x000000018A8E873C
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x00000001841E1670-0x00000001841E1680
		public override P3dCommand SpawnCopy(); // 0x000000018A8E88CC-0x000000018A8E89EC
		public Material SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA); // 0x000000018A8E873C-0x000000018A8E88CC
	}

	public class P3dCommandSphere : P3dCommand // TypeDefIndex: 59586
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
		public override bool RequireMesh { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		static P3dCommandSphere(); // 0x000000018A8EA46C-0x000000018A8EA994
		public P3dCommandSphere(); // 0x000000018A8EA994-0x000000018A8EA9D4
	
		// Methods
		public override void Apply(Material material); // 0x000000018A8E93EC-0x000000018A8E99B8
		public override void Pool(); // 0x000000018A8E9A24-0x000000018A8E9A94
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x000000018A8EA2A4-0x000000018A8EA46C
		public override P3dCommand SpawnCopy(); // 0x000000018A8E9FDC-0x000000018A8EA2A4
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018A8E5BF4-0x000000018A8E5C50
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x0234D021 */); // 0x0000000184DA5F50-0x0000000184DA5F80
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x0234D022 */, bool clip = false /* Metadata: 0x0234D023 */); // 0x0000000184DA5F80-0x0000000184DA5FD0
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x0234D024 */); // 0x0000000184DA5ED0-0x0000000184DA5F50
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x0234D025 */, bool clip = false /* Metadata: 0x0234D026 */); // 0x0000000184DA5FD0-0x0000000184DA6050
		public void ClearMask(); // 0x000000018A8E99B8-0x000000018A8E9A24
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch); // 0x000000018A8E9A94-0x000000018A8E9B90
		public void ApplyAspect(Texture texture); // 0x000000018A8E9328-0x000000018A8E93EC
		public void SetShape(float radius); // 0x000000018A8E9F10-0x000000018A8E9FDC
		public void SetShape(Quaternion rotation, Vector3 size, float angle); // 0x000000018A8E9DD4-0x000000018A8E9F10
		public void SetMaterial(P3dBlendMode blendMode, float hardness, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition); // 0x000000018A8E9B90-0x000000018A8E9DD4
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Between")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitBetween")]
	public class P3dHitBetween : MonoBehaviour // TypeDefIndex: 59591
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
		public PhaseType PaintIn { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float Interval { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public Transform PointA { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Transform PointB { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public float Fraction { get; } // 0x0000000184D86E20-0x0000000184D86E30 
		public LayerMask Layers { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public OrientationType Orientation { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public Camera Camera { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public Transform CustomTransform { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public NormalType Normal { get; set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public float Offset { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		public bool Preview { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
		public int Priority { get; set; } // 0x0000000184D86560-0x0000000184D86570 0x0000000184D865C0-0x0000000184D865D0
		public float Pressure { get; set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
		public EmitType Draw { get; set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
		public Transform Point { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public LineRenderer Line { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public P3dPointConnector Connector { get; } // 0x000000018A8EB67C-0x000000018A8EB6EC 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 59587
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 59588
		{
			WorldUp = 0,
			CameraUp = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum NormalType // TypeDefIndex: 59589
		{
			HitNormal = 0,
			RayDirection = 1
		}
	
		public enum EmitType // TypeDefIndex: 59590
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		// Constructors
		public P3dHitBetween(); // 0x000000018A8EB648-0x000000018A8EB67C
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018A8EAC88-0x000000018A8EAC94
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8EAC48-0x000000018A8EAC6C
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018A8EAD7C-0x000000018A8EAD9C
		protected virtual void OnEnable(); // 0x000000018A8EAD58-0x000000018A8EAD7C
		protected virtual void OnDisable(); // 0x000000018A8EAC94-0x000000018A8EAD58
		protected virtual void Update(); // 0x000000018A8EB5F8-0x000000018A8EB648
		protected virtual void LateUpdate(); // 0x000000018A8EAC80-0x000000018A8EAC88
		protected virtual void FixedUpdate(); // 0x000000018A8EAC6C-0x000000018A8EAC80
		private void SubmitHit(bool preview); // 0x000000018A8EAD9C-0x000000018A8EB39C
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, out Vector3 finalPosition, out Quaternion finalRotation); // 0x000000018A8EA9D4-0x000000018A8EAC48
		private void UpdatePointAndLine(); // 0x000000018A8EB40C-0x000000018A8EB5F8
		private void UpdateHit(); // 0x000000018A8EB39C-0x000000018A8EB40C
	}

	public class P3dHitCache // TypeDefIndex: 59592
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
		public bool Cached { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	
		// Constructors
		public P3dHitCache(); // 0x000000018A8EC384-0x000000018A8EC528
		static P3dHitCache(); // 0x000000018A8EC2F8-0x000000018A8EC384
	
		// Methods
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation); // 0x000000018A8EBD70-0x000000018A8EBE94
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018A8EBC10-0x000000018A8EBD70
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation); // 0x000000018A8EC1A8-0x000000018A8EC2F8
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018A8EC020-0x000000018A8EC1A8
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018A8EBE94-0x000000018A8EC020
		public void InvokeCoord(GameObject gameObject, bool preview, int priority, float pressure, P3dHit hit, Quaternion rotation); // 0x000000018A8EBAE4-0x000000018A8EBC10
		public void Clear(); // 0x000000018A8EBA14-0x000000018A8EBAE4
		private void Cache(GameObject gameObject); // 0x000000018A8EB6EC-0x000000018A8EBA14
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Collisions")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitCollisions")]
	public class P3dHitCollisions : MonoBehaviour // TypeDefIndex: 59596
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
		public EmitType Emit { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float RaycastDistance { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public LayerMask Layers { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public bool OnlyUseFirstContact { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
		public float Delay { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public OrientationType Orientation { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public Camera Camera { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public bool Preview { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public float Threshold { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
		public PressureType PressureMode { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public float PressureMin { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public float PressureMax { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float PressureConstant { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public float PressureMultiplier { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public float Offset { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		public int Priority { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public GameObject Root { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x000000018A8ECCEC-0x000000018A8ECD1C
		public P3dHitCache HitCache { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 59593
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 59594
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum PressureType // TypeDefIndex: 59595
		{
			Constant = 0,
			ImpactSpeed = 1
		}
	
		// Constructors
		public P3dHitCollisions(); // 0x000000018A8ECC48-0x000000018A8ECCEC
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8ECAA4-0x000000018A8ECAC4
		protected virtual void OnCollisionEnter(UnityEngine.Collision collision); // 0x000000018A8ECAC4-0x000000018A8ECACC
		protected virtual void OnCollisionStay(UnityEngine.Collision collision); // 0x000000018A8ECAC4-0x000000018A8ECACC
		protected virtual void Update(); // 0x000000018A8ECC18-0x000000018A8ECC48
		private bool TryGetRaycastHit(ContactPoint contact, ref RaycastHit hit); // 0x000000018A8ECACC-0x000000018A8ECC18
		private void CheckCollision(UnityEngine.Collision collision); // 0x000000018A8EC528-0x000000018A8ECAA4
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Nearby")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitNearby")]
	public class P3dHitNearby : MonoBehaviour // TypeDefIndex: 59598
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
		public PhaseType PaintIn { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float Interval { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public bool Preview { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public int Priority { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public float Pressure { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public P3dPointConnector Connector { get; } // 0x000000018A8ECF94-0x000000018A8ED004 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 59597
		{
			ManuallyOnly = -1,
			Update = 0,
			FixedUpdate = 1
		}
	
		// Constructors
		public P3dHitNearby(); // 0x000000018A8ECF70-0x000000018A8ECF94
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018A8ECD54-0x000000018A8ECD60
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8ECD1C-0x000000018A8ECD40
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018A8ECD84-0x000000018A8ECDA4
		protected virtual void OnEnable(); // 0x000000018A8ECD60-0x000000018A8ECD84
		protected virtual void Update(); // 0x000000018A8ECF20-0x000000018A8ECF70
		protected virtual void FixedUpdate(); // 0x000000018A8ECD40-0x000000018A8ECD54
		private void SubmitHit(bool preview); // 0x000000018A8ECDA4-0x000000018A8ECEB0
		private void UpdateHit(); // 0x000000018A8ECEB0-0x000000018A8ECF20
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Particles")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitParticles")]
	[RequireComponent(typeof(ParticleSystem))]
	public class P3dHitParticles : MonoBehaviour // TypeDefIndex: 59603
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
		public EmitType Emit { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float RaycastDistance { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public LayerMask Layers { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public OrientationType Orientation { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public Camera Camera { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public NormalType Normal { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public float Offset { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
		public int Skip { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public bool Preview { get; set; } // 0x0000000184D86BD0-0x0000000184D86BE0 0x0000000184D86BE0-0x0000000184D86BF0
		public int Priority { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public PressureType PressureMode { get; set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public float PressureMin { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float PressureMax { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public float PressureConstant { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public float PressureMultiplier { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		public GameObject Root { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x000000018A8EDAB4-0x000000018A8EDAE4
		public P3dHitCache HitCache { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 59599
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 59600
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum NormalType // TypeDefIndex: 59601
		{
			ParticleVelocity = 0,
			CollisionNormal = 1
		}
	
		public enum PressureType // TypeDefIndex: 59602
		{
			Constant = 0,
			Distance = 1,
			Speed = 2
		}
	
		// Constructors
		public P3dHitParticles(); // 0x000000018A8EDA30-0x000000018A8EDAB4
		static P3dHitParticles(); // 0x000000018A8ED9A4-0x000000018A8EDA30
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8ECAA4-0x000000018A8ECAC4
		private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit); // 0x000000018A8ED7F0-0x000000018A8ED9A4
		protected virtual void OnParticleCollision(GameObject hitGameObject); // 0x000000018A8ED004-0x000000018A8ED7F0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreen")]
	public class P3dHitScreen : P3dHitScreenBase // TypeDefIndex: 59606
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
		public FrequencyType Frequency { get; set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
		public float Interval { get; set; } // 0x0000000184DA60B0-0x0000000184DA60C0 0x0000000184DA60C0-0x0000000184DA60D0
		public P3dPointConnector Connector { get; } // 0x000000018A8F05AC-0x000000018A8F061C 
	
		// Nested types
		protected class Link : CwInputManager.Link // TypeDefIndex: 59604
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
			public Link(); // 0x000000018A8E3594-0x000000018A8E360C
	
			// Methods
			public void Move(Vector2 screenNew); // 0x000000018A8E34D0-0x000000018A8E3508
			private bool TryMove(Vector2 screenNew); // 0x000000018A8E3508-0x000000018A8E3594
			public override void Clear(); // 0x000000018A8E346C-0x000000018A8E34D0
		}
	
		public enum FrequencyType // TypeDefIndex: 59605
		{
			PixelInterval = 0,
			ScaledPixelInterval = 1,
			TimeInterval = 2,
			OnceOnRelease = 3,
			OnceOnPress = 4,
			OnceEveryFrame = 5
		}
	
		// Constructors
		public P3dHitScreen(); // 0x000000018A8F0518-0x000000018A8F05AC
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8EFA3C-0x000000018A8EFA60
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018A8EAD7C-0x000000018A8EAD9C
		protected override void OnEnable(); // 0x000000018A8EFD50-0x000000018A8EFEA4
		protected virtual void Update(); // 0x000000018A8F04F8-0x000000018A8F0518
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x000000018A8EFB30-0x000000018A8EFD48
		protected override void HandleFingerUp(CwInputManager.Finger finger); // 0x000000018A8EFA60-0x000000018A8EFB30
		private void PaintSmooth(Link link, bool down, float pixelSpacing); // 0x000000018A8F0148-0x000000018A8F0424
		protected virtual void OnFingerUp(Link link); // 0x00000001841E1670-0x00000001841E1680
		private void PaintInterval(Link link, bool down); // 0x000000018A8EFF30-0x000000018A8F0020
		private void PaintRelease(Link link, bool up); // 0x000000018A8F00AC-0x000000018A8F0148
		private void PaintPress(Link link, bool down); // 0x000000018A8F0020-0x000000018A8F00AC
		private void PaintEvery(Link link, bool down); // 0x000000018A8EFEA4-0x000000018A8EFF30
		private void RecordAndPaintAt(Link link, Vector2 screenNew, Vector2 screenOld, bool preview, float pressure, object owner); // 0x000000018A8F0424-0x000000018A8F04F8
	}

	public abstract class P3dHitScreenBase : MonoBehaviour // TypeDefIndex: 59612
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
		public Camera Camera { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public LayerMask Layers { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public ButtonTypes RequiredButtons { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public KeyCode RequiredKey { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public LayerMask GuiLayers { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public EmitType Emit { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public RotationType RotateTo { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public DirectionType NormalDirection { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public RelativeType NormalRelativeTo { get; set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public Transform CustomTransform { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public float NormalOffset { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float MouseOffset { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public float TouchOffset { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public bool StoreStates { get; set; } // 0x0000000184D86C20-0x0000000184D86C30 0x0000000184D86C40-0x0000000184D86C50
		public bool ShowPreview { get; set; } // 0x0000000184D86C10-0x0000000184D86C20 0x0000000184D86C30-0x0000000184D86C40
		public int Priority { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public bool NeedsDrawAngle { get; } // 0x000000018A8EECC4-0x000000018A8EECD8 
	
		// Nested types
		public enum RotationType // TypeDefIndex: 59607
		{
			Normal = 0,
			World = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum RelativeType // TypeDefIndex: 59608
		{
			WorldUp = 0,
			CameraUp = 1,
			DrawAngle = 2
		}
	
		public enum DirectionType // TypeDefIndex: 59609
		{
			HitNormal = 0,
			RayDirection = 1,
			CameraDirection = 2
		}
	
		public enum EmitType // TypeDefIndex: 59610
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		[Flags]
		public enum ButtonTypes // TypeDefIndex: 59611
		{
			LeftMouse = 1,
			RightMouse = 2,
			MiddleMouse = 4,
			Touch = 32
		}
	
		// Constructors
		protected P3dHitScreenBase(); // 0x000000018A8EEC1C-0x000000018A8EECC4
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A8EE51C-0x000000018A8EE6DC
		protected virtual void LateUpdate(); // 0x000000018A8EE254-0x000000018A8EE468
		protected virtual void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void HandleFingerUp(CwInputManager.Finger finger); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDisable(); // 0x000000018A8EE468-0x000000018A8EE51C
		private bool FingerWentDown(CwInputManager.Finger finger); // 0x000000018A8EE0A8-0x000000018A8EE184
		private void HandleFingerDown(CwInputManager.Finger finger); // 0x000000018A8EE184-0x000000018A8EE254
		protected virtual void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D); // 0x000000018A8EDF30-0x000000018A8EE0A8
		protected void PaintAt(P3dPointConnector connector, P3dHitCache hitCache, Vector2 screenPosition, Vector2 screenPositionOld, bool preview, float pressure, object owner); // 0x000000018A8EE6DC-0x000000018A8EEC1C
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, Camera camera, Vector2 screenPositionOld, ref Vector3 finalPosition, ref Quaternion finalRotation); // 0x000000018A8EDAE4-0x000000018A8EDF30
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenFill")]
	public class P3dHitScreenFill : P3dHitScreen // TypeDefIndex: 59613
	{
		// Fields
		[SerializeField]
		private float fillSpacing; // 0x88
	
		// Properties
		public float FillSpacing { get; set; } // 0x0000000184D8E220-0x0000000184D8E230 0x0000000184D8E250-0x0000000184D8E260
	
		// Constructors
		public P3dHitScreenFill(); // 0x000000018A8EF394-0x000000018A8EF3A8
	
		// Methods
		protected override void OnFingerUp(Link link); // 0x000000018A8EF0C0-0x000000018A8EF394
		private static Rect GetArea(List<Vector2> points); // 0x000000018A8EEE7C-0x000000018A8EF0C0
		private static double LineSide(Vector2 a, Vector2 b, Vector2 p); // 0x0000000184DA6050-0x0000000184DA60B0
		private static bool Contains(List<Vector2> points, Vector2 xy); // 0x000000018A8EECD8-0x000000018A8EEE7C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Line")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenLine")]
	public class P3dHitScreenLine : P3dHitScreenBase // TypeDefIndex: 59615
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
		public FrequencyType Frequency { get; set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
		public float Interval { get; set; } // 0x0000000184DA60B0-0x0000000184DA60C0 0x0000000184DA60C0-0x0000000184DA60D0
		public float Position { get; set; } // 0x0000000184D8ED60-0x0000000184D8ED70 0x0000000184D8ED70-0x0000000184D8ED80
		public float PixelOffset { get; set; } // 0x0000000184D88E80-0x0000000184D88E90 0x0000000184D8ED80-0x0000000184D8ED90
		public P3dPointConnector Connector { get; } // 0x000000018A8EF9C0-0x000000018A8EFA3C 
	
		// Nested types
		public enum FrequencyType // TypeDefIndex: 59614
		{
			StartAndEnd = 0,
			PixelInterval = 1,
			ScaledPixelInterval = 2,
			StretchedPixelInterval = 3,
			StretchedScaledPixelInterval = 4,
			Once = 5
		}
	
		// Constructors
		public P3dHitScreenLine(); // 0x000000018A8EF9A8-0x000000018A8EF9C0
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8EF3A8-0x000000018A8EF3CC
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018A8EF960-0x000000018A8EF984
		protected override void OnEnable(); // 0x000000018A8EF544-0x000000018A8EF578
		protected virtual void Update(); // 0x000000018A8EF984-0x000000018A8EF9A8
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x000000018A8EF3CC-0x000000018A8EF544
		private void PaintStartEnd(CwInputManager.Finger finger, bool up); // 0x000000018A8EF6BC-0x000000018A8EF7E4
		private void PaintStartInterval(CwInputManager.Finger finger, bool up, float pixelSpacing, bool stretch); // 0x000000018A8EF7E4-0x000000018A8EF960
		private void PaintOne(CwInputManager.Finger finger, bool up, float frac, float pixelOff); // 0x000000018A8EF578-0x000000018A8EF6BC
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Through")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitThrough")]
	public class P3dHitThrough : MonoBehaviour // TypeDefIndex: 59618
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
		public PhaseType PaintIn { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float Interval { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public Transform PointA { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Transform PointB { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public OrientationType Orientation { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public Camera Camera { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public float Pressure { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public bool Preview { get; set; } // 0x0000000184D86A30-0x0000000184D86A40 0x0000000184D86A40-0x0000000184D86A50
		public int Priority { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public LineRenderer Line { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public P3dLineConnector Connector { get; } // 0x000000018A8F0C0C-0x000000018A8F0C7C 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 59616
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 59617
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		// Constructors
		public P3dHitThrough(); // 0x000000018A8F0BE8-0x000000018A8F0C0C
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018A8F065C-0x000000018A8F0668
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018A8F061C-0x000000018A8F0640
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018A8F068C-0x000000018A8F06AC
		protected virtual void OnEnable(); // 0x000000018A8F0668-0x000000018A8F068C
		protected virtual void Update(); // 0x000000018A8F0B98-0x000000018A8F0BE8
		protected virtual void LateUpdate(); // 0x000000018A8F0654-0x000000018A8F065C
		protected virtual void FixedUpdate(); // 0x000000018A8F0640-0x000000018A8F0654
		private void SubmitHit(bool preview); // 0x000000018A8F06AC-0x000000018A8F09CC
		private void UpdateHit(); // 0x000000018A8F09CC-0x000000018A8F0A34
		private void UpdatePointAndLine(); // 0x000000018A8F0A34-0x000000018A8F0B98
	}

	public interface IClone // TypeDefIndex: 59619
	{
		// Methods
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}

	public interface IHit // TypeDefIndex: 59620
	{
	}

	public interface IHitCoord : IHit // TypeDefIndex: 59621
	{
		// Methods
		void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation);
	}

	public interface IHitLine : IHit // TypeDefIndex: 59622
	{
		// Methods
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip);
	}

	public interface IHitPoint : IHit // TypeDefIndex: 59623
	{
		// Methods
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}

	public interface IHitQuad : IHit // TypeDefIndex: 59624
	{
		// Methods
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip);
	}

	public interface IHitTriangle : IHit // TypeDefIndex: 59625
	{
		// Methods
		void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation);
	}

	public interface IBrowsable // TypeDefIndex: 59626
	{
		// Methods
		string GetCategory();
		string GetTitle();
		Texture2D GetIcon();
		UnityEngine.Object GetObject();
	}

	[AddComponentMenu("")]
	public class P3dHitScreen_InEditor : P3dHitScreen // TypeDefIndex: 59627
	{
		// Constructors
		public P3dHitScreen_InEditor(); // 0x000000018A8EFD48-0x000000018A8EFD50
	
		// Methods
		protected override void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D); // 0x00000001841E1670-0x00000001841E1680
		protected override void LateUpdate(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("Paint in 3D/P3D Material")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterial")]
	public class P3dMaterial : MonoBehaviour, IBrowsable // TypeDefIndex: 59628
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
		public string Category { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Texture2D Icon { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public List<Texture> Textures { get; } // 0x000000018A8F0D7C-0x000000018A8F0E00 
		public static List<P3dMaterial> CachedMaterials { get; } // 0x000000018A8F0CC8-0x000000018A8F0D7C 
	
		// Constructors
		public P3dMaterial(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void ClearCache(); // 0x000000018A8F0C7C-0x000000018A8F0CC8
		public string GetCategory(); // 0x000000018385B100-0x000000018385B110
		public string GetTitle(); // 0x0000000185396F58-0x0000000185396F60
		public Texture2D GetIcon(); // 0x0000000184D862C0-0x0000000184D862D0
		public UnityEngine.Object GetObject(); // 0x000000018464E630-0x000000018464E640
	}

	[AddComponentMenu("")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPreset")]
	public class P3dPreset : MonoBehaviour // TypeDefIndex: 59629
	{
		// Fields
		[SerializeField]
		private string title; // 0x18
		[SerializeField]
		private bool addMaterialCloner; // 0x20
		private static List<P3dPreset> cachedPresets; // 0x00
	
		// Properties
		public string Title { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool AddMaterialCloner { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
	
		// Constructors
		public P3dPreset(); // 0x0000000184D84C40-0x0000000184D84C60
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dSeamFixer")]
	public class P3dSeamFixer : ScriptableObject // TypeDefIndex: 59635
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
		public List<Pair> Meshes { get; } // 0x000000018A8F5C24-0x000000018A8F5CA8 
		public P3dCoord Coord { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public float Threshold { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
		public float Border { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000184D88370-0x0000000184D88380
	
		// Nested types
		[Serializable]
		public class Pair // TypeDefIndex: 59630
		{
			// Fields
			public Mesh Source; // 0x10
			public Mesh Output; // 0x18
	
			// Constructors
			public Pair(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class Ring // TypeDefIndex: 59631
		{
			// Fields
			public List<Point> Points; // 0x10
	
			// Constructors
			public Ring(); // 0x000000018A8F5FA0-0x000000018A8F6018
	
			// Methods
			public Point GetPoint(int index); // 0x000000018A8F5F20-0x000000018A8F5FA0
		}
	
		private class Edge // TypeDefIndex: 59632
		{
			// Fields
			public bool Used; // 0x10
			public Point PointA; // 0x18
			public Point PointB; // 0x20
			public bool Flip; // 0x28
	
			// Constructors
			public Edge(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool Match(Point a, Point b); // 0x000000018A8E344C-0x000000018A8E346C
		}
	
		private class Point // TypeDefIndex: 59633
		{
			// Fields
			public int Index; // 0x10
			public Vector2 Coord; // 0x14
			public Insertion Outer; // 0x20
			public List<Edge> Edges; // 0x28
	
			// Constructors
			public Point(); // 0x000000018A8F5EA8-0x000000018A8F5F20
		}
	
		private class Insertion // TypeDefIndex: 59634
		{
			// Fields
			public int Index; // 0x10
			public int NewIndex; // 0x14
			public Vector2 NewCoord; // 0x18
	
			// Constructors
			public Insertion(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public P3dSeamFixer(); // 0x000000018A8F5C0C-0x000000018A8F5C24
		static P3dSeamFixer(); // 0x000000018A8F5A90-0x000000018A8F5C0C
	
		// Methods
		public static Mesh GetCachedMesh(Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x0234D06B */); // 0x000000018A8F5524-0x000000018A8F5628
		private static Mesh TryGetCachedMesh(Dictionary<Mesh, Mesh> cache, Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x0234D06C */); // 0x000000018A8F58F4-0x000000018A8F5A90
		public void AddMesh(Mesh mesh); // 0x000000018A8F27C8-0x000000018A8F2880
		public void ConvertLegacy(); // 0x000000018A8F2BE4-0x000000018A8F2CD0
		[ContextMenu("Generate")]
		public void Generate(); // 0x000000018A8F51E4-0x000000018A8F5524
		public static void Generate(Mesh source, Mesh output, P3dCoord coord, float threshold, float border); // 0x000000018A8F440C-0x000000018A8F51E4
		private static void AddCoord(List<Vector4> coords, Insertion insertion, bool write); // 0x000000018A8F26DC-0x000000018A8F27C8
		private static void FixSeams(Mesh source, Mesh output, List<List<int>> submeshes, List<Ring> rings, List<Insertion> insertions, P3dCoord coord); // 0x000000018A8F2CD0-0x000000018A8F440C
		private static void TraceEdges(Ring ring, Point point); // 0x000000018A8F57D4-0x000000018A8F58F4
		private static void AddPoint(Dictionary<Vector2, Point> points, Vector2 coord, int index); // 0x000000018A8F2880-0x000000018A8F2980
		private static void AddTriangle(List<Edge> edges, Point pointA, Point pointB, Point pointC); // 0x000000018A8F2A2C-0x000000018A8F2BE4
		private static void AddTriangle2(List<Edge> edges, Point pointA, Point pointB, Point pointC, bool flip); // 0x000000018A8F2980-0x000000018A8F2A2C
		private static void RemoveOrAddEdge(List<Edge> edges, Point pointA, Point pointB, bool flip); // 0x000000018A8F5628-0x000000018A8F57D4
	}

	[AddComponentMenu("Paint in 3D/P3D Shape")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dShape")]
	public class P3dShape : MonoBehaviour, IBrowsable // TypeDefIndex: 59636
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dShape> cachedShapes; // 0x00
	
		// Properties
		public string Category { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Texture2D Icon { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public static List<P3dShape> CachedShapes { get; } // 0x000000018A8F5CF4-0x000000018A8F5DA8 
	
		// Constructors
		public P3dShape(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void ClearCache(); // 0x000000018A8F5CA8-0x000000018A8F5CF4
		public string GetCategory(); // 0x000000018385B100-0x000000018385B110
		public string GetTitle(); // 0x0000000185396F58-0x0000000185396F60
		public Texture2D GetIcon(); // 0x0000000184D862C0-0x0000000184D862D0
		public UnityEngine.Object GetObject(); // 0x000000018464E630-0x000000018464E640
	}

	[AddComponentMenu("Paint in 3D/P3D Tool")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTool")]
	public class P3dTool : MonoBehaviour, IBrowsable // TypeDefIndex: 59637
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dTool> cachedTools; // 0x00
	
		// Properties
		public string Category { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Texture2D Icon { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public static List<P3dTool> CachedTools { get; } // 0x000000018A8F5DF4-0x000000018A8F5EA8 
	
		// Constructors
		public P3dTool(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void ClearCache(); // 0x000000018A8F5DA8-0x000000018A8F5DF4
		public string GetCategory(); // 0x000000018385B100-0x000000018385B110
		public string GetTitle(); // 0x0000000185396F58-0x0000000185396F60
		public Texture2D GetIcon(); // 0x0000000184D862C0-0x0000000184D862D0
		public UnityEngine.Object GetObject(); // 0x000000018464E630-0x000000018464E640
	}

	[Serializable]
	public class P3dModifyAngleRandom : P3dModifier // TypeDefIndex: 59639
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
		public float Min { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float Max { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public BlendType Blend { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59638
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyAngleRandom(); // 0x0000000184DA60D0-0x0000000184DA60F0
		static P3dModifyAngleRandom(); // 0x000000018A8F0E4C-0x000000018A8F0EE4
	
		// Methods
		protected override void OnModifyAngle(ref float angle, float pressure); // 0x000000018A8F0E00-0x000000018A8F0E4C
	}

	[Serializable]
	public class P3dModifyColorRandom : P3dModifier // TypeDefIndex: 59641
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private Gradient gradient; // 0x18
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public Gradient Gradient { get; } // 0x000000018A8F1038-0x000000018A8F10AC 
		public BlendType Blend { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59640
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyColorRandom(); // 0x0000000184DA60F0-0x0000000184DA6100
		static P3dModifyColorRandom(); // 0x000000018A8F0FA0-0x000000018A8F1038
	
		// Methods
		protected override void OnModifyColor(ref UnityEngine.Color color, float pressure); // 0x000000018A8F0EE4-0x000000018A8F0FA0
	}

	public class P3dModifyHardnessPressure : P3dModifier // TypeDefIndex: 59643
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float hardness; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Hardness { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public BlendType Blend { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59642
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessPressure(); // 0x0000000184DA6100-0x0000000184DA6110
		static P3dModifyHardnessPressure(); // 0x000000018A8F10F0-0x000000018A8F1188
	
		// Methods
		protected override void OnModifyHardness(ref float currentHardness, float pressure); // 0x000000018A8F10AC-0x000000018A8F10F0
	}

	[Serializable]
	public class P3dModifyHardnessRandom : P3dModifier // TypeDefIndex: 59645
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
		public float Min { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float Max { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public BlendType Blend { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59644
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessRandom(); // 0x0000000184DA6110-0x0000000184DA6130
		static P3dModifyHardnessRandom(); // 0x000000018A8F1188-0x000000018A8F1220
	
		// Methods
		protected override void OnModifyHardness(ref float hardness, float pressure); // 0x000000018A8F0E00-0x000000018A8F0E4C
	}

	[Serializable]
	public class P3dModifyOpacityPressure : P3dModifier // TypeDefIndex: 59647
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float opacity; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Opacity { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public BlendType Blend { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59646
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityPressure(); // 0x0000000184DA6100-0x0000000184DA6110
		static P3dModifyOpacityPressure(); // 0x000000018A8F1220-0x000000018A8F12B8
	
		// Methods
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure); // 0x000000018A8F10AC-0x000000018A8F10F0
	}

	[Serializable]
	public class P3dModifyOpacityRandom : P3dModifier // TypeDefIndex: 59649
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
		public float Min { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float Max { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public BlendType Blend { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59648
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityRandom(); // 0x0000000184DA6110-0x0000000184DA6130
		static P3dModifyOpacityRandom(); // 0x000000018A8F12B8-0x000000018A8F1350
	
		// Methods
		protected override void OnModifyOpacity(ref float opacity, float pressure); // 0x000000018A8F0E00-0x000000018A8F0E4C
	}

	[Serializable]
	public class P3dModifyPositionRandom : P3dModifier // TypeDefIndex: 59650
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
	
		// Properties
		public float Radius { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
	
		// Constructors
		public P3dModifyPositionRandom(); // 0x0000000184DA6100-0x0000000184DA6110
		static P3dModifyPositionRandom(); // 0x000000018A8F13F8-0x000000018A8F1490
	
		// Methods
		protected override void OnModifyPosition(ref Vector3 position, float pressure); // 0x000000018A8F1350-0x000000018A8F13F8
	}

	[Serializable]
	public class P3dModifyRadiusPressure : P3dModifier // TypeDefIndex: 59652
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Radius { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public BlendType Blend { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59651
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusPressure(); // 0x0000000184DA6100-0x0000000184DA6110
		static P3dModifyRadiusPressure(); // 0x000000018A8F1490-0x000000018A8F1528
	
		// Methods
		protected override void OnModifyRadius(ref float currentRadius, float pressure); // 0x000000018A8F10AC-0x000000018A8F10F0
	}

	[Serializable]
	public class P3dModifyRadiusRandom : P3dModifier // TypeDefIndex: 59654
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
		public float Min { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float Max { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public BlendType Blend { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59653
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusRandom(); // 0x0000000184DA6110-0x0000000184DA6130
		static P3dModifyRadiusRandom(); // 0x000000018A8F1528-0x000000018A8F15C0
	
		// Methods
		protected override void OnModifyRadius(ref float radius, float pressure); // 0x000000018A8F0E00-0x000000018A8F0E4C
	}

	[Serializable]
	public class P3dModifyScaleRandom : P3dModifier // TypeDefIndex: 59656
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
		public Vector3 Min { get; set; } // 0x0000000184D89870-0x0000000184D89890 0x0000000184D89890-0x0000000184D898A0
		public Vector3 Max { get; set; } // 0x0000000184D905E0-0x0000000184D90600 0x0000000184D905D0-0x0000000184D905E0
		public BlendType Blend { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public bool Uniform { get; set; } // 0x0000000184D86A90-0x0000000184D86AA0 0x0000000184D86AA0-0x0000000184D86AB0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 59655
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyScaleRandom(); // 0x0000000184DA6130-0x0000000184DA6170
		static P3dModifyScaleRandom(); // 0x000000018A8F1770-0x000000018A8F1808
	
		// Methods
		protected override void OnModifyScale(ref Vector3 scale, float pressure); // 0x000000018A8F15C0-0x000000018A8F1770
	}

	[Serializable]
	public class P3dModifyTexturePressure : P3dModifier // TypeDefIndex: 59657
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
		public Texture Texture { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float PressureMin { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public float PressureMax { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
	
		// Constructors
		public P3dModifyTexturePressure(); // 0x0000000184DA6170-0x0000000184DA6190
		static P3dModifyTexturePressure(); // 0x000000018A8F1828-0x000000018A8F18C0
	
		// Methods
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure); // 0x000000018A8F1808-0x000000018A8F1828
	}

	[Serializable]
	public class P3dModifyTextureRandom : P3dModifier // TypeDefIndex: 59658
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private List<Texture> textures; // 0x18
	
		// Properties
		public List<Texture> Textures { get; } // 0x000000018A8F19E4-0x000000018A8F1A68 
	
		// Constructors
		public P3dModifyTextureRandom(); // 0x0000000184DA60F0-0x0000000184DA6100
		static P3dModifyTextureRandom(); // 0x000000018A8F194C-0x000000018A8F19E4
	
		// Methods
		protected override void OnModifyTexture(ref Texture texture, float pressure); // 0x000000018A8F18C0-0x000000018A8F194C
	}

	[Serializable]
	public struct P3dBlendMode // TypeDefIndex: 59659
	{
		// Fields
		public const int ALPHA_BLEND = 0; // Metadata: 0x0234D088
		public const int ALPHA_BLEND_INVERSE = 1; // Metadata: 0x0234D089
		public const int PREMULTIPLIED = 2; // Metadata: 0x0234D08A
		public const int ADDITIVE = 3; // Metadata: 0x0234D08B
		public const int ADDITIVE_SOFT = 4; // Metadata: 0x0234D08C
		public const int SUBTRACTIVE = 5; // Metadata: 0x0234D08D
		public const int SUBTRACTIVE_SOFT = 6; // Metadata: 0x0234D08E
		public const int REPLACE = 7; // Metadata: 0x0234D08F
		public const int REPLACE_ORIGINAL = 8; // Metadata: 0x0234D090
		public const int REPLACE_CUSTOM = 9; // Metadata: 0x0234D091
		public const int MULTIPLY_INVERSE_RGB = 10; // Metadata: 0x0234D092
		public const int BLUR = 11; // Metadata: 0x0234D093
		public const int NORMAL_BLEND = 12; // Metadata: 0x0234D094
		public const int NORMAL_REPLACE = 13; // Metadata: 0x0234D095
		public const int FLOW = 14; // Metadata: 0x0234D096
		public const int NORMAL_REPLACE_ORIGINAL = 15; // Metadata: 0x0234D097
		public const int NORMAL_REPLACE_CUSTOM = 16; // Metadata: 0x0234D098
		public const int COUNT = 17; // Metadata: 0x0234D099
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
		static P3dBlendMode(); // 0x000000018A8E3E4C-0x000000018A8E41BC
	
		// Methods
		public static P3dBlendMode AlphaBlend(Vector4 channels); // 0x000000018A8E36E4-0x000000018A8E3728
		public static P3dBlendMode AlphaBlendInverse(Vector4 channels); // 0x000000018A8E369C-0x000000018A8E36E4
		public static P3dBlendMode Premultiplied(Vector4 channels); // 0x000000018A8E3C94-0x000000018A8E3CDC
		public static P3dBlendMode Additive(Vector4 channels); // 0x000000018A8E3654-0x000000018A8E369C
		public static P3dBlendMode AdditiveSoft(Vector4 channels); // 0x000000018A8E360C-0x000000018A8E3654
		public static P3dBlendMode Subtractive(Vector4 channels); // 0x000000018A8E3E04-0x000000018A8E3E4C
		public static P3dBlendMode SubtractiveSoft(Vector4 channels); // 0x000000018A8E3DBC-0x000000018A8E3E04
		public static P3dBlendMode Replace(Vector4 channels); // 0x000000018A8E3D74-0x000000018A8E3DBC
		public static P3dBlendMode ReplaceOriginal(Vector4 channels); // 0x000000018A8E3D2C-0x000000018A8E3D74
		public static P3dBlendMode ReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels); // 0x000000018A8E3CDC-0x000000018A8E3D2C
		public static P3dBlendMode MultiplyInverseRGB(Vector4 channels); // 0x000000018A8E3B24-0x000000018A8E3B6C
		public static P3dBlendMode Blur(float kernel, Vector4 channels); // 0x000000018A8E3948-0x000000018A8E398C
		public static P3dBlendMode NormalBlend(Vector4 channels); // 0x000000018A8E3B6C-0x000000018A8E3BB4
		public static P3dBlendMode NormalReplace(Vector4 channels); // 0x000000018A8E3C4C-0x000000018A8E3C94
		public static P3dBlendMode Flow(float kernel, Vector4 channels); // 0x000000018A8E3A08-0x000000018A8E3A4C
		public static P3dBlendMode NormalReplaceOriginal(Vector4 channels); // 0x000000018A8E3C04-0x000000018A8E3C4C
		public static P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels); // 0x000000018A8E3BB4-0x000000018A8E3C04
		public void Apply(Material material); // 0x000000018A8E3728-0x000000018A8E3948
		public static string GetName(int index); // 0x000000018A8E3AB8-0x000000018A8E3B24
		public static bool operator ==(P3dBlendMode a, int b); // 0x0000000182EED260-0x0000000182EED270
		public static bool operator !=(P3dBlendMode a, int b); // 0x000000018A8E41BC-0x000000018A8E41C4
		public static implicit operator int(P3dBlendMode a); // 0x0000000182B77620-0x0000000182B77630
		public override int GetHashCode(); // 0x000000018A8E3A4C-0x000000018A8E3AB8
		public override bool Equals(object obj); // 0x000000018A8E398C-0x000000018A8E3A08
	}

	public static class P3dBlit // TypeDefIndex: 59660
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
		static P3dBlit(); // 0x000000018A8F6C28-0x000000018A8F6CFC
	
		// Methods
		public static void White(RenderTexture rendertexture, Mesh mesh, int submesh, P3dCoord coord); // 0x000000018A8F69E4-0x000000018A8F6C28
		public static void Texture(RenderTexture rendertexture, Mesh mesh, int submesh, Texture texture, P3dCoord coord); // 0x000000018A8F6760-0x000000018A8F69E4
		public static void Normal(RenderTexture rendertexture, Texture texture); // 0x000000018A8F6458-0x000000018A8F65A0
		public static void Premultiply(RenderTexture rendertexture, Texture texture, UnityEngine.Color tint); // 0x000000018A8F65A0-0x000000018A8F6760
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounter")]
	public class P3dChangeCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 59661
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
		public float Threshold { get; set; } // 0x0000000184D91E60-0x0000000184D91E70 0x000000018A8F7AD0-0x000000018A8F7B00
		public Texture Texture { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x000000018A8F7A4C-0x000000018A8F7AD0
		public UnityEngine.Color Color { get; set; } // 0x0000000184DA1230-0x0000000184DA1240 0x000000018A8F79FC-0x000000018A8F7A4C
		public int Count { get; } // 0x0000000184DA4B70-0x0000000184DA4B80 
		public float Ratio { get; } // 0x000000018A8F79D8-0x000000018A8F79FC 
		public P3dReader ChangeReader { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
	
		// Constructors
		public P3dChangeCounter(); // 0x000000018A8F799C-0x000000018A8F79D8
		static P3dChangeCounter(); // 0x000000018A8F7920-0x000000018A8F799C
	
		// Methods
		public void MarkChangeReaderAsDirty(); // 0x000000018A8F73C0-0x000000018A8F73D8
		public static long GetTotal(ICollection<P3dChangeCounter> counters = null); // 0x000000018A8F6F20-0x000000018A8F70B4
		public static long GetCount(ICollection<P3dChangeCounter> counters = null); // 0x000000018A8F6CFC-0x000000018A8F6E94
		public static float GetRatio(ICollection<P3dChangeCounter> counters = null); // 0x000000018A8F6E94-0x000000018A8F6F20
		private void HandleCompleteChange(NativeArray<Color32> pixels); // 0x000000018A8F70B4-0x000000018A8F721C
		protected override void HandleComplete(int boost); // 0x000000018A8F721C-0x000000018A8F73C0
		protected override void OnEnable(); // 0x000000018A8F7558-0x000000018A8F765C
		protected override void OnDisable(); // 0x000000018A8F7450-0x000000018A8F7558
		protected override void OnDestroy(); // 0x000000018A8F73D8-0x000000018A8F7450
		protected override void Update(); // 0x000000018A8F765C-0x000000018A8F7920
	}

	public enum P3dChannel // TypeDefIndex: 59662
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Alpha = 3
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounter")]
	public class P3dChannelCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 59663
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
		public float Threshold { get; set; } // 0x0000000184D91E60-0x0000000184D91E70 0x000000018A8F8C60-0x000000018A8F8C88
		public int CountR { get; } // 0x0000000184D88C90-0x0000000184D88CA0 
		public int CountG { get; } // 0x0000000184D88C80-0x0000000184D88C90 
		public int CountB { get; } // 0x0000000184D88CA0-0x0000000184D88CB0 
		public int CountA { get; } // 0x0000000184D8F8E0-0x0000000184D8F8F0 
		public float RatioR { get; } // 0x000000018A8F8C3C-0x000000018A8F8C60 
		public float RatioG { get; } // 0x000000018A8F8B64-0x000000018A8F8B88 
		public float RatioB { get; } // 0x000000018A8F8B40-0x000000018A8F8B64 
		public float RatioA { get; } // 0x000000018A8F8B1C-0x000000018A8F8B40 
		public Vector4 RatioRGBA { get; } // 0x000000018A8F8B88-0x000000018A8F8C3C 
	
		// Constructors
		public P3dChannelCounter(); // 0x000000018A8F8B04-0x000000018A8F8B1C
		static P3dChannelCounter(); // 0x000000018A8F8A88-0x000000018A8F8B04
	
		// Methods
		public static long GetTotal(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F86A8-0x000000018A8F883C
		public static long GetCountR(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F7FC8-0x000000018A8F8160
		public static long GetCountG(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F7E30-0x000000018A8F7FC8
		public static long GetCountB(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F7C98-0x000000018A8F7E30
		public static long GetCountA(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F7B00-0x000000018A8F7C98
		public static float GetRatioR(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F861C-0x000000018A8F86A8
		public static float GetRatioG(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F8278-0x000000018A8F8304
		public static float GetRatioB(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F81EC-0x000000018A8F8278
		public static float GetRatioA(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F8160-0x000000018A8F81EC
		public static Vector4 GetRatioRGBA(ICollection<P3dChannelCounter> counters = null); // 0x000000018A8F8304-0x000000018A8F861C
		protected override void OnEnable(); // 0x000000018A8F89FC-0x000000018A8F8A88
		protected override void OnDisable(); // 0x000000018A8F896C-0x000000018A8F89FC
		protected override void HandleComplete(int boost); // 0x000000018A8F883C-0x000000018A8F896C
	}

	public abstract class P3dClone : MonoBehaviour, IClone // TypeDefIndex: 59664
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
		public static LinkedList<P3dClone> Instances { get; } // 0x000000018A8F9D8C-0x000000018A8F9DDC 
	
		// Constructors
		protected P3dClone(); // 0x0000000185393520-0x0000000185393538
		static P3dClone(); // 0x000000018A8F9BF0-0x000000018A8F9D8C
	
		// Methods
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
		public static void BuildCloners(List<IClone> cloners = null); // 0x000000018A8F93CC-0x000000018A8F9810
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex); // 0x000000018A8F9810-0x000000018A8F9AF4
		protected virtual void OnEnable(); // 0x000000018A8F9B74-0x000000018A8F9BF0
		protected virtual void OnDisable(); // 0x000000018A8F9AF4-0x000000018A8F9B74
	}

	[AddComponentMenu("Paint in 3D/P3D Clone Mirror")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCloneMirror")]
	public class P3dCloneMirror : P3dClone // TypeDefIndex: 59665
	{
		// Fields
		[SerializeField]
		private bool flip; // 0x20
	
		// Properties
		public bool Flip { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
	
		// Constructors
		public P3dCloneMirror(); // 0x000000018A8F9378-0x000000018A8F93CC
	
		// Methods
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix); // 0x000000018A8F8C88-0x000000018A8F9378
	}

	[AddComponentMenu("Paint in 3D/P3D Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColor")]
	public class P3dColor : MonoBehaviour // TypeDefIndex: 59667
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private List<Contribution> contributions; // 0x28
		private static LinkedList<P3dColor> instances; // 0x00
		private LinkedListNode<P3dColor> instancesNode; // 0x30
	
		// Properties
		public UnityEngine.Color Color { get; set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
		public static LinkedList<P3dColor> Instances { get; } // 0x000000018A8FB340-0x000000018A8FB390 
		public int Total { get; } // 0x000000018A8FB4C8-0x000000018A8FB630 
		public int Solid { get; } // 0x000000018A8FB3D8-0x000000018A8FB4C8 
		public float Ratio { get; } // 0x000000018A8FB390-0x000000018A8FB3D8 
	
		// Nested types
		[SerializeField]
		private class Contribution // TypeDefIndex: 59666
		{
			// Fields
			public P3dColorCounter Counter; // 0x10
			public int Solid; // 0x18
	
			// Constructors
			public Contribution(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public P3dColor(); // 0x0000000185393520-0x0000000185393538
		static P3dColor(); // 0x000000018A8FB2C4-0x000000018A8FB340
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A8FAFDC-0x000000018A8FB194
		protected virtual void OnDisable(); // 0x000000018A8FAE14-0x000000018A8FAFDC
		public void Contribute(P3dColorCounter counter, int solid); // 0x000000018A8FAD48-0x000000018A8FAE14
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution); // 0x000000018A8FB194-0x000000018A8FB2C4
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounter")]
	public class P3dColorCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 59669
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
		public float Threshold { get; set; } // 0x0000000184D91E60-0x0000000184D91E70 0x000000018A8F8C60-0x000000018A8F8C88
		public List<Contribution> Contributions { get; } // 0x0000000184D86290-0x0000000184D862A0 
	
		// Nested types
		public class Contribution // TypeDefIndex: 59668
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
			public Contribution(); // 0x00000001841E1670-0x00000001841E1680
			static Contribution(); // 0x000000018A8F61A8-0x000000018A8F6234
		}
	
		// Constructors
		public P3dColorCounter(); // 0x000000018A8FACB8-0x000000018A8FAD48
		static P3dColorCounter(); // 0x000000018A8FAC3C-0x000000018A8FACB8
	
		// Methods
		public static long GetTotal(ICollection<P3dColorCounter> counters = null); // 0x000000018A8FA420-0x000000018A8FA5B4
		public static long GetCount(P3dColor color, ICollection<P3dColorCounter> counters = null); // 0x000000018A8FA1E0-0x000000018A8FA390
		public static float GetRatio(P3dColor color, ICollection<P3dColorCounter> counters = null); // 0x000000018A8FA390-0x000000018A8FA420
		public int Count(P3dColor color); // 0x000000018A8FA07C-0x000000018A8FA1E0
		public float Ratio(P3dColor color); // 0x000000018A8FAC04-0x000000018A8FAC3C
		protected override void OnEnable(); // 0x000000018A8FA8AC-0x000000018A8FA938
		protected override void OnDisable(); // 0x000000018A8FA810-0x000000018A8FA8AC
		protected override void HandleComplete(int boost); // 0x000000018A8FA5B4-0x000000018A8FA810
		private void ClearContributions(); // 0x000000018A8F9DDC-0x000000018A8F9ECC
		private void PrepareContributions(); // 0x000000018A8FA938-0x000000018A8FAC04
		private void Contribute(int scale); // 0x000000018A8F9ECC-0x000000018A8FA07C
	}

	[Serializable]
	public abstract class P3dCommand // TypeDefIndex: 59670
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
		protected P3dCommand(); // 0x00000001841E1670-0x00000001841E1680
		static P3dCommand(); // 0x000000018A8FBAFC-0x000000018A8FBB78
	
		// Methods
		public static void BuildMaterial(ref Material material, ref int materialHash, string path, string keyword = null); // 0x000000018A8FB780-0x000000018A8FB820
		public static int Compare(P3dCommand a, P3dCommand b); // 0x000000018A8FB820-0x000000018A8FB87C
		public void SetState(bool preview, int priority); // 0x0000000184DA6190-0x0000000184DA61A0
		public virtual void Apply(Material material); // 0x000000018A8FB630-0x000000018A8FB6EC
		public abstract void Pool();
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);
		public abstract P3dCommand SpawnCopy();
		public P3dCommand SpawnCopyLocal(Transform transform); // 0x000000018A8FB87C-0x000000018A8FB9BC
		public P3dCommand SpawnCopyWorld(Transform transform); // 0x000000018A8FB9BC-0x000000018A8FBAFC
		protected T SpawnCopy<T>(Stack<T> pool)
			where T : P3dCommand, new();
		public virtual void Apply(P3dPaintableTexture paintableTexture); // 0x000000018A8FB6EC-0x000000018A8FB780
	}

	public static class P3dCommon // TypeDefIndex: 59672
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/PaintIn3D#"; // Metadata: 0x0234D0A8
		public const string ComponentMenuPrefix = "Paint in 3D/P3D "; // Metadata: 0x0234D0DA
		public const string ComponentHitMenuPrefix = "Paint in 3D/Hit/P3D "; // Metadata: 0x0234D0EB
		public static Action<Camera> OnCameraDraw; // 0x00
		private static int _Coord; // 0x08
		private static Mesh sphereMesh; // 0x10
		private static bool sphereMeshSet; // 0x18
		private static Mesh quadMesh; // 0x20
		private static bool quadMeshSet; // 0x28
		private static Texture2D tempReadTexture; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59671
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018A90C284-0x000000018A90C2E8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.cctor_b__5_0(Camera camera); // 0x000000018A90C194-0x000000018A90C20C
			internal void _.cctor_b__5_1(ScriptableRenderContext context, Camera camera); // 0x000000018A90C20C-0x000000018A90C284
		}
	
		// Constructors
		static P3dCommon(); // 0x000000018A8FE3B8-0x000000018A8FE598
	
		// Methods
		public static float RatioToPercentage(float ratio01, int decimalPlaces); // 0x000000018A8FDDE8-0x000000018A8FDE94
		public static RenderTexture GetRenderTexture(RenderTexture other); // 0x000000018A8FD7D8-0x000000018A8FD890
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, RenderTexture other); // 0x000000018A8FD678-0x000000018A8FD75C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc); // 0x000000018A8FD890-0x000000018A8FD90C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB); // 0x000000018A8FD75C-0x000000018A8FD7D8
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture); // 0x000000018A8FE2F8-0x000000018A8FE300
		public static Quaternion NormalToCameraRotation(Vector3 normal, Camera optionalCamera = null); // 0x000000018A8FDCA4-0x000000018A8FDDE8
		public static Vector3 GetCameraUp(Camera camera = null); // 0x000000018A8FC684-0x000000018A8FC748
		public static bool CanReadPixels(TextureFormat format); // 0x000000018A8FBEDC-0x000000018A8FBEF4
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture); // 0x000000018A8FDE94-0x000000018A8FE08C
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture); // 0x000000018A8FE08C-0x000000018A8FE2F8
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary); // 0x000000018A8FC110-0x000000018A8FC394
		public static bool HasMipMaps(Texture texture); // 0x000000018A8FDA24-0x000000018A8FDB24
		public static Mesh GetSphereMesh(); // 0x000000018A8FD90C-0x000000018A8FDA24
		public static Mesh GetMesh(GameObject root, Mesh mesh = null); // 0x000000018A8FC7D0-0x000000018A8FC8DC
		public static Mesh GetQuadMesh(); // 0x000000018A8FCDC0-0x000000018A8FCEDC
		public static UnityEngine.Color GetPixel(RenderTexture renderTexture, Vector2 uv, bool mipMaps = false /* Metadata: 0x0234D09E */); // 0x000000018A8FC8DC-0x000000018A8FCBA4
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x0234D09F */, bool mipMaps = false /* Metadata: 0x0234D0A0 */, int width = 0 /* Metadata: 0x0234D0A1 */, int height = 0 /* Metadata: 0x0234D0A2 */); // 0x000000018A8FD428-0x000000018A8FD678
		public static void SaveBytes(string saveName, byte[] data, bool save = true /* Metadata: 0x0234D0A3 */); // 0x000000018A8FE300-0x000000018A8FE37C
		public static byte[] LoadBytes(string saveName); // 0x000000018A8FDB7C-0x000000018A8FDBDC
		public static bool SaveExists(string saveName); // 0x000000018A8FE37C-0x000000018A8FE384
		public static void ClearSave(string saveName, bool save = true /* Metadata: 0x0234D0A4 */); // 0x000000018A8FBEF4-0x000000018A8FBF30
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition); // 0x000000018A8FCBA4-0x000000018A8FCC28
		public static Vector3 GetPosition(Vector3 positionA, Vector3 positionB, Vector3 positionC); // 0x000000018A8FCC28-0x000000018A8FCCDC
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2); // 0x000000018A8FCCDC-0x000000018A8FCDC0
		public static float GetRadius(Vector3 size); // 0x000000018A8FD194-0x000000018A8FD1CC
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition); // 0x000000018A8FCEDC-0x000000018A8FCFD0
		public static float GetRadius(Vector3 size, Vector3 positionA, Vector3 positionB, Vector3 positionC); // 0x000000018A8FCFD0-0x000000018A8FD194
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2); // 0x000000018A8FD1CC-0x000000018A8FD428
		public static Vector3 ScaleAspect(Vector3 size, float aspect); // 0x000000018A8FE384-0x000000018A8FE3B8
		public static float GetAspect(Texture textureA, Texture textureB = null); // 0x000000018A8FC5AC-0x000000018A8FC684
		public static void Blit(RenderTexture renderTexture, Texture other); // 0x000000018A8FBCDC-0x000000018A8FBD4C
		public static void Blit(RenderTexture renderTexture, Material material, int pass); // 0x000000018A8FBD4C-0x000000018A8FBDD4
		public static Vector4 IndexToVector(int index); // 0x000000018A8FDB24-0x000000018A8FDB7C
		public static void Draw(Material material, int pass, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord); // 0x000000018A8FC494-0x000000018A8FC5AC
		public static void Draw(Material material, int pass); // 0x000000018A8FC394-0x000000018A8FC494
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps); // 0x000000018A8FC070-0x000000018A8FC110
		public static Material GetMaterial(Renderer renderer, int materialIndex = 0 /* Metadata: 0x0234D0A5 */); // 0x000000018A8FC748-0x000000018A8FC7D0
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x0234D0A6 */); // 0x000000018A8FBF30-0x000000018A8FC070
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1 /* Metadata: 0x0234D0A7 */); // 0x000000018A8FBB78-0x000000018A8FBCDC
		public static Shader LoadShader(string shaderName); // 0x000000018A8FDBDC-0x000000018A8FDCA4
		public static Material BuildMaterial(Shader shader); // 0x000000018A8FBDD4-0x000000018A8FBE34
		public static Material BuildMaterial(string shaderName, string keyword = null); // 0x000000018A8FBE34-0x000000018A8FBEDC
	}

	public enum P3dCoord // TypeDefIndex: 59673
	{
		First = 0,
		Second = 1,
		Third = 2,
		Fourth = 3
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCoordCopier")]
	public class P3dCoordCopier : ScriptableObject // TypeDefIndex: 59675
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
		public Mesh Source { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Coord First { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public Coord Second { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public Coord Third { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public Coord Fourth { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	
		// Nested types
		public enum Coord // TypeDefIndex: 59674
		{
			First = 0,
			Second = 1,
			Third = 2,
			Fourth = 3,
			None = 4
		}
	
		// Constructors
		public P3dCoordCopier(); // 0x000000018A8FF1CC-0x000000018A8FF1F0
		static P3dCoordCopier(); // 0x000000018A8FEDBC-0x000000018A8FF1CC
	
		// Methods
		public List<Vector4> GetCoords(Coord coord); // 0x000000018A8FECB8-0x000000018A8FED64
		public void Generate(); // 0x000000018A8FE598-0x000000018A8FECB8
		protected virtual void OnDestroy(); // 0x000000018A8FED64-0x000000018A8FEDBC
	}

	[AddComponentMenu("Paint in 3D/P3D Gradually Fade")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dGraduallyFade")]
	public class P3dGraduallyFade : MonoBehaviour // TypeDefIndex: 59676
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
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float Threshold { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public float Speed { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
		public P3dBlendMode BlendMode { get; set; } // 0x0000000184DA61A0-0x0000000184DA61D0 0x000000018A8FF640-0x000000018A8FF66C
		public Texture BlendTexture { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public P3dPaintableTexture BlendPaintableTexture { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public UnityEngine.Color BlendColor { get; set; } // 0x0000000184D8FD40-0x0000000184D8FD50 0x0000000184DA1310-0x0000000184DA1320
		public Texture MaskTexture { get; set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public P3dPaintableTexture MaskPaintableTexture { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public P3dChannel MaskChannel { get; set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
	
		// Constructors
		public P3dGraduallyFade(); // 0x000000018A8FF57C-0x000000018A8FF640
	
		// Methods
		protected virtual void Update(); // 0x000000018A8FF1F0-0x000000018A8FF57C
	}

	[Serializable]
	public struct P3dGroup // TypeDefIndex: 59677
	{
		// Fields
		[SerializeField]
		private int index; // 0x00
	
		// Constructors
		public P3dGroup(int newIndex); // 0x0000000184D86140-0x0000000184D86150
	
		// Methods
		public static implicit operator int(P3dGroup group); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static implicit operator P3dGroup(int index); // 0x0000000184D88BE0-0x0000000184D88BF0
		public override string ToString(); // 0x000000018A8FFBF8-0x000000018A8FFC00
	}

	public class P3dGroupData : ScriptableObject // TypeDefIndex: 59680
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
		public int Index { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public List<TextureData> TextureDatas { get; } // 0x000000018A8FFB74-0x000000018A8FFBF8 
		public string ShaderData { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Nested types
		[Serializable]
		public class TextureData // TypeDefIndex: 59678
		{
			// Fields
			public string Name; // 0x10
			public P3dBlendMode BlendMode; // 0x18
	
			// Constructors
			public TextureData(); // 0x000000018A90C0FC-0x000000018A90C194
		}
	
		private class Entry // TypeDefIndex: 59679
		{
			// Fields
			public string Path; // 0x10
			public string Property; // 0x18
	
			// Constructors
			public Entry(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public P3dGroupData(); // 0x000000018A8FFAF4-0x000000018A8FFB74
	
		// Methods
		public void TryGetShaderSlotName(string shaderPath, ref string propertyName); // 0x000000018A8FF75C-0x000000018A8FFAF4
		public bool Supports(Shader shader); // 0x000000018A8FF6E0-0x000000018A8FF75C
		public string GetName(bool prefixNumber); // 0x000000018A8FF66C-0x000000018A8FF6E0
	}

	[Serializable]
	public struct P3dHash // TypeDefIndex: 59681
	{
		// Fields
		[SerializeField]
		private int v; // 0x00
	
		// Constructors
		public P3dHash(int newValue); // 0x0000000184D86140-0x0000000184D86150
	
		// Methods
		public override bool Equals(object obj); // 0x000000018A8FFC00-0x000000018A8FFC5C
		public override int GetHashCode(); // 0x0000000182B77620-0x0000000182B77630
		public static implicit operator int(P3dHash hash); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static implicit operator P3dHash(int index); // 0x0000000184D88BE0-0x0000000184D88BF0
		public override string ToString(); // 0x000000018A8FFBF8-0x000000018A8FFC00
	}

	[Serializable]
	public struct P3dHashedMaterial // TypeDefIndex: 59682
	{
		// Fields
		[NonSerialized]
		private Material instance; // 0x00
		[SerializeField]
		private int hash; // 0x08
	
		// Constructors
		public P3dHashedMaterial(Material newInstance, int newHash); // 0x00000001853955EC-0x0000000185395608
	
		// Methods
		public bool TryGetInstance(out Material model); // 0x000000018A8FFC5C-0x000000018A8FFD24
	}

	[Serializable]
	public struct P3dHashedModel // TypeDefIndex: 59683
	{
		// Fields
		[NonSerialized]
		private P3dModel instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedModel(P3dModel newInstance); // 0x000000018A8FFE1C-0x000000018A8FFEB0
		public bool TryGetInstance(out P3dModel model); // 0x000000018A8FFD24-0x000000018A8FFE1C
	}

	[Serializable]
	public struct P3dHashedTexture // TypeDefIndex: 59684
	{
		// Fields
		[NonSerialized]
		private Texture instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedTexture(Texture newInstance); // 0x000000018A8FFF9C-0x000000018A900060
		public static implicit operator Texture(P3dHashedTexture hashed); // 0x000000018A8FFF78-0x000000018A8FFF9C
		public bool TryGetInstance(out Texture texture); // 0x000000018A8FFEB0-0x000000018A8FFF78
	}

	public struct P3dHit // TypeDefIndex: 59685
	{
		// Fields
		public Transform Root; // 0x00
		public Vector2 First; // 0x08
		public Vector2 Second; // 0x10
	
		// Constructors
		public P3dHit(RaycastHit hit); // 0x000000018A900060-0x000000018A9000F0
	}

	[Serializable]
	public class P3dLineConnector // TypeDefIndex: 59687
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
		public float HitSpacing { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public int HitLimit { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public bool ConnectHits { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool ClipConnected { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public P3dHitCache HitCache { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		private class Link // TypeDefIndex: 59686
		{
			// Fields
			public object Owner; // 0x10
			public Vector3 Position; // 0x18
			public Vector3 EndPosition; // 0x24
			public float Age; // 0x30
			public bool Preview; // 0x34
	
			// Constructors
			public Link(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public P3dLineConnector(); // 0x000000018A900CDC-0x000000018A900D90
		static P3dLineConnector(); // 0x000000018A900C50-0x000000018A900CDC
	
		// Methods
		public void ClearHitCache(); // 0x000000018A9001FC-0x000000018A90021C
		public void ResetConnections(); // 0x000000018A90021C-0x000000018A900304
		public void BreakHits(object owner); // 0x000000018A9000F0-0x000000018A9001FC
		public void SubmitLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, object owner); // 0x000000018A900304-0x000000018A900A6C
		public void Update(); // 0x000000018A900B20-0x000000018A900C50
		private bool TryGetLink(object owner, ref Link link); // 0x000000018A900A6C-0x000000018A900B20
	}

	[AddComponentMenu("Paint in 3D/P3D Mask")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMask")]
	public class P3dMask : MonoBehaviour // TypeDefIndex: 59688
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
		public Texture Texture { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public P3dChannel Channel { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public Vector2 Stretch { get; set; } // 0x0000000184D88060-0x0000000184D88080 0x0000000184DA5EC0-0x0000000184DA5ED0
		public static LinkedList<P3dMask> Instances { get; } // 0x000000018A9011B8-0x000000018A901208 
		public Matrix4x4 Matrix { get; } // 0x000000018A901208-0x000000018A901260 
	
		// Constructors
		public P3dMask(); // 0x000000018A90118C-0x000000018A9011B8
		static P3dMask(); // 0x000000018A901110-0x000000018A90118C
	
		// Methods
		public static P3dMask Find(Vector3 position, LayerMask layers); // 0x000000018A900D90-0x000000018A901018
		protected virtual void OnEnable(); // 0x000000018A901094-0x000000018A901110
		protected virtual void OnDisable(); // 0x000000018A901018-0x000000018A901094
	}

	[AddComponentMenu("Paint in 3D/P3D Material Cloner")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterialCloner")]
	[RequireComponent(typeof(Renderer))]
	[RequireComponent(typeof(P3dPaintable))]
	public class P3dMaterialCloner : MonoBehaviour // TypeDefIndex: 59689
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
		public int Index { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public Renderer CachedRenderer { get; } // 0x000000018A901684-0x000000018A9016DC 
		public P3dPaintable CachedPaintable { get; } // 0x000000018A90162C-0x000000018A901684 
		public Material Original { get; } // 0x0000000184D86200-0x0000000184D86210 
		public Material Current { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public bool Activated { get; } // 0x0000000184D86650-0x0000000184D86660 
	
		// Constructors
		public P3dMaterialCloner(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018A901260-0x000000018A901374
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018A901374-0x000000018A9013FC
		public void ReplaceAll(Material from, Material to); // 0x000000018A9013FC-0x000000018A90154C
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial); // 0x000000018A90154C-0x000000018A90162C
	}

	public static class P3dMeshCache // TypeDefIndex: 59691
	{
		// Fields
		private static Dictionary<Mesh, MeshData> cachedData; // 0x00
	
		// Nested types
		private class MeshData // TypeDefIndex: 59690
		{
			// Fields
			private Vector3[] positions; // 0x10
			private int[] indices; // 0x18
			private int total; // 0x20
	
			// Constructors
			public MeshData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Update(Mesh mesh); // 0x000000018A8F63E8-0x000000018A8F6458
			public bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC); // 0x000000018A8F6234-0x000000018A8F63E8
		}
	
		// Constructors
		static P3dMeshCache(); // 0x000000018A9018F4-0x000000018A901980
	
		// Methods
		public static bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC); // 0x000000018A9016DC-0x000000018A9018F4
	}

	[AddComponentMenu("Paint in 3D/P3D Model")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dModel")]
	[RequireComponent(typeof(Renderer))]
	public class P3dModel : MonoBehaviour // TypeDefIndex: 59693
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
		public virtual P3dPaintable Paintable { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public virtual bool IncludeScale { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public UseMeshType UseMesh { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public P3dHash Hash { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x000000018A902D2C-0x000000018A902D80
		public static LinkedList<P3dModel> Instances { get; } // 0x000000018A902C94-0x000000018A902CE4 
		public bool Prepared { get; set; } // 0x0000000184D8FEE0-0x0000000184D8FEF0 0x0000000184D8FEF0-0x0000000184D8FF00
		public Mesh PreparedMesh { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public GameObject CachedGameObject { get; } // 0x0000000184D86280-0x0000000184D86290 
		public Renderer CachedRenderer { get; } // 0x000000018A902C6C-0x000000018A902C94 
		public Material[] Materials { get; } // 0x000000018A902CE4-0x000000018A902D2C 
	
		// Nested types
		public enum UseMeshType // TypeDefIndex: 59692
		{
			AsIs = 0,
			AutoSeamFix = 1
		}
	
		// Constructors
		public P3dModel(); // 0x0000000184D84C40-0x0000000184D84C60
		static P3dModel(); // 0x000000018A902B8C-0x000000018A902C6C
	
		// Methods
		public int GetMaterialIndex(Material material); // 0x000000018A901DF8-0x000000018A901F48
		private void CacheRenderer(); // 0x000000018A901980-0x000000018A901A54
		[ContextMenu("Dirty Materials")]
		public void DirtyMaterials(); // 0x0000000184DA61D0-0x0000000184DA61E0
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask); // 0x000000018A901A54-0x000000018A901DF8
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC); // 0x000000018A9022D8-0x000000018A9024D0
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC); // 0x000000018A901F48-0x000000018A902110
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC); // 0x000000018A902110-0x000000018A9022D8
		public int GetSubmesh(P3dPaintableTexture paintableTexture); // 0x000000018A9028F8-0x000000018A9029A0
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix, P3dCoord coord); // 0x000000018A9024D0-0x000000018A9028F8
		protected virtual void OnEnable(); // 0x000000018A902AAC-0x000000018A902B8C
		protected virtual void OnDisable(); // 0x000000018A902A24-0x000000018A902AAC
		protected virtual void OnDestroy(); // 0x000000018A9029A0-0x000000018A902A24
	}

	[Serializable]
	public abstract class P3dModifier // TypeDefIndex: 59694
	{
		// Fields
		[SerializeField]
		private bool preview; // 0x10
		[SerializeField]
		private bool unique; // 0x11
	
		// Properties
		public bool Preview { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public bool Unique { get; set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
	
		// Constructors
		protected P3dModifier(); // 0x0000000184DA60F0-0x0000000184DA6100
	
		// Methods
		public void ModifyAngle(ref float angle, float pressure); // 0x000000018A903844-0x000000018A9038D0
		protected virtual void OnModifyAngle(ref float angle, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyColor(ref UnityEngine.Color color, float pressure); // 0x000000018A9038D0-0x000000018A903954
		protected virtual void OnModifyColor(ref UnityEngine.Color color, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyHardness(ref float hardness, float pressure); // 0x000000018A903954-0x000000018A9039E0
		protected virtual void OnModifyHardness(ref float hardness, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyOpacity(ref float opacity, float pressure); // 0x000000018A9039E0-0x000000018A903A6C
		protected virtual void OnModifyOpacity(ref float opacity, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyRadius(ref float radius, float pressure); // 0x000000018A903AF8-0x000000018A903B84
		protected virtual void OnModifyRadius(ref float radius, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyScale(ref Vector3 scale, float pressure); // 0x000000018A903B84-0x000000018A903C10
		protected virtual void OnModifyScale(ref Vector3 scale, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyTexture(ref Texture texture, float pressure); // 0x000000018A903C10-0x000000018A903C94
		protected virtual void OnModifyTexture(ref Texture texture, float pressure); // 0x00000001841E1670-0x00000001841E1680
		public void ModifyPosition(ref Vector3 position, float pressure); // 0x000000018A903A6C-0x000000018A903AF8
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class P3dModifierList // TypeDefIndex: 59695
	{
		// Fields
		[SerializeReference]
		private List<P3dModifier> modifiers; // 0x10
	
		// Properties
		public int Count { get; } // 0x000000018A903780-0x000000018A9037C0 
		public List<P3dModifier> Instances { get; } // 0x000000018A9037C0-0x000000018A903844 
	
		// Constructors
		public P3dModifierList(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void ModifyAngle(ref float angle, bool preview, float pressure); // 0x000000018A902D80-0x000000018A902EC0
		public void ModifyColor(ref UnityEngine.Color color, bool preview, float pressure); // 0x000000018A902EC0-0x000000018A903000
		public void ModifyHardness(ref float hardness, bool preview, float pressure); // 0x000000018A903000-0x000000018A903140
		public void ModifyOpacity(ref float opacity, bool preview, float pressure); // 0x000000018A903140-0x000000018A903280
		public void ModifyRadius(ref float radius, bool preview, float pressure); // 0x000000018A9033C0-0x000000018A903500
		public void ModifyScale(ref Vector3 scale, bool preview, float pressure); // 0x000000018A903500-0x000000018A903640
		public void ModifyTexture(ref Texture texture, bool preview, float pressure); // 0x000000018A903640-0x000000018A903780
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure); // 0x000000018A903280-0x000000018A9033C0
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintable")]
	[RequireComponent(typeof(Renderer))]
	public class P3dPaintable : P3dModel // TypeDefIndex: 59697
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
		public override P3dPaintable Paintable { get; set; } // 0x000000018A90A960-0x000000018A90A980 0x00000001841E1670-0x00000001841E1680
		public ActivationType Activation { get; set; } // 0x0000000184DA61F0-0x0000000184DA6200 0x0000000184DA6220-0x0000000184DA6230
		public Vector3 BaseScale { get; set; } // 0x0000000184DA6200-0x0000000184DA6220 0x0000000184DA6230-0x0000000184DA6250
		public List<Renderer> OtherRenderers { get; set; } // 0x0000000184D85F90-0x0000000184D85FA0 0x00000001868C2E50-0x00000001868C2E64
		public UnityEvent OnActivating { get; } // 0x000000018A90A8E4-0x000000018A90A960 
		public UnityEvent OnActivated { get; } // 0x000000018A90A868-0x000000018A90A8E4 
		public bool Activated { get; } // 0x0000000184D8FE70-0x0000000184D8FE80 
		public HashSet<P3dPaintableTexture> PaintableTextures { get; } // 0x0000000184D8D910-0x0000000184D8D920 
	
		// Nested types
		public enum ActivationType // TypeDefIndex: 59696
		{
			Awake = 0,
			OnEnable = 1,
			Start = 2,
			OnFirstUse = 3
		}
	
		// Constructors
		public P3dPaintable(); // 0x000000018A90A770-0x000000018A90A868
		static P3dPaintable(); // 0x000000018A90A6E4-0x000000018A90A770
	
		// Methods
		public void RemoveComponents(); // 0x000000018A90A3F8-0x000000018A90A560
		public void ScaleSize(ref int width, ref int height); // 0x000000018A90A560-0x000000018A90A670
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018A9099C4-0x000000018A909C28
		private void AddPaintableTextures(Transform root); // 0x000000018A909C28-0x000000018A909E70
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018A90A014-0x000000018A90A33C
		public void ClearAll(UnityEngine.Color color); // 0x000000018A909E8C-0x000000018A909EAC
		public void ClearAll(Texture texture, UnityEngine.Color color); // 0x000000018A909EAC-0x000000018A90A014
		public void Register(P3dPaintableTexture paintableTexture); // 0x000000018A90A3A0-0x000000018A90A3F8
		public void Unregister(P3dPaintableTexture paintableTexture); // 0x000000018A90A68C-0x000000018A90A6E4
		protected virtual void Awake(); // 0x000000018A909E70-0x000000018A909E8C
		protected override void OnEnable(); // 0x000000018A90A33C-0x000000018A90A3A0
		protected virtual void Start(); // 0x000000018A90A670-0x000000018A90A68C
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Manager")]
	[DefaultExecutionOrder(100)]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableManager")]
	public class P3dPaintableManager : MonoBehaviour // TypeDefIndex: 59698
	{
		// Fields
		private static LinkedList<P3dPaintableManager> instances; // 0x00
		private LinkedListNode<P3dPaintableManager> instancesNode; // 0x18
	
		// Properties
		public static LinkedList<P3dPaintableManager> Instances { get; } // 0x000000018A904920-0x000000018A904970 
	
		// Constructors
		public P3dPaintableManager(); // 0x0000000185393520-0x0000000185393538
		static P3dPaintableManager(); // 0x000000018A9048A4-0x000000018A904920
	
		// Methods
		public static P3dPaintableManager GetOrCreateInstance(); // 0x000000018A903F4C-0x000000018A904098
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture); // 0x000000018A9043CC-0x000000018A9045D0
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture); // 0x000000018A903DD0-0x000000018A903F4C
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group); // 0x000000018A9042D0-0x000000018A9043CC
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group); // 0x000000018A9045D0-0x000000018A9046B0
		public static P3dCommand Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture); // 0x000000018A9046B0-0x000000018A904760
		protected virtual void OnEnable(); // 0x000000018A904254-0x000000018A9042D0
		protected virtual void OnDisable(); // 0x000000018A9041D8-0x000000018A904254
		protected virtual void LateUpdate(); // 0x000000018A904098-0x000000018A9041D8
		private void ClearAll(); // 0x000000018A903C94-0x000000018A903DD0
		private void UpdateAll(); // 0x000000018A904760-0x000000018A9048A4
	}

	public class P3dPaintableState // TypeDefIndex: 59699
	{
		// Fields
		public RenderTexture Texture; // 0x10
		public List<P3dCommand> Commands; // 0x18
		private static Stack<P3dPaintableState> pool; // 0x00
	
		// Constructors
		public P3dPaintableState(); // 0x000000018A904E8C-0x000000018A904F04
		static P3dPaintableState(); // 0x000000018A904E00-0x000000018A904E8C
	
		// Methods
		public static P3dPaintableState Pop(); // 0x000000018A904AE8-0x000000018A904B9C
		public void Write(RenderTexture current); // 0x000000018A904B9C-0x000000018A904C84
		public void Write(List<P3dCommand> commands); // 0x000000018A904C84-0x000000018A904CE4
		public void Write(RenderTexture current, List<P3dCommand> commands); // 0x000000018A904CE4-0x000000018A904E00
		private void Clear(); // 0x000000018A904970-0x000000018A904A70
		public void Pool(); // 0x000000018A904A70-0x000000018A904AE8
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Texture")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableTexture")]
	public class P3dPaintableTexture : MonoBehaviour // TypeDefIndex: 59709
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
		[CompilerGenerated]
		private Action<P3dCommand> OnAddCommand; // 0xB0
		[CompilerGenerated]
		private static Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal; // 0x00
		public static Action<P3dPaintableTexture> OnInstanceAdded; // 0x08
		public static Action<P3dPaintableTexture> OnInstanceRemoved; // 0x10
		[CompilerGenerated]
		private Action<bool> OnModified; // 0xB8
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
		public P3dSlot Slot { get; set; } // 0x0000000184D890C0-0x0000000184D890D0 0x000000018A9099B4-0x000000018A9099C4
		public P3dCoord Coord { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public P3dGroup Group { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public UndoRedoType UndoRedo { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public int StateLimit { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public SaveLoadType SaveLoad { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public string SaveName { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public int Width { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public int Height { get; set; } // 0x0000000184D86600-0x0000000184D86610 0x0000000184D86630-0x0000000184D86640
		public Texture Texture { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public UnityEngine.Color Color { get; set; } // 0x0000000184D87E00-0x0000000184D87E10 0x0000000184DA61E0-0x0000000184DA61F0
		public RenderTextureFormat Format { get; set; } // 0x0000000184D86CF0-0x0000000184D86D00 0x0000000184D86D00-0x0000000184D86D10
		public MipType MipMaps { get; set; } // 0x0000000184D86B50-0x0000000184D86B60 0x0000000184D86BB0-0x0000000184D86BC0
		public FilterType Filter { get; set; } // 0x0000000184D868A0-0x0000000184D868B0 0x0000000184D868D0-0x0000000184D868E0
		public AnisoType Aniso { get; set; } // 0x0000000184D868B0-0x0000000184D868C0 0x0000000184D868E0-0x0000000184D868F0
		public WrapType WrapU { get; set; } // 0x0000000184D863C0-0x0000000184D863D0 0x0000000184D86440-0x0000000184D86450
		public WrapType WrapV { get; set; } // 0x0000000184D86410-0x0000000184D86420 0x0000000184D86490-0x0000000184D864A0
		public ExistingType Existing { get; set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
		public ConversionType Conversion { get; set; } // 0x0000000184D8FCE0-0x0000000184D8FCF0 0x0000000184D8FCF0-0x0000000184D8FD00
		public Texture LocalMaskTexture { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public P3dChannel LocalMaskChannel { get; set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
		public string ShaderKeyword { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public P3dHash Hash { get; set; } // 0x0000000184D88CD0-0x0000000184D88CE0 0x000000018A909960-0x000000018A9099B4
		public bool IsDummy { get; set; } // 0x0000000184D88D60-0x0000000184D88D70 0x0000000184D88D70-0x0000000184D88D80
		public string Output { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public static LinkedList<P3dPaintableTexture> Instances { get; } // 0x000000018A909614-0x000000018A909664 
		public bool Activated { get; } // 0x0000000184D91920-0x0000000184D91930 
		public bool CanUndo { get; } // 0x000000018A9095AC-0x000000018A9095C0 
		public bool CanRedo { get; } // 0x000000018A909554-0x000000018A9095AC 
		public List<P3dPaintableState> States { get; } // 0x0000000184D88EF0-0x0000000184D88F00 
		public int StateIndex { get; } // 0x0000000184D9A880-0x0000000184D9A890 
		public Material Material { get; } // 0x000000018A909664-0x000000018A909694 
		public P3dPaintable Paintable { get; } // 0x000000018A909694-0x000000018A909724 
		public RenderTexture Current { get; set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x000000018A909908-0x000000018A909960
		public RenderTexture Preview { get; } // 0x0000000184D876B0-0x0000000184D876C0 
		public bool CommandsPending { get; } // 0x000000018A9095C0-0x000000018A909614 
	
		// Events
		public event Action<P3dCommand> OnAddCommand {
			add; // 0x000000018A909434-0x000000018A9094C4
			remove; // 0x000000018A9097E8-0x000000018A909878
		}
		public static event Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal {
			add; // 0x000000018A909370-0x000000018A909434
			remove; // 0x000000018A909724-0x000000018A9097E8
		}
		public event Action<bool> OnModified {
			add; // 0x000000018A9094C4-0x000000018A909554
			remove; // 0x000000018A909878-0x000000018A909908
		}
	
		// Nested types
		public enum UndoRedoType // TypeDefIndex: 59700
		{
			None = 0,
			FullTextureCopy = 1,
			LocalCommandCopy = 2
		}
	
		public enum SaveLoadType // TypeDefIndex: 59701
		{
			Manual = 0,
			Automatic = 1,
			SemiManual = 2
		}
	
		public enum MipType // TypeDefIndex: 59702
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum FilterType // TypeDefIndex: 59703
		{
			Auto = -1,
			Point = 0,
			Bilinear = 1,
			Trilinear = 2
		}
	
		public enum AnisoType // TypeDefIndex: 59704
		{
			Auto = -1,
			Off = 0,
			One = 1,
			Four = 4,
			Eight = 8,
			Sixteen = 16
		}
	
		public enum WrapType // TypeDefIndex: 59705
		{
			Auto = -1,
			Repeat = 0,
			Clamp = 1,
			Mirror = 2,
			MirrorOnce = 3
		}
	
		public enum ExistingType // TypeDefIndex: 59706
		{
			Ignore = 0,
			Use = 1,
			UseAndKeep = 2
		}
	
		public enum ConversionType // TypeDefIndex: 59707
		{
			None = 0,
			Normal = 1,
			Premultiply = 2
		}
	
		[Serializable]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture> // TypeDefIndex: 59708
		{
			// Constructors
			public PaintableTextureEvent(); // 0x000000018A90C0C0-0x000000018A90C0FC
		}
	
		// Constructors
		public P3dPaintableTexture(); // 0x000000018A9091A8-0x000000018A909370
		static P3dPaintableTexture(); // 0x000000018A909068-0x000000018A9091A8
	
		// Methods
		public static List<P3dPaintableTexture> FilterAll(P3dModel model, P3dGroup group); // 0x000000018A9075B8-0x000000018A90780C
		[ContextMenu("Clear States")]
		public void ClearStates(); // 0x000000018A9067CC-0x000000018A90687C
		[ContextMenu("Store State")]
		public void StoreState(); // 0x000000018A908C44-0x000000018A908CD0
		[ContextMenu("Undo")]
		public void Undo(); // 0x000000018A908EA0-0x000000018A908F98
		[ContextMenu("Redo")]
		public void Redo(); // 0x000000018A908720-0x000000018A9087E8
		public void SetColor(string html); // 0x000000018A908B38-0x000000018A908B4C
		public Vector2 GetCoord(ref P3dHit hit); // 0x000000018A90780C-0x000000018A907840
		public Vector2 GetCoord(ref RaycastHit hit); // 0x000000018A907840-0x000000018A90786C
		private bool StatesContainTextureOrCommands(); // 0x000000018A908B4C-0x000000018A908C44
		private bool LastStateWithTextureOr0(ref int startIndex); // 0x000000018A907E60-0x000000018A907F2C
		private void RebuildFromCommands(); // 0x000000018A908384-0x000000018A908720
		private void AddState(); // 0x000000018A90648C-0x000000018A9065C8
		private void TrimFuture(); // 0x000000018A908CD0-0x000000018A908DF0
		private void TrimPast(); // 0x000000018A908DF0-0x000000018A908EA0
		public void NotifyOnModified(bool preview); // 0x000000018A9080C0-0x000000018A9080DC
		public Texture2D GetReadableCopy(bool convertBack = false /* Metadata: 0x0234D10F */); // 0x000000018A907918-0x000000018A907BB4
		public byte[] GetPngData(bool convertBack = false /* Metadata: 0x0234D110 */); // 0x000000018A90786C-0x000000018A907918
		public byte[] GetTgaData(bool convertBack = false /* Metadata: 0x0234D111 */); // 0x000000018A907BB4-0x000000018A907C60
		[ContextMenu("Clear")]
		public void Clear(); // 0x000000018A90687C-0x000000018A9068A8
		public void Clear(Texture texture, UnityEngine.Color tint, bool updateMips = true /* Metadata: 0x0234D112 */); // 0x000000018A9068A8-0x000000018A9069DC
		[ContextMenu("Replace")]
		public void Replace(); // 0x000000018A9088BC-0x000000018A9088E0
		public void Replace(Texture texture, UnityEngine.Color tint); // 0x000000018A9087E8-0x000000018A9088BC
		public bool Resize(int width, int height, bool copyContents = true /* Metadata: 0x0234D113 */); // 0x000000018A9088E0-0x000000018A908AB4
		[ContextMenu("Save")]
		public void Save(); // 0x000000018A908B2C-0x000000018A908B38
		public void Save(string saveName); // 0x000000018A908AB4-0x000000018A908B2C
		[ContextMenu("Load")]
		public void Load(); // 0x000000018A9080B0-0x000000018A9080C0
		public void Load(string saveName, bool replace = true /* Metadata: 0x0234D114 */); // 0x000000018A908048-0x000000018A9080B0
		public void LoadFromData(byte[] data, bool allowResize = true /* Metadata: 0x0234D115 */); // 0x000000018A907F2C-0x000000018A908048
		public void HidePreview(); // 0x000000018A907DAC-0x000000018A907E60
		public static void HideAllPreviews(); // 0x000000018A907C60-0x000000018A907DAC
		[ContextMenu("Clear Save")]
		public void ClearSave(); // 0x000000018A90677C-0x000000018A9067CC
		public static void ClearSave(string saveName); // 0x000000018A906730-0x000000018A90677C
		[ContextMenu("Update Material")]
		public void UpdateMaterial(); // 0x000000018A908F98-0x000000018A909068
		[ContextMenu("Copy Size")]
		public void CopySize(); // 0x000000018A9069DC-0x000000018A906A80
		[ContextMenu("Copy Texture")]
		public void CopyTexture(); // 0x000000018A906A80-0x000000018A906ABC
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018A905E38-0x000000018A9062FC
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018A906ABC-0x000000018A906BD8
		protected virtual void OnEnable(); // 0x000000018A90828C-0x000000018A908384
		protected virtual void OnDisable(); // 0x000000018A9081C8-0x000000018A90828C
		protected virtual void OnApplicationPause(bool paused); // 0x000000018A9080DC-0x000000018A908110
		protected virtual void OnDestroy(); // 0x000000018A908110-0x000000018A9081C8
		public void AddCommand(P3dCommand command); // 0x000000018A9062FC-0x000000018A90648C
		public void ClearCommands(); // 0x000000018A9065C8-0x000000018A906730
		public void ExecuteCommands(bool sendNotifications, bool doSort); // 0x000000018A906BD8-0x000000018A906F80
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, RenderTexture main, ref RenderTexture swap); // 0x000000018A906F80-0x000000018A9075B8
	}

	public abstract class P3dPaintableTextureMonitor : MonoBehaviour // TypeDefIndex: 59710
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
		[CompilerGenerated]
		private Action OnUpdated; // 0x30
		[SerializeField]
		protected P3dPaintableTexture registeredPaintableTexture; // 0x38
		[SerializeField]
		private float cooldown; // 0x40
		[SerializeField]
		private P3dReader currentReader; // 0x48
		[SerializeField]
		protected NativeArray<Color32> currentPixels; // 0x50
	
		// Properties
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018A905E14-0x000000018A905E38
		public float Interval { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public bool Async { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
		public int DownsampleSteps { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public bool Registered { get; } // 0x000000018A905D30-0x000000018A905D80 
		public P3dReader CurrentReader { get; } // 0x0000000184D86200-0x0000000184D86210 
	
		// Events
		public event Action OnUpdated {
			add; // 0x000000018A905C9C-0x000000018A905D30
			remove; // 0x000000018A905D80-0x000000018A905E14
		}
	
		// Constructors
		protected P3dPaintableTextureMonitor(); // 0x000000018A905C7C-0x000000018A905C9C
	
		// Methods
		public void MarkCurrentReaderAsDirty(); // 0x000000018A905760-0x000000018A905770
		[ContextMenu("Register")]
		public void Register(); // 0x000000018A905908-0x000000018A9059E0
		[ContextMenu("Unregister")]
		public void Unregister(); // 0x000000018A9059E0-0x000000018A905AAC
		protected void InvokeOnUpdated(); // 0x000000018A90574C-0x000000018A905760
		protected virtual void OnEnable(); // 0x000000018A90586C-0x000000018A905908
		protected virtual void OnDisable(); // 0x000000018A9057D0-0x000000018A90586C
		protected virtual void OnDestroy(); // 0x000000018A905770-0x000000018A9057D0
		protected virtual void Update(); // 0x000000018A905AAC-0x000000018A905C7C
		private void HandleCompleteCurrent(NativeArray<Color32> pixels); // 0x000000018A905634-0x000000018A905738
		private void HandleModified(bool preview); // 0x000000018A905738-0x000000018A90574C
		protected abstract void HandleComplete(int boost);
	}

	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor // TypeDefIndex: 59711
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
		public Mesh MaskMesh { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public int MaskSubmesh { get; set; } // 0x0000000184D86CF0-0x0000000184D86D00 0x0000000184D86D00-0x0000000184D86D10
		public Texture MaskTexture { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public P3dChannel MaskChannel { get; set; } // 0x0000000184D863C0-0x0000000184D863D0 0x0000000184D86440-0x0000000184D86450
		public int Total { get; } // 0x0000000184D86410-0x0000000184D86420 
		public P3dReader MaskReader { get; } // 0x0000000184D86260-0x0000000184D86270 
	
		// Constructors
		protected P3dPaintableTextureMonitorMask(); // 0x000000018A905624-0x000000018A905634
	
		// Methods
		public void MarkMaskReaderAsDirty(); // 0x000000018A905110-0x000000018A905128
		private void HandleCompleteMask(NativeArray<Color32> pixels); // 0x000000018A904F04-0x000000018A905110
		protected override void OnEnable(); // 0x000000018A905244-0x000000018A9052E8
		protected override void OnDisable(); // 0x000000018A9051A0-0x000000018A905244
		protected override void OnDestroy(); // 0x000000018A905128-0x000000018A9051A0
		protected override void Update(); // 0x000000018A9052E8-0x000000018A905624
	}

	[Serializable]
	public class P3dPointConnector // TypeDefIndex: 59713
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
		public float HitSpacing { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public int HitLimit { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public bool ConnectHits { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool ClipConnected { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public P3dHitCache HitCache { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		private class Link // TypeDefIndex: 59712
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
			public Link(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public P3dPointConnector(); // 0x000000018A90B57C-0x000000018A90B630
		static P3dPointConnector(); // 0x000000018A90B4F0-0x000000018A90B57C
	
		// Methods
		public void ClearHitCache(); // 0x000000018A9001FC-0x000000018A90021C
		public void ResetConnections(); // 0x000000018A90AA8C-0x000000018A90AB74
		public void BreakHits(object owner); // 0x000000018A90A980-0x000000018A90AA8C
		public void SubmitLastPoint(GameObject gameObject, bool preview, object owner); // 0x000000018A90AB74-0x000000018A90ADB8
		public void SubmitPoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner); // 0x000000018A90ADB8-0x000000018A90B30C
		public void Update(); // 0x000000018A90B3C0-0x000000018A90B4F0
		private bool TryGetLink(object owner, ref Link link); // 0x000000018A90B30C-0x000000018A90B3C0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Read Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dReadColor")]
	public class P3dReadColor : MonoBehaviour, IHitCoord // TypeDefIndex: 59715
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
		public P3dGroup Group { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public bool Preview { get; set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
		public UnityEngine.Color Color { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
		public ColorEvent OnColor { get; } // 0x000000018A90B7F8-0x000000018A90B868 
	
		// Nested types
		[Serializable]
		public class ColorEvent : UnityEvent<UnityEngine.Color> // TypeDefIndex: 59714
		{
			// Constructors
			public ColorEvent(); // 0x000000018A8F616C-0x000000018A8F61A8
		}
	
		// Constructors
		public P3dReadColor(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90B630-0x000000018A90B7F8
	}

	[Serializable]
	public class P3dReader // TypeDefIndex: 59716
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
		[CompilerGenerated]
		private Action<NativeArray<Color32>> OnComplete; // 0x50
	
		// Properties
		public bool Dirty { get; } // 0x0000000184D866B0-0x0000000184D866C0 
		public bool Requested { get; } // 0x0000000184D86850-0x0000000184D86860 
		public Vector2Int OriginalSize { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public int DownsampleSteps { get; } // 0x0000000184D865E0-0x0000000184D865F0 
		public Vector2Int DownsampledSize { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public int DownsampleBoost { get; } // 0x0000000184D86530-0x0000000184D86540 
	
		// Events
		public event Action<NativeArray<Color32>> OnComplete {
			add; // 0x000000018A90BFA8-0x000000018A90C034
			remove; // 0x000000018A90C034-0x000000018A90C0C0
		}
	
		// Constructors
		public P3dReader(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void MarkAsDirty(); // 0x0000000184D8F6A0-0x0000000184D8F6B0
		public void UpdateRequest(); // 0x000000018A90BEC8-0x000000018A90BFA8
		public static bool NeedsUpdating<T>(P3dReader reader, NativeArray<T> array, RenderTexture texture, int downsampleSteps)
			where T : struct;
		public void Request(RenderTexture texture, int downsample, bool async); // 0x000000018A90BBF8-0x000000018A90BEC8
		public void Release(); // 0x000000018A90BB58-0x000000018A90BBF8
		private void CompleteDirectly(); // 0x000000018A90B868-0x000000018A90BB58
	}

	public static class P3dSerialization // TypeDefIndex: 59717
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
		static P3dSerialization(); // 0x000000018A90FDC8-0x000000018A910130
	
		// Methods
		public static void TryRegister(P3dPaintableTexture paintableTexture, P3dHash hash); // 0x000000018A90FD4C-0x000000018A90FDC8
		public static void TryRegister(P3dModel model, P3dHash hash); // 0x000000018A90F9D0-0x000000018A90FA58
		public static void TryRegister(Texture texture, P3dHash hash); // 0x000000018A90FCD0-0x000000018A90FD4C
		public static void TryRegister<T>(T obj, P3dHash hash, Dictionary<P3dHash, T> hashToObj, Dictionary<T, P3dHash> objToHash)
			where T : UnityEngine.Object;
		public static int TryRegister(Material material); // 0x000000018A90FA58-0x000000018A90FCD0
		private static int GetStableStringHash(string s); // 0x000000018A90F97C-0x000000018A90F9D0
	}

	[Serializable]
	public struct P3dSlot // TypeDefIndex: 59718
	{
		// Fields
		public int Index; // 0x00
		public string Name; // 0x08
	
		// Constructors
		public P3dSlot(int newIndex, string newName); // 0x0000000186B17430-0x0000000186B17440
	
		// Methods
		public Texture FindTexture(GameObject gameObject); // 0x000000018A910190-0x000000018A9102C0
		public bool IsTransformed(GameObject gameObject); // 0x000000018A9102EC-0x000000018A91049C
		public override bool Equals(object obj); // 0x000000018A910130-0x000000018A910190
		public override int GetHashCode(); // 0x000000018A9102C0-0x000000018A9102EC
		public static bool operator ==(P3dSlot a, P3dSlot b); // 0x000000018A91049C-0x000000018A9104B8
		public static bool operator !=(P3dSlot a, P3dSlot b); // 0x000000018A9104B8-0x000000018A9104D4
	}

	public static class P3dStateManager // TypeDefIndex: 59719
	{
		// Properties
		public static bool CanUndo { get; } // 0x000000018A910B08-0x000000018A910C4C 
		public static bool CanRedo { get; } // 0x000000018A9109C4-0x000000018A910B08 
	
		// Methods
		public static void StoreAllStates(); // 0x000000018A91074C-0x000000018A910888
		public static void ClearAllStates(); // 0x000000018A9104D4-0x000000018A910610
		public static void UndoAll(); // 0x000000018A910888-0x000000018A9109C4
		public static void RedoAll(); // 0x000000018A910610-0x000000018A91074C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Texture Hash")]
	[DefaultExecutionOrder(-200)]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTextureHash")]
	public class P3dTextureHash : MonoBehaviour // TypeDefIndex: 59720
	{
		// Fields
		[SerializeField]
		private Texture texture; // 0x18
		[SerializeField]
		private P3dHash hash; // 0x20
	
		// Properties
		public Texture Texture { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public P3dHash Hash { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018A910CF0-0x000000018A910D80
	
		// Constructors
		public P3dTextureHash(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018A910C9C-0x000000018A910CF0
		protected virtual void OnDestroy(); // 0x000000018A910C4C-0x000000018A910C9C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Decal")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDecal")]
	public class P3dPaintDecal : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 59721
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
		public LayerMask Layers { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public P3dModel TargetModel { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public P3dGroup Group { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public P3dPaintableTexture TargetTexture { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public P3dBlendMode BlendMode { get; set; } // 0x0000000184DA62B0-0x0000000184DA62E0 0x000000018A90D980-0x000000018A90D9AC
		public Texture Texture { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public Texture Shape { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public P3dChannel ShapeChannel { get; set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
		public UnityEngine.Color Color { get; set; } // 0x0000000184DA62E0-0x0000000184DA62F0 0x0000000184DA6310-0x0000000184DA6320
		public float Opacity { get; set; } // 0x0000000184D8F070-0x0000000184D8F080 0x0000000184D8F0A0-0x0000000184D8F0B0
		public float Angle { get; set; } // 0x0000000184D8E570-0x0000000184D8E580 0x0000000184D8E590-0x0000000184D8E5A0
		public Vector3 Scale { get; set; } // 0x0000000184D90DF0-0x0000000184D90E10 0x0000000184D90E50-0x0000000184D90E70
		public float Radius { get; set; } // 0x0000000184D8E650-0x0000000184D8E660 0x0000000184D8E680-0x0000000184D8E690
		public float Hardness { get; set; } // 0x0000000184D8E660-0x0000000184D8E670 0x0000000184D8E690-0x0000000184D8E6A0
		public float Wrapping { get; set; } // 0x0000000184DA6300-0x0000000184DA6310 0x0000000184DA6330-0x0000000184DA6340
		public float NormalFront { get; set; } // 0x0000000184DA32B0-0x0000000184DA32C0 0x0000000184DA3350-0x0000000184DA3360
		public float NormalBack { get; set; } // 0x0000000184DA32D0-0x0000000184DA32E0 0x0000000184D87E30-0x0000000184D87E40
		public float NormalFade { get; set; } // 0x0000000184DA62F0-0x0000000184DA6300 0x0000000184DA6320-0x0000000184DA6330
		public Texture TileTexture { get; set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		public Transform TileTransform { get; set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x0000000186AC5B30-0x0000000186AC5B44
		public float TileOpacity { get; set; } // 0x0000000184D8E2E0-0x0000000184D8E2F0 0x0000000184D8E320-0x0000000184D8E330
		public float TileTransition { get; set; } // 0x0000000184D8E2C0-0x0000000184D8E2D0 0x0000000184D8E300-0x0000000184D8E310
		public P3dModifierList Modifiers { get; } // 0x000000018A90D918-0x000000018A90D980 
	
		// Constructors
		public P3dPaintDecal(); // 0x000000018A90D7F0-0x000000018A90D918
	
		// Methods
		[ContextMenu("Flip Horizontal")]
		public void FlipHorizontal(); // 0x0000000184DA6250-0x0000000184DA6270
		[ContextMenu("Flip Vertical")]
		public void FlipVertical(); // 0x0000000184DA6270-0x0000000184DA6290
		public void IncrementOpacity(float delta); // 0x000000018A90D77C-0x000000018A90D7A0
		public void IncrementAngle(float degrees); // 0x000000018A90D73C-0x000000018A90D77C
		public void MultiplyScale(float multiplier); // 0x000000018A90D7A0-0x000000018A90D7F0
		public void MultiplyHardness(float multiplier); // 0x0000000184DA6290-0x0000000184DA62B0
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018A90CDA8-0x000000018A90D010
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018A90CB40-0x000000018A90CDA8
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018A90D30C-0x000000018A90D5AC
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018A90D010-0x000000018A90D30C
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90C7C0-0x000000018A90CB40
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation); // 0x000000018A90C2E8-0x000000018A90C7C0
		private void HandleMaskCommon(Vector3 worldPosition); // 0x000000018A90D5AC-0x000000018A90D73C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintFill")]
	public class P3dPaintFill : MonoBehaviour, IHitCoord // TypeDefIndex: 59722
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
		public P3dGroup Group { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public P3dBlendMode BlendMode { get; set; } // 0x0000000184DA6340-0x0000000184DA6370 0x000000018A90DDEC-0x000000018A90DE18
		public Texture Texture { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public UnityEngine.Color Color { get; set; } // 0x0000000184DA1280-0x0000000184DA1290 0x0000000184DA1330-0x0000000184DA1340
		public float Opacity { get; set; } // 0x0000000184D90610-0x0000000184D90620 0x0000000184D90600-0x0000000184D90610
		public float Minimum { get; set; } // 0x0000000184DA60B0-0x0000000184DA60C0 0x0000000184DA60C0-0x0000000184DA60D0
		public P3dModifierList Modifiers { get; } // 0x000000018A90DD90-0x000000018A90DDEC 
	
		// Constructors
		public P3dPaintFill(); // 0x000000018A90DCD4-0x000000018A90DD90
	
		// Methods
		public void IncrementOpacity(float delta); // 0x000000018A90DCB8-0x000000018A90DCD4
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90D9AC-0x000000018A90DCB8
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplace")]
	public class P3dPaintReplace : MonoBehaviour, IHitCoord // TypeDefIndex: 59723
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
		public P3dGroup Group { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public Texture Texture { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public UnityEngine.Color Color { get; set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
		public P3dModifierList Modifiers { get; } // 0x000000018A90E36C-0x000000018A90E3C8 
	
		// Constructors
		public P3dPaintReplace(); // 0x000000018A90E334-0x000000018A90E36C
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90E094-0x000000018A90E334
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace Channels")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplaceChannels")]
	public class P3dPaintReplaceChannels : MonoBehaviour, IHitCoord // TypeDefIndex: 59724
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
		public P3dGroup Group { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public Texture TextureR { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Texture TextureG { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public Texture TextureB { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public Texture TextureA { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public Vector4 ChannelR { get; set; } // 0x0000000184D905C0-0x0000000184D905D0 0x0000000184D926F0-0x0000000184D92700
		public Vector4 ChannelG { get; set; } // 0x0000000184D8CE10-0x0000000184D8CE20 0x0000000184D926F0-0x0000000184D92700
		public Vector4 ChannelB { get; set; } // 0x0000000184DA1280-0x0000000184DA1290 0x0000000184D926F0-0x0000000184D92700
		public Vector4 ChannelA { get; set; } // 0x0000000184D8FD40-0x0000000184D8FD50 0x0000000184D926F0-0x0000000184D92700
	
		// Constructors
		public P3dPaintReplaceChannels(); // 0x000000018A90E064-0x000000018A90E094
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90DE18-0x000000018A90E064
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Sphere")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintSphere")]
	public class P3dPaintSphere : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 59725
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
		public LayerMask Layers { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public P3dGroup Group { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public P3dModel TargetModel { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public P3dPaintableTexture TargetTexture { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public P3dBlendMode BlendMode { get; set; } // 0x0000000184DA6390-0x0000000184DA63C0 0x000000018A90F950-0x000000018A90F97C
		public UnityEngine.Color Color { get; set; } // 0x0000000184DA63C0-0x0000000184DA63D0 0x0000000184DA63D0-0x0000000184DA63E0
		public float Opacity { get; set; } // 0x0000000184D8ED60-0x0000000184D8ED70 0x0000000184D8ED70-0x0000000184D8ED80
		public float Angle { get; set; } // 0x0000000184D88E80-0x0000000184D88E90 0x0000000184D8ED80-0x0000000184D8ED90
		public Vector3 Scale { get; set; } // 0x0000000184D91900-0x0000000184D91920 0x0000000184D91970-0x0000000184D91990
		public float Radius { get; set; } // 0x0000000184D8E210-0x0000000184D8E220 0x0000000184D8E230-0x0000000184D8E240
		public float Hardness { get; set; } // 0x0000000184D8FD30-0x0000000184D8FD40 0x0000000184D8FD60-0x0000000184D8FD70
		public Texture TileTexture { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public Transform TileTransform { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public float TileOpacity { get; set; } // 0x0000000184D8E650-0x0000000184D8E660 0x0000000184D8E680-0x0000000184D8E690
		public float TileTransition { get; set; } // 0x0000000184D8E660-0x0000000184D8E670 0x0000000184D8E690-0x0000000184D8E6A0
		public P3dModifierList Modifiers { get; } // 0x000000018A90F8E8-0x000000018A90F950 
	
		// Constructors
		public P3dPaintSphere(); // 0x000000018A90F7E4-0x000000018A90F8E8
	
		// Methods
		public void IncrementOpacity(float delta); // 0x000000018A90F778-0x000000018A90F794
		public void IncrementAngle(float degrees); // 0x000000018A90F73C-0x000000018A90F778
		public void MultiplyRadius(float multiplier); // 0x0000000184DA6370-0x0000000184DA6390
		public void MultiplyScale(float multiplier); // 0x000000018A90F794-0x000000018A90F7E4
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018A90EDA8-0x000000018A90F010
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018A90EB40-0x000000018A90EDA8
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018A90F30C-0x000000018A90F5AC
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018A90F010-0x000000018A90F30C
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018A90E7C0-0x000000018A90EB40
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation); // 0x000000018A90E3C8-0x000000018A90E7C0
		private void HandleMaskCommon(Vector3 worldPosition); // 0x000000018A90F5AC-0x000000018A90F73C
	}
}
