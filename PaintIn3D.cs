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

// Image 44: PaintIn3D.dll - Assembly: PaintIn3D, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 86629-86792

namespace PaintIn3D
{
	[AddComponentMenu("Paint in 3D/P3D Button Clear All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonClearAll")]
	public class P3dButtonClearAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 86630
	{
		// Fields
		[SerializeField]
		private bool clearStates; // 0x18
	
		// Properties
		public bool ClearStates { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Constructors
		public P3dButtonClearAll(); // 0x0000000187836ABC-0x0000000187836AD8
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018CA96B14-0x000000018CA96B1C
		[ContextMenu("Clear All")]
		public void ClearAll(); // 0x000000018CA9698C-0x000000018CA96B14
	}

	[AddComponentMenu("Paint in 3D/P3D Button Redo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonRedoAll")]
	public class P3dButtonRedoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 86631
	{
		// Constructors
		public P3dButtonRedoAll(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018CA96B1C-0x000000018CA96B24
		[ContextMenu("Redo All")]
		public void RedoAll(); // 0x000000018CA96B1C-0x000000018CA96B24
		protected virtual void Update(); // 0x000000018CA96B24-0x000000018CA96BC0
	}

	[AddComponentMenu("Paint in 3D/P3D Button Undo All")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dButtonUndoAll")]
	public class P3dButtonUndoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 86632
	{
		// Constructors
		public P3dButtonUndoAll(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018CA96BC0-0x000000018CA96BC8
		[ContextMenu("Undo All")]
		public void UndoAll(); // 0x000000018CA96BC0-0x000000018CA96BC8
		protected virtual void Update(); // 0x000000018CA96BC8-0x000000018CA96C64
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterEvent")]
	public class P3dChangeCounterEvent : MonoBehaviour // TypeDefIndex: 86633
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
		public List<P3dChangeCounter> Counters { get; } // 0x000000018CA96D1C-0x000000018CA96DA0 
		public Vector2 Range { get; set; } // 0x0000000187253AE0-0x0000000187253B00 0x000000018561BB30-0x000000018561BB40
		public bool Inside { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public UnityEvent OnInside { get; } // 0x000000018CA96DA0-0x000000018CA96E10 
		public UnityEvent OnOutside { get; } // 0x000000018CA96E10-0x000000018CA96E80 
		public float Ratio { get; } // 0x000000018CA96E80-0x000000018CA96EE8 
	
		// Constructors
		public P3dChangeCounterEvent(); // 0x000000018CA96CF8-0x000000018CA96D1C
	
		// Methods
		protected virtual void Update(); // 0x000000018CA96CD4-0x000000018CA96CF8
		private void UpdateInside(float ratio); // 0x000000018CA96C64-0x000000018CA96CD4
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChangeCounterFill : MonoBehaviour // TypeDefIndex: 86634
	{
		// Fields
		[SerializeField]
		private List<P3dChangeCounter> counters; // 0x18
		[SerializeField]
		private bool inverse; // 0x20
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChangeCounter> Counters { get; } // 0x000000018CA96FD0-0x000000018CA97054 
		public bool Inverse { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public P3dChangeCounterFill(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CA96EE8-0x000000018CA96F30
		protected virtual void Update(); // 0x000000018CA96F30-0x000000018CA96FD0
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounterText")]
	public class P3dChangeCounterText : MonoBehaviour // TypeDefIndex: 86636
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
		public List<P3dChangeCounter> Counters { get; } // 0x000000018CA9727C-0x000000018CA97300 
		public bool Inverse { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public int DecimalPlaces { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public string Format { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public StringEvent OnString { get; } // 0x000000018CA97300-0x000000018CA97370 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 86635
		{
			// Constructors
			public StringEvent(); // 0x000000018CAA894C-0x000000018CAA8A28
		}
	
		// Constructors
		public P3dChangeCounterText(); // 0x000000018CA97220-0x000000018CA9727C
	
		// Methods
		protected virtual void Update(); // 0x000000018CA97054-0x000000018CA97220
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterEvent")]
	public class P3dChannelCounterEvent : MonoBehaviour // TypeDefIndex: 86638
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018CA97428-0x000000018CA974AC 
		public ChannelType Channel { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public Vector2 Range { get; set; } // 0x0000000187235030-0x0000000187235050 0x0000000187253B00-0x0000000187253B10
		public bool Inside { get; set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
		public UnityEvent OnInside { get; } // 0x000000018CA974AC-0x000000018CA9751C 
		public UnityEvent OnOutside { get; } // 0x000000018CA9751C-0x000000018CA9758C 
		public float Ratio { get; } // 0x000000018CA9758C-0x000000018CA97660 
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 86637
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterEvent(); // 0x000000018CA97404-0x000000018CA97428
	
		// Methods
		protected virtual void Update(); // 0x000000018CA973E0-0x000000018CA97404
		private void UpdateInside(float ratio); // 0x000000018CA97370-0x000000018CA973E0
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dChannelCounterFill : MonoBehaviour // TypeDefIndex: 86640
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018CA977B4-0x000000018CA97838 
		public ChannelType Channel { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public bool Inverse { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 86639
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterFill(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CA97660-0x000000018CA976A8
		protected virtual void Update(); // 0x000000018CA976A8-0x000000018CA977B4
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounterText")]
	public class P3dChannelCounterText : MonoBehaviour // TypeDefIndex: 86643
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
		public List<P3dChannelCounter> Counters { get; } // 0x000000018CA97AD0-0x000000018CA97B54 
		public ChannelType Channel { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public bool Inverse { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
		public int DecimalPlaces { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public string Format { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public StringEvent OnString { get; } // 0x000000018CA97B54-0x000000018CA97BC4 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 86641
		{
			// Constructors
			public StringEvent(); // 0x000000018CAA8910-0x000000018CAA894C
		}
	
		public enum ChannelType // TypeDefIndex: 86642
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterText(); // 0x000000018CA97A74-0x000000018CA97AD0
	
		// Methods
		protected virtual void Update(); // 0x000000018CA97838-0x000000018CA97A74
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Event")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterEvent")]
	public class P3dColorCounterEvent : MonoBehaviour // TypeDefIndex: 86644
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018CA97C7C-0x000000018CA97D00 
		public P3dColor Color { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Vector2 Range { get; set; } // 0x000000018724C770-0x000000018724C790 0x000000018561BB40-0x000000018561BB50
		public bool Inside { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public UnityEvent OnInside { get; } // 0x000000018CA97D00-0x000000018CA97D70 
		public UnityEvent OnOutside { get; } // 0x000000018CA97D70-0x000000018CA97DE0 
		public float Ratio { get; } // 0x000000018CA97DE0-0x000000018CA97E54 
	
		// Constructors
		public P3dColorCounterEvent(); // 0x000000018CA97C58-0x000000018CA97C7C
	
		// Methods
		protected virtual void Update(); // 0x000000018CA97C34-0x000000018CA97C58
		private void UpdateInside(float ratio); // 0x000000018CA97BC4-0x000000018CA97C34
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterFill")]
	[RequireComponent(typeof(Image))]
	public class P3dColorCounterFill : MonoBehaviour // TypeDefIndex: 86645
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018CA97F50-0x000000018CA97FD4 
		public P3dColor Color { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool Inverse { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
	
		// Constructors
		public P3dColorCounterFill(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CA97E54-0x000000018CA97E9C
		protected virtual void Update(); // 0x000000018CA97E9C-0x000000018CA97F50
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter Text")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounterText")]
	public class P3dColorCounterText : MonoBehaviour // TypeDefIndex: 86647
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
		public List<P3dColorCounter> Counters { get; } // 0x000000018CA98200-0x000000018CA98284 
		public P3dColor Color { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool Inverse { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public int DecimalPlaces { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public string Format { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public StringEvent OnString { get; } // 0x000000018CA98284-0x000000018CA982F4 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 86646
		{
			// Constructors
			public StringEvent(); // 0x000000018CAA88D4-0x000000018CAA8910
		}
	
		// Constructors
		public P3dColorCounterText(); // 0x000000018CA981A4-0x000000018CA98200
	
		// Methods
		protected virtual void Update(); // 0x000000018CA97FD4-0x000000018CA981A4
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Debug")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDebug")]
	public class P3dPaintDebug : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad // TypeDefIndex: 86648
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private float duration; // 0x28
		[SerializeField]
		private float size; // 0x2C
	
		// Properties
		public UnityEngine.Color Color { get; set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
		public float Duration { get; set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public float Size { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
	
		// Constructors
		public P3dPaintDebug(); // 0x000000018CAA4F8C-0x000000018CAA4FD0
	
		// Methods
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018CAA4958-0x000000018CAA4B08
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018CAA4830-0x000000018CAA4958
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018CAA4D54-0x000000018CAA4F8C
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018CAA4B08-0x000000018CAA4D54
		private UnityEngine.Color GetColor(bool preview, float pressure, UnityEngine.Color color); // 0x000000018CAA47EC-0x000000018CAA4830
		private void DrawArrow(Vector3 position, Quaternion rotation, UnityEngine.Color tint); // 0x000000018CAA4318-0x000000018CAA47EC
	}

	public class P3dCommandDecal : P3dCommand // TypeDefIndex: 86649
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
		public override bool RequireMesh { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		static P3dCommandDecal(); // 0x000000018CA99830-0x000000018CA99EA8
		public P3dCommandDecal(); // 0x000000018CA99EA8-0x000000018CA99EE8
	
		// Methods
		public override void Apply(Material material); // 0x000000018CA98414-0x000000018CA98B9C
		public override void Pool(); // 0x000000018CA98C08-0x000000018CA98C78
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x000000018CA99600-0x000000018CA99830
		public override P3dCommand SpawnCopy(); // 0x000000018CA99298-0x000000018CA99600
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018CA983B8-0x000000018CA98414
		public void SetShape(Quaternion rotation, Vector3 size, float angle); // 0x000000018CA99110-0x000000018CA99298
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x02645B50 */); // 0x0000000187253B90-0x0000000187253BC0
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x02645B51 */, bool clip = false /* Metadata: 0x02645B52 */); // 0x0000000187253BC0-0x0000000187253C10
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x02645B53 */); // 0x0000000187253B10-0x0000000187253B90
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x02645B54 */, bool clip = false /* Metadata: 0x02645B55 */); // 0x0000000187253C10-0x0000000187253C90
		public void ClearMask(); // 0x000000018CA98B9C-0x000000018CA98C08
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch); // 0x000000018CA98C78-0x000000018CA98D74
		public void ApplyAspect(Texture texture); // 0x000000018CA982F4-0x000000018CA983B8
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition); // 0x000000018CA98D74-0x000000018CA99110
	}

	public class P3dCommandFill : P3dCommand // TypeDefIndex: 86650
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
		public override bool RequireMesh { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		static P3dCommandFill(); // 0x000000018CA9A718-0x000000018CA9A954
		public P3dCommandFill(); // 0x000000018CA9A954-0x000000018CA9A994
	
		// Methods
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018CA9A2E0-0x000000018CA9A44C
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018CA9A090-0x000000018CA9A2E0
		public override void Apply(Material material); // 0x000000018CA99EE8-0x000000018CA9A090
		public override void Pool(); // 0x000000018CA9A44C-0x000000018CA9A4BC
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x0000000186805BA0-0x0000000186805BB0
		public override P3dCommand SpawnCopy(); // 0x000000018CA9A61C-0x000000018CA9A718
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018CA983B8-0x000000018CA98414
		public Material SetMaterial(P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum); // 0x000000018CA9A4BC-0x000000018CA9A61C
	}

	public class P3dCommandReplace : P3dCommand // TypeDefIndex: 86651
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
		public override bool RequireMesh { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		static P3dCommandReplace(); // 0x000000018CA9B918-0x000000018CA9BAA4
		public P3dCommandReplace(); // 0x000000018CA9BAA4-0x000000018CA9BAE4
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint); // 0x000000018CA9B654-0x000000018CA9B744
		public static void BlitFast(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint); // 0x000000018CA9B580-0x000000018CA9B654
		public override void Apply(Material material); // 0x000000018CA9B474-0x000000018CA9B580
		public override void Pool(); // 0x000000018CA9B744-0x000000018CA9B7B4
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x0000000186805BA0-0x0000000186805BB0
		public override P3dCommand SpawnCopy(); // 0x000000018CA9B880-0x000000018CA9B918
		public Material SetMaterial(Texture texture, UnityEngine.Color color); // 0x000000018CA9B7B4-0x000000018CA9B880
	}

	public class P3dCommandReplaceChannels : P3dCommand // TypeDefIndex: 86652
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
		public override bool RequireMesh { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		static P3dCommandReplaceChannels(); // 0x000000018CA9B1A0-0x000000018CA9B434
		public P3dCommandReplaceChannels(); // 0x000000018CA9B434-0x000000018CA9B474
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA, Vector4 channels); // 0x000000018CA9ACFC-0x000000018CA9AE80
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA); // 0x000000018CA9AB94-0x000000018CA9ACFC
		public override void Apply(Material material); // 0x000000018CA9A994-0x000000018CA9AB94
		public override void Pool(); // 0x000000018CA9AE80-0x000000018CA9AEF0
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x0000000186805BA0-0x0000000186805BB0
		public override P3dCommand SpawnCopy(); // 0x000000018CA9B080-0x000000018CA9B1A0
		public Material SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA); // 0x000000018CA9AEF0-0x000000018CA9B080
	}

	public class P3dCommandSphere : P3dCommand // TypeDefIndex: 86653
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
		public override bool RequireMesh { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		static P3dCommandSphere(); // 0x000000018CA9CC1C-0x000000018CA9D150
		public P3dCommandSphere(); // 0x000000018CA9D150-0x000000018CA9D190
	
		// Methods
		public override void Apply(Material material); // 0x000000018CA9BBA8-0x000000018CA9C170
		public override void Pool(); // 0x000000018CA9C1DC-0x000000018CA9C24C
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix); // 0x000000018CA9CA54-0x000000018CA9CC1C
		public override P3dCommand SpawnCopy(); // 0x000000018CA9C79C-0x000000018CA9CA54
		public override void Apply(P3dPaintableTexture paintableTexture); // 0x000000018CA983B8-0x000000018CA98414
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x02645B56 */); // 0x0000000187253B90-0x0000000187253BC0
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x02645B57 */, bool clip = false /* Metadata: 0x02645B58 */); // 0x0000000187253BC0-0x0000000187253C10
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x02645B59 */); // 0x0000000187253B10-0x0000000187253B90
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x02645B5A */, bool clip = false /* Metadata: 0x02645B5B */); // 0x0000000187253C10-0x0000000187253C90
		public void ClearMask(); // 0x000000018CA9C170-0x000000018CA9C1DC
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch); // 0x000000018CA9C24C-0x000000018CA9C348
		public void ApplyAspect(Texture texture); // 0x000000018CA9BAE4-0x000000018CA9BBA8
		public void SetShape(float radius); // 0x000000018CA9C6CC-0x000000018CA9C79C
		public void SetShape(Quaternion rotation, Vector3 size, float angle); // 0x000000018CA9C58C-0x000000018CA9C6CC
		public void SetMaterial(P3dBlendMode blendMode, float hardness, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition); // 0x000000018CA9C348-0x000000018CA9C58C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Between")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitBetween")]
	public class P3dHitBetween : MonoBehaviour // TypeDefIndex: 86658
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
		public PhaseType PaintIn { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float Interval { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public Transform PointA { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Transform PointB { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public float Fraction { get; } // 0x0000000187233870-0x0000000187233880 
		public LayerMask Layers { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public OrientationType Orientation { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public Camera Camera { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public Transform CustomTransform { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public NormalType Normal { get; set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public float Offset { get; set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
		public bool Preview { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
		public int Priority { get; set; } // 0x0000000187233600-0x0000000187233610 0x0000000187233630-0x0000000187233640
		public float Pressure { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
		public EmitType Draw { get; set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
		public Transform Point { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public LineRenderer Line { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public P3dPointConnector Connector { get; } // 0x000000018CA9DE58-0x000000018CA9DEC8 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 86654
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 86655
		{
			WorldUp = 0,
			CameraUp = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum NormalType // TypeDefIndex: 86656
		{
			HitNormal = 0,
			RayDirection = 1
		}
	
		public enum EmitType // TypeDefIndex: 86657
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		// Constructors
		public P3dHitBetween(); // 0x000000018CA9DE24-0x000000018CA9DE58
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018CA9D444-0x000000018CA9D450
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CA9D404-0x000000018CA9D428
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018CA9D538-0x000000018CA9D558
		protected virtual void OnEnable(); // 0x000000018CA9D514-0x000000018CA9D538
		protected virtual void OnDisable(); // 0x000000018CA9D450-0x000000018CA9D514
		protected virtual void Update(); // 0x000000018CA9DDD4-0x000000018CA9DE24
		protected virtual void LateUpdate(); // 0x000000018CA9D43C-0x000000018CA9D444
		protected virtual void FixedUpdate(); // 0x000000018CA9D428-0x000000018CA9D43C
		private void SubmitHit(bool preview); // 0x000000018CA9D558-0x000000018CA9DB78
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, out Vector3 finalPosition, out Quaternion finalRotation); // 0x000000018CA9D190-0x000000018CA9D404
		private void UpdatePointAndLine(); // 0x000000018CA9DBE8-0x000000018CA9DDD4
		private void UpdateHit(); // 0x000000018CA9DB78-0x000000018CA9DBE8
	}

	public class P3dHitCache // TypeDefIndex: 86659
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
		public bool Cached { get; } // 0x00000001829D0800-0x00000001829D0810 
	
		// Constructors
		public P3dHitCache(); // 0x000000018CA9EB68-0x000000018CA9ED0C
		static P3dHitCache(); // 0x000000018CA9EADC-0x000000018CA9EB68
	
		// Methods
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation); // 0x000000018CA9E54C-0x000000018CA9E670
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018CA9E3EC-0x000000018CA9E54C
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation); // 0x000000018CA9E984-0x000000018CA9EADC
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018CA9E7FC-0x000000018CA9E984
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018CA9E670-0x000000018CA9E7FC
		public void InvokeCoord(GameObject gameObject, bool preview, int priority, float pressure, P3dHit hit, Quaternion rotation); // 0x000000018CA9E2C0-0x000000018CA9E3EC
		public void Clear(); // 0x000000018CA9E1F0-0x000000018CA9E2C0
		private void Cache(GameObject gameObject); // 0x000000018CA9DEC8-0x000000018CA9E1F0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Collisions")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitCollisions")]
	public class P3dHitCollisions : MonoBehaviour // TypeDefIndex: 86663
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
		public EmitType Emit { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float RaycastDistance { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public LayerMask Layers { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public bool OnlyUseFirstContact { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
		public float Delay { get; set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public OrientationType Orientation { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public Camera Camera { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool Preview { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public float Threshold { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x0000000187233110-0x0000000187233120
		public PressureType PressureMode { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public float PressureMin { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public float PressureMax { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public float PressureConstant { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public float PressureMultiplier { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public float Offset { get; set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
		public int Priority { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public GameObject Root { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x000000018CA9F4DC-0x000000018CA9F50C
		public P3dHitCache HitCache { get; } // 0x0000000187232FC0-0x0000000187232FD0 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 86660
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 86661
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum PressureType // TypeDefIndex: 86662
		{
			Constant = 0,
			ImpactSpeed = 1
		}
	
		// Constructors
		public P3dHitCollisions(); // 0x000000018CA9F438-0x000000018CA9F4DC
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CA9F294-0x000000018CA9F2B4
		protected virtual void OnCollisionEnter(UnityEngine.Collision collision); // 0x000000018CA9F2B4-0x000000018CA9F2BC
		protected virtual void OnCollisionStay(UnityEngine.Collision collision); // 0x000000018CA9F2B4-0x000000018CA9F2BC
		protected virtual void Update(); // 0x000000018CA9F408-0x000000018CA9F438
		private bool TryGetRaycastHit(ContactPoint contact, ref RaycastHit hit); // 0x000000018CA9F2BC-0x000000018CA9F408
		private void CheckCollision(UnityEngine.Collision collision); // 0x000000018CA9ED0C-0x000000018CA9F294
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Nearby")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitNearby")]
	public class P3dHitNearby : MonoBehaviour // TypeDefIndex: 86665
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
		public PhaseType PaintIn { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float Interval { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public bool Preview { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public int Priority { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public float Pressure { get; set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public P3dPointConnector Connector { get; } // 0x000000018CA9F788-0x000000018CA9F7F8 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 86664
		{
			ManuallyOnly = -1,
			Update = 0,
			FixedUpdate = 1
		}
	
		// Constructors
		public P3dHitNearby(); // 0x000000018CA9F764-0x000000018CA9F788
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018CA9F544-0x000000018CA9F550
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CA9F50C-0x000000018CA9F530
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018CA9F574-0x000000018CA9F594
		protected virtual void OnEnable(); // 0x000000018CA9F550-0x000000018CA9F574
		protected virtual void Update(); // 0x000000018CA9F714-0x000000018CA9F764
		protected virtual void FixedUpdate(); // 0x000000018CA9F530-0x000000018CA9F544
		private void SubmitHit(bool preview); // 0x000000018CA9F594-0x000000018CA9F6A4
		private void UpdateHit(); // 0x000000018CA9F6A4-0x000000018CA9F714
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Particles")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitParticles")]
	[RequireComponent(typeof(ParticleSystem))]
	public class P3dHitParticles : MonoBehaviour // TypeDefIndex: 86670
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
		public EmitType Emit { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float RaycastDistance { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public LayerMask Layers { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public OrientationType Orientation { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public Camera Camera { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public NormalType Normal { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public float Offset { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
		public int Skip { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public bool Preview { get; set; } // 0x000000018226ECA0-0x000000018226ECB0 0x000000018226ECB0-0x000000018226ECC0
		public int Priority { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public PressureType PressureMode { get; set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public float PressureMin { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public float PressureMax { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public float PressureConstant { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public float PressureMultiplier { get; set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
		public GameObject Root { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x000000018CAA02BC-0x000000018CAA02EC
		public P3dHitCache HitCache { get; } // 0x0000000187232FC0-0x0000000187232FD0 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 86666
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 86667
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum NormalType // TypeDefIndex: 86668
		{
			ParticleVelocity = 0,
			CollisionNormal = 1
		}
	
		public enum PressureType // TypeDefIndex: 86669
		{
			Constant = 0,
			Distance = 1,
			Speed = 2
		}
	
		// Constructors
		public P3dHitParticles(); // 0x000000018CAA0234-0x000000018CAA02BC
		static P3dHitParticles(); // 0x000000018CAA01A8-0x000000018CAA0234
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CA9F294-0x000000018CA9F2B4
		private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit); // 0x000000018CA9FFF0-0x000000018CAA01A8
		protected virtual void OnParticleCollision(GameObject hitGameObject); // 0x000000018CA9F7F8-0x000000018CA9FFF0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreen")]
	public class P3dHitScreen : P3dHitScreenBase // TypeDefIndex: 86673
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
		public FrequencyType Frequency { get; set; } // 0x0000000187233370-0x0000000187233380 0x00000001872333D0-0x00000001872333E0
		public float Interval { get; set; } // 0x0000000187253CF0-0x0000000187253D00 0x0000000187253D00-0x0000000187253D10
		public P3dPointConnector Connector { get; } // 0x000000018CAA2E58-0x000000018CAA2EC8 
	
		// Nested types
		protected class Link : CwInputManager.Link // TypeDefIndex: 86671
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
			public Link(); // 0x000000018CA95D5C-0x000000018CA95DD4
	
			// Methods
			public void Move(Vector2 screenNew); // 0x000000018CA95C98-0x000000018CA95CD0
			private bool TryMove(Vector2 screenNew); // 0x000000018CA95CD0-0x000000018CA95D5C
			public override void Clear(); // 0x000000018CA95C30-0x000000018CA95C98
		}
	
		public enum FrequencyType // TypeDefIndex: 86672
		{
			PixelInterval = 0,
			ScaledPixelInterval = 1,
			TimeInterval = 2,
			OnceOnRelease = 3,
			OnceOnPress = 4,
			OnceEveryFrame = 5
		}
	
		// Constructors
		public P3dHitScreen(); // 0x000000018CAA2DC4-0x000000018CAA2E58
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CAA22B8-0x000000018CAA22DC
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018CA9D538-0x000000018CA9D558
		protected override void OnEnable(); // 0x000000018CAA25D0-0x000000018CAA2738
		protected virtual void Update(); // 0x000000018CAA2DA4-0x000000018CAA2DC4
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x000000018CAA23AC-0x000000018CAA25C8
		protected override void HandleFingerUp(CwInputManager.Finger finger); // 0x000000018CAA22DC-0x000000018CAA23AC
		private void PaintSmooth(Link link, bool down, float pixelSpacing); // 0x000000018CAA29E8-0x000000018CAA2CCC
		protected virtual void OnFingerUp(Link link); // 0x0000000186805BA0-0x0000000186805BB0
		private void PaintInterval(Link link, bool down); // 0x000000018CAA27C8-0x000000018CAA28B4
		private void PaintRelease(Link link, bool up); // 0x000000018CAA2948-0x000000018CAA29E8
		private void PaintPress(Link link, bool down); // 0x000000018CAA28B4-0x000000018CAA2948
		private void PaintEvery(Link link, bool down); // 0x000000018CAA2738-0x000000018CAA27C8
		private void RecordAndPaintAt(Link link, Vector2 screenNew, Vector2 screenOld, bool preview, float pressure, object owner); // 0x000000018CAA2CCC-0x000000018CAA2DA4
	}

	public abstract class P3dHitScreenBase : MonoBehaviour // TypeDefIndex: 86679
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
		public Camera Camera { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public LayerMask Layers { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public ButtonTypes RequiredButtons { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public KeyCode RequiredKey { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public LayerMask GuiLayers { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public EmitType Emit { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public RotationType RotateTo { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public DirectionType NormalDirection { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public RelativeType NormalRelativeTo { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public Transform CustomTransform { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public float NormalOffset { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public float MouseOffset { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public float TouchOffset { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public bool StoreStates { get; set; } // 0x0000000182271C80-0x0000000182271C90 0x0000000182271C90-0x0000000182271CA0
		public bool ShowPreview { get; set; } // 0x00000001872335B0-0x00000001872335C0 0x00000001872335C0-0x00000001872335D0
		public int Priority { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public bool NeedsDrawAngle { get; } // 0x000000018CAA150C-0x000000018CAA1520 
	
		// Nested types
		public enum RotationType // TypeDefIndex: 86674
		{
			Normal = 0,
			World = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum RelativeType // TypeDefIndex: 86675
		{
			WorldUp = 0,
			CameraUp = 1,
			DrawAngle = 2
		}
	
		public enum DirectionType // TypeDefIndex: 86676
		{
			HitNormal = 0,
			RayDirection = 1,
			CameraDirection = 2
		}
	
		public enum EmitType // TypeDefIndex: 86677
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		[Flags]
		public enum ButtonTypes // TypeDefIndex: 86678
		{
			LeftMouse = 1,
			RightMouse = 2,
			MiddleMouse = 4,
			Touch = 32
		}
	
		// Constructors
		protected P3dHitScreenBase(); // 0x000000018CAA1468-0x000000018CAA150C
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CAA0D34-0x000000018CAA0EF8
		protected virtual void LateUpdate(); // 0x000000018CAA0A64-0x000000018CAA0C80
		protected virtual void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void HandleFingerUp(CwInputManager.Finger finger); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDisable(); // 0x000000018CAA0C80-0x000000018CAA0D34
		private bool FingerWentDown(CwInputManager.Finger finger); // 0x000000018CAA08B8-0x000000018CAA0994
		private void HandleFingerDown(CwInputManager.Finger finger); // 0x000000018CAA0994-0x000000018CAA0A64
		protected virtual void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D); // 0x000000018CAA0738-0x000000018CAA08B8
		protected void PaintAt(P3dPointConnector connector, P3dHitCache hitCache, Vector2 screenPosition, Vector2 screenPositionOld, bool preview, float pressure, object owner); // 0x000000018CAA0EF8-0x000000018CAA1468
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, Camera camera, Vector2 screenPositionOld, ref Vector3 finalPosition, ref Quaternion finalRotation); // 0x000000018CAA02EC-0x000000018CAA0738
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenFill")]
	public class P3dHitScreenFill : P3dHitScreen // TypeDefIndex: 86680
	{
		// Fields
		[SerializeField]
		private float fillSpacing; // 0x88
	
		// Properties
		public float FillSpacing { get; set; } // 0x000000018723B540-0x000000018723B550 0x000000018723B570-0x000000018723B580
	
		// Constructors
		public P3dHitScreenFill(); // 0x000000018CAA1BF0-0x000000018CAA1C04
	
		// Methods
		protected override void OnFingerUp(Link link); // 0x000000018CAA1914-0x000000018CAA1BF0
		private static Rect GetArea(List<Vector2> points); // 0x000000018CAA16C4-0x000000018CAA1914
		private static double LineSide(Vector2 a, Vector2 b, Vector2 p); // 0x0000000187253C90-0x0000000187253CF0
		private static bool Contains(List<Vector2> points, Vector2 xy); // 0x000000018CAA1520-0x000000018CAA16C4
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Screen Line")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitScreenLine")]
	public class P3dHitScreenLine : P3dHitScreenBase // TypeDefIndex: 86682
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
		public FrequencyType Frequency { get; set; } // 0x0000000187233370-0x0000000187233380 0x00000001872333D0-0x00000001872333E0
		public float Interval { get; set; } // 0x0000000187253CF0-0x0000000187253D00 0x0000000187253D00-0x0000000187253D10
		public float Position { get; set; } // 0x000000018723C6E0-0x000000018723C6F0 0x000000018723C710-0x000000018723C720
		public float PixelOffset { get; set; } // 0x0000000187235DD0-0x0000000187235DE0 0x000000018723C730-0x000000018723C740
		public P3dPointConnector Connector { get; } // 0x000000018CAA223C-0x000000018CAA22B8 
	
		// Nested types
		public enum FrequencyType // TypeDefIndex: 86681
		{
			StartAndEnd = 0,
			PixelInterval = 1,
			ScaledPixelInterval = 2,
			StretchedPixelInterval = 3,
			StretchedScaledPixelInterval = 4,
			Once = 5
		}
	
		// Constructors
		public P3dHitScreenLine(); // 0x000000018CAA2224-0x000000018CAA223C
	
		// Methods
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CAA1C04-0x000000018CAA1C28
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018CAA21DC-0x000000018CAA2200
		protected override void OnEnable(); // 0x000000018CAA1DB0-0x000000018CAA1DE4
		protected virtual void Update(); // 0x000000018CAA2200-0x000000018CAA2224
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up); // 0x000000018CAA1C28-0x000000018CAA1DB0
		private void PaintStartEnd(CwInputManager.Finger finger, bool up); // 0x000000018CAA1F2C-0x000000018CAA205C
		private void PaintStartInterval(CwInputManager.Finger finger, bool up, float pixelSpacing, bool stretch); // 0x000000018CAA205C-0x000000018CAA21DC
		private void PaintOne(CwInputManager.Finger finger, bool up, float frac, float pixelOff); // 0x000000018CAA1DE4-0x000000018CAA1F2C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Hit Through")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dHitThrough")]
	public class P3dHitThrough : MonoBehaviour // TypeDefIndex: 86685
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
		public PhaseType PaintIn { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float Interval { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public Transform PointA { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Transform PointB { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public OrientationType Orientation { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public Camera Camera { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public float Pressure { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public bool Preview { get; set; } // 0x000000018226ED80-0x000000018226ED90 0x000000018226ED90-0x000000018226EDA0
		public int Priority { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public LineRenderer Line { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public P3dLineConnector Connector { get; } // 0x000000018CAA34BC-0x000000018CAA352C 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 86683
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 86684
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		// Constructors
		public P3dHitThrough(); // 0x000000018CAA3498-0x000000018CAA34BC
	
		// Methods
		[ContextMenu("Manually Hit Now")]
		public void ManuallyHitNow(); // 0x000000018CAA2F08-0x000000018CAA2F14
		[ContextMenu("Clear Hit Cache")]
		public void ClearHitCache(); // 0x000000018CAA2EC8-0x000000018CAA2EEC
		[ContextMenu("Reset Connections")]
		public void ResetConnections(); // 0x000000018CAA2F38-0x000000018CAA2F58
		protected virtual void OnEnable(); // 0x000000018CAA2F14-0x000000018CAA2F38
		protected virtual void Update(); // 0x000000018CAA3448-0x000000018CAA3498
		protected virtual void LateUpdate(); // 0x000000018CAA2F00-0x000000018CAA2F08
		protected virtual void FixedUpdate(); // 0x000000018CAA2EEC-0x000000018CAA2F00
		private void SubmitHit(bool preview); // 0x000000018CAA2F58-0x000000018CAA327C
		private void UpdateHit(); // 0x000000018CAA327C-0x000000018CAA32E4
		private void UpdatePointAndLine(); // 0x000000018CAA32E4-0x000000018CAA3448
	}

	public interface IClone // TypeDefIndex: 86686
	{
		// Methods
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}

	public interface IHit // TypeDefIndex: 86687
	{
	}

	public interface IHitCoord : IHit // TypeDefIndex: 86688
	{
		// Methods
		void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation);
	}

	public interface IHitLine : IHit // TypeDefIndex: 86689
	{
		// Methods
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip);
	}

	public interface IHitPoint : IHit // TypeDefIndex: 86690
	{
		// Methods
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}

	public interface IHitQuad : IHit // TypeDefIndex: 86691
	{
		// Methods
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip);
	}

	public interface IHitTriangle : IHit // TypeDefIndex: 86692
	{
		// Methods
		void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation);
	}

	public interface IBrowsable // TypeDefIndex: 86693
	{
		// Methods
		string GetCategory();
		string GetTitle();
		Texture2D GetIcon();
		UnityEngine.Object GetObject();
	}

	[AddComponentMenu("")]
	public class P3dHitScreen_InEditor : P3dHitScreen // TypeDefIndex: 86694
	{
		// Constructors
		public P3dHitScreen_InEditor(); // 0x000000018CAA25C8-0x000000018CAA25D0
	
		// Methods
		protected override void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void LateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("Paint in 3D/P3D Material")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterial")]
	public class P3dMaterial : MonoBehaviour, IBrowsable // TypeDefIndex: 86695
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
		public string Category { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Texture2D Icon { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public List<Texture> Textures { get; } // 0x000000018CAA362C-0x000000018CAA36B0 
		public static List<P3dMaterial> CachedMaterials { get; } // 0x000000018CAA3578-0x000000018CAA362C 
	
		// Constructors
		public P3dMaterial(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static void ClearCache(); // 0x000000018CAA352C-0x000000018CAA3578
		public string GetCategory(); // 0x0000000182234E30-0x0000000182234E40
		public string GetTitle(); // 0x0000000187835674-0x000000018783567C
		public Texture2D GetIcon(); // 0x000000018225E800-0x000000018225E810
		public UnityEngine.Object GetObject(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	[AddComponentMenu("")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPreset")]
	public class P3dPreset : MonoBehaviour // TypeDefIndex: 86696
	{
		// Fields
		[SerializeField]
		private string title; // 0x18
		[SerializeField]
		private bool addMaterialCloner; // 0x20
		private static List<P3dPreset> cachedPresets; // 0x00
	
		// Properties
		public string Title { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool AddMaterialCloner { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public P3dPreset(); // 0x00000001872301B0-0x00000001872301D0
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dSeamFixer")]
	public class P3dSeamFixer : ScriptableObject // TypeDefIndex: 86702
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
		public List<Pair> Meshes { get; } // 0x000000018CAA84E8-0x000000018CAA856C 
		public P3dCoord Coord { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public float Threshold { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
		public float Border { get; set; } // 0x0000000187235380-0x0000000187235390 0x0000000187235390-0x00000001872353A0
	
		// Nested types
		[Serializable]
		public class Pair // TypeDefIndex: 86697
		{
			// Fields
			public Mesh Source; // 0x10
			public Mesh Output; // 0x18
	
			// Constructors
			public Pair(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class Ring // TypeDefIndex: 86698
		{
			// Fields
			public List<Point> Points; // 0x10
	
			// Constructors
			public Ring(); // 0x000000018CAA885C-0x000000018CAA88D4
	
			// Methods
			public Point GetPoint(int index); // 0x000000018CAA87E4-0x000000018CAA885C
		}
	
		private class Edge // TypeDefIndex: 86699
		{
			// Fields
			public bool Used; // 0x10
			public Point PointA; // 0x18
			public Point PointB; // 0x20
			public bool Flip; // 0x28
	
			// Constructors
			public Edge(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool Match(Point a, Point b); // 0x000000018CA95C10-0x000000018CA95C30
		}
	
		private class Point // TypeDefIndex: 86700
		{
			// Fields
			public int Index; // 0x10
			public Vector2 Coord; // 0x14
			public Insertion Outer; // 0x20
			public List<Edge> Edges; // 0x28
	
			// Constructors
			public Point(); // 0x000000018CAA876C-0x000000018CAA87E4
		}
	
		private class Insertion // TypeDefIndex: 86701
		{
			// Fields
			public int Index; // 0x10
			public int NewIndex; // 0x14
			public Vector2 NewCoord; // 0x18
	
			// Constructors
			public Insertion(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public P3dSeamFixer(); // 0x000000018CAA84D0-0x000000018CAA84E8
		static P3dSeamFixer(); // 0x000000018CAA8354-0x000000018CAA84D0
	
		// Methods
		public static Mesh GetCachedMesh(Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x02645BA0 */); // 0x000000018CAA7DDC-0x000000018CAA7EE4
		private static Mesh TryGetCachedMesh(Dictionary<Mesh, Mesh> cache, Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x02645BA1 */); // 0x000000018CAA81B0-0x000000018CAA8354
		public void AddMesh(Mesh mesh); // 0x000000018CAA50BC-0x000000018CAA5174
		public void ConvertLegacy(); // 0x000000018CAA54EC-0x000000018CAA55DC
		[ContextMenu("Generate")]
		public void Generate(); // 0x000000018CAA7AA4-0x000000018CAA7DDC
		public static void Generate(Mesh source, Mesh output, P3dCoord coord, float threshold, float border); // 0x000000018CAA6CFC-0x000000018CAA7AA4
		private static void AddCoord(List<Vector4> coords, Insertion insertion, bool write); // 0x000000018CAA4FD0-0x000000018CAA50BC
		private static void FixSeams(Mesh source, Mesh output, List<List<int>> submeshes, List<Ring> rings, List<Insertion> insertions, P3dCoord coord); // 0x000000018CAA55DC-0x000000018CAA6CFC
		private static void TraceEdges(Ring ring, Point point); // 0x000000018CAA8090-0x000000018CAA81B0
		private static void AddPoint(Dictionary<Vector2, Point> points, Vector2 coord, int index); // 0x000000018CAA5174-0x000000018CAA5278
		private static void AddTriangle(List<Edge> edges, Point pointA, Point pointB, Point pointC); // 0x000000018CAA532C-0x000000018CAA54EC
		private static void AddTriangle2(List<Edge> edges, Point pointA, Point pointB, Point pointC, bool flip); // 0x000000018CAA5278-0x000000018CAA532C
		private static void RemoveOrAddEdge(List<Edge> edges, Point pointA, Point pointB, bool flip); // 0x000000018CAA7EE4-0x000000018CAA8090
	}

	[AddComponentMenu("Paint in 3D/P3D Shape")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dShape")]
	public class P3dShape : MonoBehaviour, IBrowsable // TypeDefIndex: 86703
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dShape> cachedShapes; // 0x00
	
		// Properties
		public string Category { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Texture2D Icon { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public static List<P3dShape> CachedShapes { get; } // 0x000000018CAA85B8-0x000000018CAA866C 
	
		// Constructors
		public P3dShape(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static void ClearCache(); // 0x000000018CAA856C-0x000000018CAA85B8
		public string GetCategory(); // 0x0000000182234E30-0x0000000182234E40
		public string GetTitle(); // 0x0000000187835674-0x000000018783567C
		public Texture2D GetIcon(); // 0x000000018225E800-0x000000018225E810
		public UnityEngine.Object GetObject(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	[AddComponentMenu("Paint in 3D/P3D Tool")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTool")]
	public class P3dTool : MonoBehaviour, IBrowsable // TypeDefIndex: 86704
	{
		// Fields
		[SerializeField]
		private string category; // 0x18
		[SerializeField]
		private Texture2D icon; // 0x20
		private static List<P3dTool> cachedTools; // 0x00
	
		// Properties
		public string Category { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Texture2D Icon { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public static List<P3dTool> CachedTools { get; } // 0x000000018CAA86B8-0x000000018CAA876C 
	
		// Constructors
		public P3dTool(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static void ClearCache(); // 0x000000018CAA866C-0x000000018CAA86B8
		public string GetCategory(); // 0x0000000182234E30-0x0000000182234E40
		public string GetTitle(); // 0x0000000187835674-0x000000018783567C
		public Texture2D GetIcon(); // 0x000000018225E800-0x000000018225E810
		public UnityEngine.Object GetObject(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	[Serializable]
	public class P3dModifyAngleRandom : P3dModifier // TypeDefIndex: 86706
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
		public float Min { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float Max { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public BlendType Blend { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86705
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyAngleRandom(); // 0x0000000187253D10-0x0000000187253D30
		static P3dModifyAngleRandom(); // 0x000000018CAA36FC-0x000000018CAA3794
	
		// Methods
		protected override void OnModifyAngle(ref float angle, float pressure); // 0x000000018CAA36B0-0x000000018CAA36FC
	}

	[Serializable]
	public class P3dModifyColorRandom : P3dModifier // TypeDefIndex: 86708
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private Gradient gradient; // 0x18
		[SerializeField]
		private BlendType blend; // 0x20
	
		// Properties
		public Gradient Gradient { get; } // 0x000000018CAA38E8-0x000000018CAA395C 
		public BlendType Blend { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86707
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyColorRandom(); // 0x0000000187253D30-0x0000000187253D40
		static P3dModifyColorRandom(); // 0x000000018CAA3850-0x000000018CAA38E8
	
		// Methods
		protected override void OnModifyColor(ref UnityEngine.Color color, float pressure); // 0x000000018CAA3794-0x000000018CAA3850
	}

	public class P3dModifyHardnessPressure : P3dModifier // TypeDefIndex: 86710
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float hardness; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Hardness { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public BlendType Blend { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86709
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessPressure(); // 0x0000000187253D40-0x0000000187253D50
		static P3dModifyHardnessPressure(); // 0x000000018CAA39A0-0x000000018CAA3A38
	
		// Methods
		protected override void OnModifyHardness(ref float currentHardness, float pressure); // 0x000000018CAA395C-0x000000018CAA39A0
	}

	[Serializable]
	public class P3dModifyHardnessRandom : P3dModifier // TypeDefIndex: 86712
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
		public float Min { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float Max { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public BlendType Blend { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86711
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessRandom(); // 0x0000000187253D50-0x0000000187253D70
		static P3dModifyHardnessRandom(); // 0x000000018CAA3A38-0x000000018CAA3AD0
	
		// Methods
		protected override void OnModifyHardness(ref float hardness, float pressure); // 0x000000018CAA36B0-0x000000018CAA36FC
	}

	[Serializable]
	public class P3dModifyOpacityPressure : P3dModifier // TypeDefIndex: 86714
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float opacity; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Opacity { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public BlendType Blend { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86713
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityPressure(); // 0x0000000187253D40-0x0000000187253D50
		static P3dModifyOpacityPressure(); // 0x000000018CAA3AD0-0x000000018CAA3B68
	
		// Methods
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure); // 0x000000018CAA395C-0x000000018CAA39A0
	}

	[Serializable]
	public class P3dModifyOpacityRandom : P3dModifier // TypeDefIndex: 86716
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
		public float Min { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float Max { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public BlendType Blend { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86715
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityRandom(); // 0x0000000187253D50-0x0000000187253D70
		static P3dModifyOpacityRandom(); // 0x000000018CAA3B68-0x000000018CAA3C00
	
		// Methods
		protected override void OnModifyOpacity(ref float opacity, float pressure); // 0x000000018CAA36B0-0x000000018CAA36FC
	}

	[Serializable]
	public class P3dModifyPositionRandom : P3dModifier // TypeDefIndex: 86717
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
	
		// Properties
		public float Radius { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
	
		// Constructors
		public P3dModifyPositionRandom(); // 0x0000000187253D40-0x0000000187253D50
		static P3dModifyPositionRandom(); // 0x000000018CAA3CA8-0x000000018CAA3D40
	
		// Methods
		protected override void OnModifyPosition(ref Vector3 position, float pressure); // 0x000000018CAA3C00-0x000000018CAA3CA8
	}

	[Serializable]
	public class P3dModifyRadiusPressure : P3dModifier // TypeDefIndex: 86719
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private float radius; // 0x18
		[SerializeField]
		private BlendType blend; // 0x1C
	
		// Properties
		public float Radius { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public BlendType Blend { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86718
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusPressure(); // 0x0000000187253D40-0x0000000187253D50
		static P3dModifyRadiusPressure(); // 0x000000018CAA3D40-0x000000018CAA3DD8
	
		// Methods
		protected override void OnModifyRadius(ref float currentRadius, float pressure); // 0x000000018CAA395C-0x000000018CAA39A0
	}

	[Serializable]
	public class P3dModifyRadiusRandom : P3dModifier // TypeDefIndex: 86721
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
		public float Min { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float Max { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public BlendType Blend { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86720
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusRandom(); // 0x0000000187253D50-0x0000000187253D70
		static P3dModifyRadiusRandom(); // 0x000000018CAA3DD8-0x000000018CAA3E70
	
		// Methods
		protected override void OnModifyRadius(ref float radius, float pressure); // 0x000000018CAA36B0-0x000000018CAA36FC
	}

	[Serializable]
	public class P3dModifyScaleRandom : P3dModifier // TypeDefIndex: 86723
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
		public Vector3 Min { get; set; } // 0x0000000187236730-0x0000000187236750 0x0000000187236750-0x0000000187236760
		public Vector3 Max { get; set; } // 0x000000018723E4F0-0x000000018723E510 0x000000018723E4E0-0x000000018723E4F0
		public BlendType Blend { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public bool Uniform { get; set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 86722
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyScaleRandom(); // 0x0000000187253D70-0x0000000187253DB0
		static P3dModifyScaleRandom(); // 0x000000018CAA4020-0x000000018CAA40B8
	
		// Methods
		protected override void OnModifyScale(ref Vector3 scale, float pressure); // 0x000000018CAA3E70-0x000000018CAA4020
	}

	[Serializable]
	public class P3dModifyTexturePressure : P3dModifier // TypeDefIndex: 86724
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
		public Texture Texture { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float PressureMin { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public float PressureMax { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
	
		// Constructors
		public P3dModifyTexturePressure(); // 0x0000000187253DB0-0x0000000187253DD0
		static P3dModifyTexturePressure(); // 0x000000018CAA40D8-0x000000018CAA4170
	
		// Methods
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure); // 0x000000018CAA40B8-0x000000018CAA40D8
	}

	[Serializable]
	public class P3dModifyTextureRandom : P3dModifier // TypeDefIndex: 86725
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		[SerializeField]
		private List<Texture> textures; // 0x18
	
		// Properties
		public List<Texture> Textures { get; } // 0x000000018CAA4294-0x000000018CAA4318 
	
		// Constructors
		public P3dModifyTextureRandom(); // 0x0000000187253D30-0x0000000187253D40
		static P3dModifyTextureRandom(); // 0x000000018CAA41FC-0x000000018CAA4294
	
		// Methods
		protected override void OnModifyTexture(ref Texture texture, float pressure); // 0x000000018CAA4170-0x000000018CAA41FC
	}

	[Serializable]
	public struct P3dBlendMode // TypeDefIndex: 86726
	{
		// Fields
		public const int ALPHA_BLEND = 0; // Metadata: 0x02645BBD
		public const int ALPHA_BLEND_INVERSE = 1; // Metadata: 0x02645BBE
		public const int PREMULTIPLIED = 2; // Metadata: 0x02645BBF
		public const int ADDITIVE = 3; // Metadata: 0x02645BC0
		public const int ADDITIVE_SOFT = 4; // Metadata: 0x02645BC1
		public const int SUBTRACTIVE = 5; // Metadata: 0x02645BC2
		public const int SUBTRACTIVE_SOFT = 6; // Metadata: 0x02645BC3
		public const int REPLACE = 7; // Metadata: 0x02645BC4
		public const int REPLACE_ORIGINAL = 8; // Metadata: 0x02645BC5
		public const int REPLACE_CUSTOM = 9; // Metadata: 0x02645BC6
		public const int MULTIPLY_INVERSE_RGB = 10; // Metadata: 0x02645BC7
		public const int BLUR = 11; // Metadata: 0x02645BC8
		public const int NORMAL_BLEND = 12; // Metadata: 0x02645BC9
		public const int NORMAL_REPLACE = 13; // Metadata: 0x02645BCA
		public const int FLOW = 14; // Metadata: 0x02645BCB
		public const int NORMAL_REPLACE_ORIGINAL = 15; // Metadata: 0x02645BCC
		public const int NORMAL_REPLACE_CUSTOM = 16; // Metadata: 0x02645BCD
		public const int COUNT = 17; // Metadata: 0x02645BCE
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
		static P3dBlendMode(); // 0x000000018CA96614-0x000000018CA96984
	
		// Methods
		public static P3dBlendMode AlphaBlend(Vector4 channels); // 0x000000018CA95EAC-0x000000018CA95EF0
		public static P3dBlendMode AlphaBlendInverse(Vector4 channels); // 0x000000018CA95E64-0x000000018CA95EAC
		public static P3dBlendMode Premultiplied(Vector4 channels); // 0x000000018CA9645C-0x000000018CA964A4
		public static P3dBlendMode Additive(Vector4 channels); // 0x000000018CA95E1C-0x000000018CA95E64
		public static P3dBlendMode AdditiveSoft(Vector4 channels); // 0x000000018CA95DD4-0x000000018CA95E1C
		public static P3dBlendMode Subtractive(Vector4 channels); // 0x000000018CA965CC-0x000000018CA96614
		public static P3dBlendMode SubtractiveSoft(Vector4 channels); // 0x000000018CA96584-0x000000018CA965CC
		public static P3dBlendMode Replace(Vector4 channels); // 0x000000018CA9653C-0x000000018CA96584
		public static P3dBlendMode ReplaceOriginal(Vector4 channels); // 0x000000018CA964F4-0x000000018CA9653C
		public static P3dBlendMode ReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels); // 0x000000018CA964A4-0x000000018CA964F4
		public static P3dBlendMode MultiplyInverseRGB(Vector4 channels); // 0x000000018CA962EC-0x000000018CA96334
		public static P3dBlendMode Blur(float kernel, Vector4 channels); // 0x000000018CA96110-0x000000018CA96154
		public static P3dBlendMode NormalBlend(Vector4 channels); // 0x000000018CA96334-0x000000018CA9637C
		public static P3dBlendMode NormalReplace(Vector4 channels); // 0x000000018CA96414-0x000000018CA9645C
		public static P3dBlendMode Flow(float kernel, Vector4 channels); // 0x000000018CA961D0-0x000000018CA96214
		public static P3dBlendMode NormalReplaceOriginal(Vector4 channels); // 0x000000018CA963CC-0x000000018CA96414
		public static P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels); // 0x000000018CA9637C-0x000000018CA963CC
		public void Apply(Material material); // 0x000000018CA95EF0-0x000000018CA96110
		public static string GetName(int index); // 0x000000018CA96280-0x000000018CA962EC
		public static bool operator ==(P3dBlendMode a, int b); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static bool operator !=(P3dBlendMode a, int b); // 0x000000018CA96984-0x000000018CA9698C
		public static implicit operator int(P3dBlendMode a); // 0x00000001844AD290-0x00000001844AD2A0
		public override int GetHashCode(); // 0x000000018CA96214-0x000000018CA96280
		public override bool Equals(object obj); // 0x000000018CA96154-0x000000018CA961D0
	}

	public static class P3dBlit // TypeDefIndex: 86727
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
		static P3dBlit(); // 0x000000018CAA94EC-0x000000018CAA95C0
	
		// Methods
		public static void White(RenderTexture rendertexture, Mesh mesh, int submesh, P3dCoord coord); // 0x000000018CAA92A4-0x000000018CAA94EC
		public static void Texture(RenderTexture rendertexture, Mesh mesh, int submesh, Texture texture, P3dCoord coord); // 0x000000018CAA901C-0x000000018CAA92A4
		public static void Normal(RenderTexture rendertexture, Texture texture); // 0x000000018CAA8D14-0x000000018CAA8E5C
		public static void Premultiply(RenderTexture rendertexture, Texture texture, UnityEngine.Color tint); // 0x000000018CAA8E5C-0x000000018CAA901C
	}

	[AddComponentMenu("Paint in 3D/P3D Change Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChangeCounter")]
	public class P3dChangeCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 86728
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
		public float Threshold { get; set; } // 0x0000000187253DD0-0x0000000187253DE0 0x000000018CAAA3AC-0x000000018CAAA3DC
		public Texture Texture { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018CAAA328-0x000000018CAAA3AC
		public UnityEngine.Color Color { get; set; } // 0x000000018724F490-0x000000018724F4A0 0x000000018CAAA2D8-0x000000018CAAA328
		public int Count { get; } // 0x000000018723BAC0-0x000000018723BAD0 
		public float Ratio { get; } // 0x000000018CAAA2B4-0x000000018CAAA2D8 
		public P3dReader ChangeReader { get; } // 0x000000018723BB00-0x000000018723BB10 
	
		// Constructors
		public P3dChangeCounter(); // 0x000000018CAAA278-0x000000018CAAA2B4
		static P3dChangeCounter(); // 0x000000018CAAA1FC-0x000000018CAAA278
	
		// Methods
		public void MarkChangeReaderAsDirty(); // 0x000000018CAA9C98-0x000000018CAA9CB0
		public static long GetTotal(ICollection<P3dChangeCounter> counters = null); // 0x000000018CAA97EC-0x000000018CAA998C
		public static long GetCount(ICollection<P3dChangeCounter> counters = null); // 0x000000018CAA95C0-0x000000018CAA9760
		public static float GetRatio(ICollection<P3dChangeCounter> counters = null); // 0x000000018CAA9760-0x000000018CAA97EC
		private void HandleCompleteChange(NativeArray<Color32> pixels); // 0x000000018CAA998C-0x000000018CAA9AF4
		protected override void HandleComplete(int boost); // 0x000000018CAA9AF4-0x000000018CAA9C98
		protected override void OnEnable(); // 0x000000018CAA9E34-0x000000018CAA9F38
		protected override void OnDisable(); // 0x000000018CAA9D28-0x000000018CAA9E34
		protected override void OnDestroy(); // 0x000000018CAA9CB0-0x000000018CAA9D28
		protected override void Update(); // 0x000000018CAA9F38-0x000000018CAAA1FC
	}

	public enum P3dChannel // TypeDefIndex: 86729
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Alpha = 3
	}

	[AddComponentMenu("Paint in 3D/P3D Channel Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dChannelCounter")]
	public class P3dChannelCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 86730
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
		public float Threshold { get; set; } // 0x0000000187253DD0-0x0000000187253DE0 0x000000018CAAB580-0x000000018CAAB5A8
		public int CountR { get; } // 0x0000000187235BE0-0x0000000187235BF0 
		public int CountG { get; } // 0x0000000187235BD0-0x0000000187235BE0 
		public int CountB { get; } // 0x0000000187235BF0-0x0000000187235C00 
		public int CountA { get; } // 0x000000018723DAC0-0x000000018723DAD0 
		public float RatioR { get; } // 0x000000018CAAB55C-0x000000018CAAB580 
		public float RatioG { get; } // 0x000000018CAAB484-0x000000018CAAB4A8 
		public float RatioB { get; } // 0x000000018CAAB460-0x000000018CAAB484 
		public float RatioA { get; } // 0x000000018CAAB43C-0x000000018CAAB460 
		public Vector4 RatioRGBA { get; } // 0x000000018CAAB4A8-0x000000018CAAB55C 
	
		// Constructors
		public P3dChannelCounter(); // 0x000000018CAAB424-0x000000018CAAB43C
		static P3dChannelCounter(); // 0x000000018CAAB3A8-0x000000018CAAB424
	
		// Methods
		public static long GetTotal(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAFB8-0x000000018CAAB158
		public static long GetCountR(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAA8BC-0x000000018CAAAA5C
		public static long GetCountG(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAA71C-0x000000018CAAA8BC
		public static long GetCountB(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAA57C-0x000000018CAAA71C
		public static long GetCountA(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAA3DC-0x000000018CAAA57C
		public static float GetRatioR(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAF2C-0x000000018CAAAFB8
		public static float GetRatioG(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAB74-0x000000018CAAAC00
		public static float GetRatioB(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAAE8-0x000000018CAAAB74
		public static float GetRatioA(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAA5C-0x000000018CAAAAE8
		public static Vector4 GetRatioRGBA(ICollection<P3dChannelCounter> counters = null); // 0x000000018CAAAC00-0x000000018CAAAF2C
		protected override void OnEnable(); // 0x000000018CAAB31C-0x000000018CAAB3A8
		protected override void OnDisable(); // 0x000000018CAAB288-0x000000018CAAB31C
		protected override void HandleComplete(int boost); // 0x000000018CAAB158-0x000000018CAAB288
	}

	public abstract class P3dClone : MonoBehaviour, IClone // TypeDefIndex: 86731
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
		public static LinkedList<P3dClone> Instances { get; } // 0x000000018CAAC6D4-0x000000018CAAC724 
	
		// Constructors
		protected P3dClone(); // 0x00000001878364A0-0x00000001878364B8
		static P3dClone(); // 0x000000018CAAC538-0x000000018CAAC6D4
	
		// Methods
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
		public static void BuildCloners(List<IClone> cloners = null); // 0x000000018CAABCEC-0x000000018CAAC13C
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex); // 0x000000018CAAC13C-0x000000018CAAC43C
		protected virtual void OnEnable(); // 0x000000018CAAC4BC-0x000000018CAAC538
		protected virtual void OnDisable(); // 0x000000018CAAC43C-0x000000018CAAC4BC
	}

	[AddComponentMenu("Paint in 3D/P3D Clone Mirror")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCloneMirror")]
	public class P3dCloneMirror : P3dClone // TypeDefIndex: 86732
	{
		// Fields
		[SerializeField]
		private bool flip; // 0x20
	
		// Properties
		public bool Flip { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public P3dCloneMirror(); // 0x000000018CAABC98-0x000000018CAABCEC
	
		// Methods
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix); // 0x000000018CAAB5A8-0x000000018CAABC98
	}

	[AddComponentMenu("Paint in 3D/P3D Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColor")]
	public class P3dColor : MonoBehaviour // TypeDefIndex: 86734
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color color; // 0x18
		[SerializeField]
		private List<Contribution> contributions; // 0x28
		private static LinkedList<P3dColor> instances; // 0x00
		private LinkedListNode<P3dColor> instancesNode; // 0x30
	
		// Properties
		public UnityEngine.Color Color { get; set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
		public static LinkedList<P3dColor> Instances { get; } // 0x000000018CAADCF0-0x000000018CAADD40 
		public int Total { get; } // 0x000000018CAADE78-0x000000018CAADFF4 
		public int Solid { get; } // 0x000000018CAADD88-0x000000018CAADE78 
		public float Ratio { get; } // 0x000000018CAADD40-0x000000018CAADD88 
	
		// Nested types
		[SerializeField]
		private class Contribution // TypeDefIndex: 86733
		{
			// Fields
			public P3dColorCounter Counter; // 0x10
			public int Solid; // 0x18
	
			// Constructors
			public Contribution(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public P3dColor(); // 0x00000001878364A0-0x00000001878364B8
		static P3dColor(); // 0x000000018CAADC74-0x000000018CAADCF0
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CAAD974-0x000000018CAADB44
		protected virtual void OnDisable(); // 0x000000018CAAD794-0x000000018CAAD974
		public void Contribute(P3dColorCounter counter, int solid); // 0x000000018CAAD6C8-0x000000018CAAD794
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution); // 0x000000018CAADB44-0x000000018CAADC74
	}

	[AddComponentMenu("Paint in 3D/P3D Color Counter")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dColorCounter")]
	public class P3dColorCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 86736
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
		public float Threshold { get; set; } // 0x0000000187253DD0-0x0000000187253DE0 0x000000018CAAB580-0x000000018CAAB5A8
		public List<Contribution> Contributions { get; } // 0x0000000187232FB0-0x0000000187232FC0 
	
		// Nested types
		public class Contribution // TypeDefIndex: 86735
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
			public Contribution(); // 0x0000000186805BA0-0x0000000186805BB0
			static Contribution(); // 0x000000018CAA8A64-0x000000018CAA8AF0
		}
	
		// Constructors
		public P3dColorCounter(); // 0x000000018CAAD638-0x000000018CAAD6C8
		static P3dColorCounter(); // 0x000000018CAAD5BC-0x000000018CAAD638
	
		// Methods
		public static long GetTotal(ICollection<P3dColorCounter> counters = null); // 0x000000018CAACD74-0x000000018CAACF14
		public static long GetCount(P3dColor color, ICollection<P3dColorCounter> counters = null); // 0x000000018CAACB2C-0x000000018CAACCE4
		public static float GetRatio(P3dColor color, ICollection<P3dColorCounter> counters = null); // 0x000000018CAACCE4-0x000000018CAACD74
		public int Count(P3dColor color); // 0x000000018CAAC9C4-0x000000018CAACB2C
		public float Ratio(P3dColor color); // 0x000000018CAAD584-0x000000018CAAD5BC
		protected override void OnEnable(); // 0x000000018CAAD210-0x000000018CAAD29C
		protected override void OnDisable(); // 0x000000018CAAD170-0x000000018CAAD210
		protected override void HandleComplete(int boost); // 0x000000018CAACF14-0x000000018CAAD170
		private void ClearContributions(); // 0x000000018CAAC724-0x000000018CAAC814
		private void PrepareContributions(); // 0x000000018CAAD29C-0x000000018CAAD584
		private void Contribute(int scale); // 0x000000018CAAC814-0x000000018CAAC9C4
	}

	[Serializable]
	public abstract class P3dCommand // TypeDefIndex: 86737
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
		protected P3dCommand(); // 0x0000000186805BA0-0x0000000186805BB0
		static P3dCommand(); // 0x000000018CAAE4C0-0x000000018CAAE53C
	
		// Methods
		public static void BuildMaterial(ref Material material, ref int materialHash, string path, string keyword = null); // 0x000000018CAAE144-0x000000018CAAE1E4
		public static int Compare(P3dCommand a, P3dCommand b); // 0x000000018CAAE1E4-0x000000018CAAE240
		public void SetState(bool preview, int priority); // 0x0000000187253DE0-0x0000000187253DF0
		public virtual void Apply(Material material); // 0x000000018CAADFF4-0x000000018CAAE0B0
		public abstract void Pool();
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);
		public abstract P3dCommand SpawnCopy();
		public P3dCommand SpawnCopyLocal(Transform transform); // 0x000000018CAAE240-0x000000018CAAE380
		public P3dCommand SpawnCopyWorld(Transform transform); // 0x000000018CAAE380-0x000000018CAAE4C0
		protected T SpawnCopy<T>(Stack<T> pool)
			where T : P3dCommand, new();
		public virtual void Apply(P3dPaintableTexture paintableTexture); // 0x000000018CAAE0B0-0x000000018CAAE144
	}

	public static class P3dCommon // TypeDefIndex: 86739
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/PaintIn3D#"; // Metadata: 0x02645BDD
		public const string ComponentMenuPrefix = "Paint in 3D/P3D "; // Metadata: 0x02645C0F
		public const string ComponentHitMenuPrefix = "Paint in 3D/Hit/P3D "; // Metadata: 0x02645C20
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
		private sealed class __c // TypeDefIndex: 86738
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018CABEE30-0x000000018CABEE94
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.cctor_b__5_0(Camera camera); // 0x000000018CABED40-0x000000018CABEDB8
			internal void _.cctor_b__5_1(ScriptableRenderContext context, Camera camera); // 0x000000018CABEDB8-0x000000018CABEE30
		}
	
		// Constructors
		static P3dCommon(); // 0x000000018CAB0DB8-0x000000018CAB0F98
	
		// Methods
		public static float RatioToPercentage(float ratio01, int decimalPlaces); // 0x000000018CAB07D4-0x000000018CAB0880
		public static RenderTexture GetRenderTexture(RenderTexture other); // 0x000000018CAB01C4-0x000000018CAB027C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, RenderTexture other); // 0x000000018CAB0064-0x000000018CAB0148
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc); // 0x000000018CAB027C-0x000000018CAB02F8
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB); // 0x000000018CAB0148-0x000000018CAB01C4
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture); // 0x000000018CAB0CF8-0x000000018CAB0D00
		public static Quaternion NormalToCameraRotation(Vector3 normal, Camera optionalCamera = null); // 0x000000018CAB0690-0x000000018CAB07D4
		public static Vector3 GetCameraUp(Camera camera = null); // 0x000000018CAAF04C-0x000000018CAAF110
		public static bool CanReadPixels(TextureFormat format); // 0x000000018CAAE8A0-0x000000018CAAE8B8
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture); // 0x000000018CAB0880-0x000000018CAB0A80
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture); // 0x000000018CAB0A80-0x000000018CAB0CF8
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary); // 0x000000018CAAEAD8-0x000000018CAAED5C
		public static bool HasMipMaps(Texture texture); // 0x000000018CAB0410-0x000000018CAB0510
		public static Mesh GetSphereMesh(); // 0x000000018CAB02F8-0x000000018CAB0410
		public static Mesh GetMesh(GameObject root, Mesh mesh = null); // 0x000000018CAAF198-0x000000018CAAF2A4
		public static Mesh GetQuadMesh(); // 0x000000018CAAF7A8-0x000000018CAAF8C4
		public static UnityEngine.Color GetPixel(RenderTexture renderTexture, Vector2 uv, bool mipMaps = false /* Metadata: 0x02645BD3 */); // 0x000000018CAAF2A4-0x000000018CAAF58C
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02645BD4 */, bool mipMaps = false /* Metadata: 0x02645BD5 */, int width = 0 /* Metadata: 0x02645BD6 */, int height = 0 /* Metadata: 0x02645BD7 */); // 0x000000018CAAFE10-0x000000018CAB0064
		public static void SaveBytes(string saveName, byte[] data, bool save = true /* Metadata: 0x02645BD8 */); // 0x000000018CAB0D00-0x000000018CAB0D7C
		public static byte[] LoadBytes(string saveName); // 0x000000018CAB0568-0x000000018CAB05C8
		public static bool SaveExists(string saveName); // 0x000000018CAB0D7C-0x000000018CAB0D84
		public static void ClearSave(string saveName, bool save = true /* Metadata: 0x02645BD9 */); // 0x000000018CAAE8B8-0x000000018CAAE8F4
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition); // 0x000000018CAAF58C-0x000000018CAAF610
		public static Vector3 GetPosition(Vector3 positionA, Vector3 positionB, Vector3 positionC); // 0x000000018CAAF610-0x000000018CAAF6C4
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2); // 0x000000018CAAF6C4-0x000000018CAAF7A8
		public static float GetRadius(Vector3 size); // 0x000000018CAAFB7C-0x000000018CAAFBB4
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition); // 0x000000018CAAF8C4-0x000000018CAAF9B8
		public static float GetRadius(Vector3 size, Vector3 positionA, Vector3 positionB, Vector3 positionC); // 0x000000018CAAF9B8-0x000000018CAAFB7C
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2); // 0x000000018CAAFBB4-0x000000018CAAFE10
		public static Vector3 ScaleAspect(Vector3 size, float aspect); // 0x000000018CAB0D84-0x000000018CAB0DB8
		public static float GetAspect(Texture textureA, Texture textureB = null); // 0x000000018CAAEF74-0x000000018CAAF04C
		public static void Blit(RenderTexture renderTexture, Texture other); // 0x000000018CAAE6A0-0x000000018CAAE710
		public static void Blit(RenderTexture renderTexture, Material material, int pass); // 0x000000018CAAE710-0x000000018CAAE798
		public static Vector4 IndexToVector(int index); // 0x000000018CAB0510-0x000000018CAB0568
		public static void Draw(Material material, int pass, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord); // 0x000000018CAAEE5C-0x000000018CAAEF74
		public static void Draw(Material material, int pass); // 0x000000018CAAED5C-0x000000018CAAEE5C
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps); // 0x000000018CAAEA34-0x000000018CAAEAD8
		public static Material GetMaterial(Renderer renderer, int materialIndex = 0 /* Metadata: 0x02645BDA */); // 0x000000018CAAF110-0x000000018CAAF198
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x02645BDB */); // 0x000000018CAAE8F4-0x000000018CAAEA34
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1 /* Metadata: 0x02645BDC */); // 0x000000018CAAE53C-0x000000018CAAE6A0
		public static Shader LoadShader(string shaderName); // 0x000000018CAB05C8-0x000000018CAB0690
		public static Material BuildMaterial(Shader shader); // 0x000000018CAAE798-0x000000018CAAE7F8
		public static Material BuildMaterial(string shaderName, string keyword = null); // 0x000000018CAAE7F8-0x000000018CAAE8A0
	}

	public enum P3dCoord // TypeDefIndex: 86740
	{
		First = 0,
		Second = 1,
		Third = 2,
		Fourth = 3
	}

	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dCoordCopier")]
	public class P3dCoordCopier : ScriptableObject // TypeDefIndex: 86742
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
		public Mesh Source { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Coord First { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public Coord Second { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public Coord Third { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public Coord Fourth { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
	
		// Nested types
		public enum Coord // TypeDefIndex: 86741
		{
			First = 0,
			Second = 1,
			Third = 2,
			Fourth = 3,
			None = 4
		}
	
		// Constructors
		public P3dCoordCopier(); // 0x000000018CAB1BDC-0x000000018CAB1C00
		static P3dCoordCopier(); // 0x000000018CAB17CC-0x000000018CAB1BDC
	
		// Methods
		public List<Vector4> GetCoords(Coord coord); // 0x000000018CAB16C8-0x000000018CAB1774
		public void Generate(); // 0x000000018CAB0F98-0x000000018CAB16C8
		protected virtual void OnDestroy(); // 0x000000018CAB1774-0x000000018CAB17CC
	}

	[AddComponentMenu("Paint in 3D/P3D Gradually Fade")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dGraduallyFade")]
	public class P3dGraduallyFade : MonoBehaviour // TypeDefIndex: 86743
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
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float Threshold { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public float Speed { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
		public P3dBlendMode BlendMode { get; set; } // 0x0000000187253DF0-0x0000000187253E20 0x000000018CAB2044-0x000000018CAB2070
		public Texture BlendTexture { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public P3dPaintableTexture BlendPaintableTexture { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public UnityEngine.Color BlendColor { get; set; } // 0x000000018723DAE0-0x000000018723DAF0 0x0000000187233D60-0x0000000187233D70
		public Texture MaskTexture { get; set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public P3dPaintableTexture MaskPaintableTexture { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public P3dChannel MaskChannel { get; set; } // 0x00000001872333B0-0x00000001872333C0 0x0000000185FD6920-0x0000000185FD6930
	
		// Constructors
		public P3dGraduallyFade(); // 0x000000018CAB1F80-0x000000018CAB2044
	
		// Methods
		protected virtual void Update(); // 0x000000018CAB1C00-0x000000018CAB1F80
	}

	[Serializable]
	public struct P3dGroup // TypeDefIndex: 86744
	{
		// Fields
		[SerializeField]
		private int index; // 0x00
	
		// Constructors
		public P3dGroup(int newIndex); // 0x0000000184547F40-0x0000000184547F50
	
		// Methods
		public static implicit operator int(P3dGroup group); // 0x0000000187235A70-0x0000000187235A80
		public static implicit operator P3dGroup(int index); // 0x0000000187235A70-0x0000000187235A80
		public override string ToString(); // 0x000000018CAB25F8-0x000000018CAB2600
	}

	public class P3dGroupData : ScriptableObject // TypeDefIndex: 86747
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
		public int Index { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public List<TextureData> TextureDatas { get; } // 0x000000018CAB2574-0x000000018CAB25F8 
		public string ShaderData { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Nested types
		[Serializable]
		public class TextureData // TypeDefIndex: 86745
		{
			// Fields
			public string Name; // 0x10
			public P3dBlendMode BlendMode; // 0x18
	
			// Constructors
			public TextureData(); // 0x000000018CABECA8-0x000000018CABED40
		}
	
		private class Entry // TypeDefIndex: 86746
		{
			// Fields
			public string Path; // 0x10
			public string Property; // 0x18
	
			// Constructors
			public Entry(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public P3dGroupData(); // 0x000000018CAB24F4-0x000000018CAB2574
	
		// Methods
		public void TryGetShaderSlotName(string shaderPath, ref string propertyName); // 0x000000018CAB2160-0x000000018CAB24F4
		public bool Supports(Shader shader); // 0x000000018CAB20E4-0x000000018CAB2160
		public string GetName(bool prefixNumber); // 0x000000018CAB2070-0x000000018CAB20E4
	}

	[Serializable]
	public struct P3dHash // TypeDefIndex: 86748
	{
		// Fields
		[SerializeField]
		private int v; // 0x00
	
		// Constructors
		public P3dHash(int newValue); // 0x0000000184547F40-0x0000000184547F50
	
		// Methods
		public override bool Equals(object obj); // 0x000000018CAB2600-0x000000018CAB265C
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public static implicit operator int(P3dHash hash); // 0x0000000187235A70-0x0000000187235A80
		public static implicit operator P3dHash(int index); // 0x0000000187235A70-0x0000000187235A80
		public override string ToString(); // 0x000000018CAB25F8-0x000000018CAB2600
	}

	[Serializable]
	public struct P3dHashedMaterial // TypeDefIndex: 86749
	{
		// Fields
		[NonSerialized]
		private Material instance; // 0x00
		[SerializeField]
		private int hash; // 0x08
	
		// Constructors
		public P3dHashedMaterial(Material newInstance, int newHash); // 0x000000018783B33C-0x000000018783B358
	
		// Methods
		public bool TryGetInstance(out Material model); // 0x000000018CAB265C-0x000000018CAB2724
	}

	[Serializable]
	public struct P3dHashedModel // TypeDefIndex: 86750
	{
		// Fields
		[NonSerialized]
		private P3dModel instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedModel(P3dModel newInstance); // 0x000000018CAB281C-0x000000018CAB28B4
		public bool TryGetInstance(out P3dModel model); // 0x000000018CAB2724-0x000000018CAB281C
	}

	[Serializable]
	public struct P3dHashedTexture // TypeDefIndex: 86751
	{
		// Fields
		[NonSerialized]
		private Texture instance; // 0x00
		[SerializeField]
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedTexture(Texture newInstance); // 0x000000018CAB29A0-0x000000018CAB2A68
		public static implicit operator Texture(P3dHashedTexture hashed); // 0x000000018CAB297C-0x000000018CAB29A0
		public bool TryGetInstance(out Texture texture); // 0x000000018CAB28B4-0x000000018CAB297C
	}

	public struct P3dHit // TypeDefIndex: 86752
	{
		// Fields
		public Transform Root; // 0x00
		public Vector2 First; // 0x08
		public Vector2 Second; // 0x10
	
		// Constructors
		public P3dHit(RaycastHit hit); // 0x000000018CAB2A68-0x000000018CAB2AF8
	}

	[Serializable]
	public class P3dLineConnector // TypeDefIndex: 86754
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
		public float HitSpacing { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public int HitLimit { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public bool ConnectHits { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool ClipConnected { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public P3dHitCache HitCache { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		private class Link // TypeDefIndex: 86753
		{
			// Fields
			public object Owner; // 0x10
			public Vector3 Position; // 0x18
			public Vector3 EndPosition; // 0x24
			public float Age; // 0x30
			public bool Preview; // 0x34
	
			// Constructors
			public Link(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public P3dLineConnector(); // 0x000000018CAB36E4-0x000000018CAB3798
		static P3dLineConnector(); // 0x000000018CAB3658-0x000000018CAB36E4
	
		// Methods
		public void ClearHitCache(); // 0x000000018CAB2C04-0x000000018CAB2C24
		public void ResetConnections(); // 0x000000018CAB2C24-0x000000018CAB2D0C
		public void BreakHits(object owner); // 0x000000018CAB2AF8-0x000000018CAB2C04
		public void SubmitLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, object owner); // 0x000000018CAB2D0C-0x000000018CAB3474
		public void Update(); // 0x000000018CAB3528-0x000000018CAB3658
		private bool TryGetLink(object owner, ref Link link); // 0x000000018CAB3474-0x000000018CAB3528
	}

	[AddComponentMenu("Paint in 3D/P3D Mask")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMask")]
	public class P3dMask : MonoBehaviour // TypeDefIndex: 86755
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
		public Texture Texture { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public P3dChannel Channel { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public Vector2 Stretch { get; set; } // 0x0000000187235030-0x0000000187235050 0x0000000187253B00-0x0000000187253B10
		public static LinkedList<P3dMask> Instances { get; } // 0x000000018CAB3BCC-0x000000018CAB3C1C 
		public Matrix4x4 Matrix { get; } // 0x000000018CAB3C1C-0x000000018CAB3C74 
	
		// Constructors
		public P3dMask(); // 0x000000018CAB3BA0-0x000000018CAB3BCC
		static P3dMask(); // 0x000000018CAB3B24-0x000000018CAB3BA0
	
		// Methods
		public static P3dMask Find(Vector3 position, LayerMask layers); // 0x000000018CAB3798-0x000000018CAB3A28
		protected virtual void OnEnable(); // 0x000000018CAB3AA8-0x000000018CAB3B24
		protected virtual void OnDisable(); // 0x000000018CAB3A28-0x000000018CAB3AA8
	}

	[AddComponentMenu("Paint in 3D/P3D Material Cloner")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dMaterialCloner")]
	[RequireComponent(typeof(Renderer))]
	[RequireComponent(typeof(P3dPaintable))]
	public class P3dMaterialCloner : MonoBehaviour // TypeDefIndex: 86756
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
		public int Index { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public Renderer CachedRenderer { get; } // 0x000000018CAB40B8-0x000000018CAB4110 
		public P3dPaintable CachedPaintable { get; } // 0x000000018CAB4060-0x000000018CAB40B8 
		public Material Original { get; } // 0x000000018226EE80-0x000000018226EE90 
		public Material Current { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public bool Activated { get; } // 0x000000018226ED20-0x000000018226ED30 
	
		// Constructors
		public P3dMaterialCloner(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018CAB3C74-0x000000018CAB3D88
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018CAB3D88-0x000000018CAB3E10
		public void ReplaceAll(Material from, Material to); // 0x000000018CAB3E10-0x000000018CAB3F68
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial); // 0x000000018CAB3F68-0x000000018CAB4060
	}

	public static class P3dMeshCache // TypeDefIndex: 86758
	{
		// Fields
		private static Dictionary<Mesh, MeshData> cachedData; // 0x00
	
		// Nested types
		private class MeshData // TypeDefIndex: 86757
		{
			// Fields
			private Vector3[] positions; // 0x10
			private int[] indices; // 0x18
			private int total; // 0x20
	
			// Constructors
			public MeshData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Update(Mesh mesh); // 0x000000018CAA8CA4-0x000000018CAA8D14
			public bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC); // 0x000000018CAA8AF0-0x000000018CAA8CA4
		}
	
		// Constructors
		static P3dMeshCache(); // 0x000000018CAB4338-0x000000018CAB43C4
	
		// Methods
		public static bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC); // 0x000000018CAB4110-0x000000018CAB4338
	}

	[AddComponentMenu("Paint in 3D/P3D Model")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dModel")]
	[RequireComponent(typeof(Renderer))]
	public class P3dModel : MonoBehaviour // TypeDefIndex: 86760
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
		public virtual P3dPaintable Paintable { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public virtual bool IncludeScale { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public UseMeshType UseMesh { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public P3dHash Hash { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x000000018CAB5798-0x000000018CAB57EC
		public static LinkedList<P3dModel> Instances { get; } // 0x000000018CAB5700-0x000000018CAB5750 
		public bool Prepared { get; set; } // 0x000000018723DD20-0x000000018723DD30 0x000000018723DD30-0x000000018723DD40
		public Mesh PreparedMesh { get; } // 0x0000000187232F50-0x0000000187232F60 
		public GameObject CachedGameObject { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public Renderer CachedRenderer { get; } // 0x000000018CAB56D8-0x000000018CAB5700 
		public Material[] Materials { get; } // 0x000000018CAB5750-0x000000018CAB5798 
	
		// Nested types
		public enum UseMeshType // TypeDefIndex: 86759
		{
			AsIs = 0,
			AutoSeamFix = 1
		}
	
		// Constructors
		public P3dModel(); // 0x00000001872301B0-0x00000001872301D0
		static P3dModel(); // 0x000000018CAB55F8-0x000000018CAB56D8
	
		// Methods
		public int GetMaterialIndex(Material material); // 0x000000018CAB4848-0x000000018CAB49B0
		private void CacheRenderer(); // 0x000000018CAB43C4-0x000000018CAB4498
		[ContextMenu("Dirty Materials")]
		public void DirtyMaterials(); // 0x0000000187253E20-0x0000000187253E30
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask); // 0x000000018CAB4498-0x000000018CAB4848
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC); // 0x000000018CAB4D40-0x000000018CAB4F38
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC); // 0x000000018CAB49B0-0x000000018CAB4B78
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC); // 0x000000018CAB4B78-0x000000018CAB4D40
		public int GetSubmesh(P3dPaintableTexture paintableTexture); // 0x000000018CAB5360-0x000000018CAB5408
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix, P3dCoord coord); // 0x000000018CAB4F38-0x000000018CAB5360
		protected virtual void OnEnable(); // 0x000000018CAB5518-0x000000018CAB55F8
		protected virtual void OnDisable(); // 0x000000018CAB548C-0x000000018CAB5518
		protected virtual void OnDestroy(); // 0x000000018CAB5408-0x000000018CAB548C
	}

	[Serializable]
	public abstract class P3dModifier // TypeDefIndex: 86761
	{
		// Fields
		[SerializeField]
		private bool preview; // 0x10
		[SerializeField]
		private bool unique; // 0x11
	
		// Properties
		public bool Preview { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public bool Unique { get; set; } // 0x0000000187235410-0x0000000187235420 0x0000000187235420-0x0000000187235430
	
		// Constructors
		protected P3dModifier(); // 0x0000000187253D30-0x0000000187253D40
	
		// Methods
		public void ModifyAngle(ref float angle, float pressure); // 0x000000018CAB62D0-0x000000018CAB635C
		protected virtual void OnModifyAngle(ref float angle, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyColor(ref UnityEngine.Color color, float pressure); // 0x000000018CAB635C-0x000000018CAB63E0
		protected virtual void OnModifyColor(ref UnityEngine.Color color, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyHardness(ref float hardness, float pressure); // 0x000000018CAB63E0-0x000000018CAB646C
		protected virtual void OnModifyHardness(ref float hardness, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyOpacity(ref float opacity, float pressure); // 0x000000018CAB646C-0x000000018CAB64F8
		protected virtual void OnModifyOpacity(ref float opacity, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyRadius(ref float radius, float pressure); // 0x000000018CAB6584-0x000000018CAB6610
		protected virtual void OnModifyRadius(ref float radius, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyScale(ref Vector3 scale, float pressure); // 0x000000018CAB6610-0x000000018CAB669C
		protected virtual void OnModifyScale(ref Vector3 scale, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyTexture(ref Texture texture, float pressure); // 0x000000018CAB669C-0x000000018CAB6720
		protected virtual void OnModifyTexture(ref Texture texture, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
		public void ModifyPosition(ref Vector3 position, float pressure); // 0x000000018CAB64F8-0x000000018CAB6584
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class P3dModifierList // TypeDefIndex: 86762
	{
		// Fields
		[SerializeReference]
		private List<P3dModifier> modifiers; // 0x10
	
		// Properties
		public int Count { get; } // 0x000000018CAB620C-0x000000018CAB624C 
		public List<P3dModifier> Instances { get; } // 0x000000018CAB624C-0x000000018CAB62D0 
	
		// Constructors
		public P3dModifierList(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void ModifyAngle(ref float angle, bool preview, float pressure); // 0x000000018CAB57EC-0x000000018CAB5930
		public void ModifyColor(ref UnityEngine.Color color, bool preview, float pressure); // 0x000000018CAB5930-0x000000018CAB5A74
		public void ModifyHardness(ref float hardness, bool preview, float pressure); // 0x000000018CAB5A74-0x000000018CAB5BB8
		public void ModifyOpacity(ref float opacity, bool preview, float pressure); // 0x000000018CAB5BB8-0x000000018CAB5CFC
		public void ModifyRadius(ref float radius, bool preview, float pressure); // 0x000000018CAB5E40-0x000000018CAB5F84
		public void ModifyScale(ref Vector3 scale, bool preview, float pressure); // 0x000000018CAB5F84-0x000000018CAB60C8
		public void ModifyTexture(ref Texture texture, bool preview, float pressure); // 0x000000018CAB60C8-0x000000018CAB620C
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure); // 0x000000018CAB5CFC-0x000000018CAB5E40
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable")]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintable")]
	[RequireComponent(typeof(Renderer))]
	public class P3dPaintable : P3dModel // TypeDefIndex: 86764
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
		public override P3dPaintable Paintable { get; set; } // 0x000000018CABD4F8-0x000000018CABD518 0x0000000186805BA0-0x0000000186805BB0
		public ActivationType Activation { get; set; } // 0x00000001828A9D40-0x00000001828A9D50 0x00000001828A9D50-0x00000001828A9D60
		public Vector3 BaseScale { get; set; } // 0x0000000187253E30-0x0000000187253E50 0x0000000187253E50-0x0000000187253E70
		public List<Renderer> OtherRenderers { get; set; } // 0x0000000187232D20-0x0000000187232D30 0x0000000188BD49B4-0x0000000188BD49C8
		public UnityEvent OnActivating { get; } // 0x000000018CABD47C-0x000000018CABD4F8 
		public UnityEvent OnActivated { get; } // 0x000000018CABD400-0x000000018CABD47C 
		public bool Activated { get; } // 0x00000001872406E0-0x00000001872406F0 
		public HashSet<P3dPaintableTexture> PaintableTextures { get; } // 0x000000018723B5D0-0x000000018723B5E0 
	
		// Nested types
		public enum ActivationType // TypeDefIndex: 86763
		{
			Awake = 0,
			OnEnable = 1,
			Start = 2,
			OnFirstUse = 3
		}
	
		// Constructors
		public P3dPaintable(); // 0x000000018CABD308-0x000000018CABD400
		static P3dPaintable(); // 0x000000018CABD27C-0x000000018CABD308
	
		// Methods
		public void RemoveComponents(); // 0x000000018CABCF64-0x000000018CABD0F8
		public void ScaleSize(ref int width, ref int height); // 0x000000018CABD0F8-0x000000018CABD208
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018CABC50C-0x000000018CABC774
		private void AddPaintableTextures(Transform root); // 0x000000018CABC774-0x000000018CABC9D0
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018CABCB7C-0x000000018CABCEA8
		public void ClearAll(UnityEngine.Color color); // 0x000000018CABC9EC-0x000000018CABCA0C
		public void ClearAll(Texture texture, UnityEngine.Color color); // 0x000000018CABCA0C-0x000000018CABCB7C
		public void Register(P3dPaintableTexture paintableTexture); // 0x000000018CABCF0C-0x000000018CABCF64
		public void Unregister(P3dPaintableTexture paintableTexture); // 0x000000018CABD224-0x000000018CABD27C
		protected virtual void Awake(); // 0x000000018CABC9D0-0x000000018CABC9EC
		protected override void OnEnable(); // 0x000000018CABCEA8-0x000000018CABCF0C
		protected virtual void Start(); // 0x000000018CABD208-0x000000018CABD224
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Manager")]
	[DefaultExecutionOrder(100)]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableManager")]
	public class P3dPaintableManager : MonoBehaviour // TypeDefIndex: 86765
	{
		// Fields
		private static LinkedList<P3dPaintableManager> instances; // 0x00
		private LinkedListNode<P3dPaintableManager> instancesNode; // 0x18
	
		// Properties
		public static LinkedList<P3dPaintableManager> Instances { get; } // 0x000000018CAB73E0-0x000000018CAB7430 
	
		// Constructors
		public P3dPaintableManager(); // 0x00000001878364A0-0x00000001878364B8
		static P3dPaintableManager(); // 0x000000018CAB7364-0x000000018CAB73E0
	
		// Methods
		public static P3dPaintableManager GetOrCreateInstance(); // 0x000000018CAB69F4-0x000000018CAB6B40
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture); // 0x000000018CAB6E78-0x000000018CAB7084
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture); // 0x000000018CAB6874-0x000000018CAB69F4
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group); // 0x000000018CAB6D7C-0x000000018CAB6E78
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group); // 0x000000018CAB7084-0x000000018CAB7164
		public static P3dCommand Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture); // 0x000000018CAB7164-0x000000018CAB7218
		protected virtual void OnEnable(); // 0x000000018CAB6D00-0x000000018CAB6D7C
		protected virtual void OnDisable(); // 0x000000018CAB6C80-0x000000018CAB6D00
		protected virtual void LateUpdate(); // 0x000000018CAB6B40-0x000000018CAB6C80
		private void ClearAll(); // 0x000000018CAB6720-0x000000018CAB6874
		private void UpdateAll(); // 0x000000018CAB7218-0x000000018CAB7364
	}

	public class P3dPaintableState // TypeDefIndex: 86766
	{
		// Fields
		public RenderTexture Texture; // 0x10
		public List<P3dCommand> Commands; // 0x18
		private static Stack<P3dPaintableState> pool; // 0x00
	
		// Constructors
		public P3dPaintableState(); // 0x000000018CAB7950-0x000000018CAB79C8
		static P3dPaintableState(); // 0x000000018CAB78C4-0x000000018CAB7950
	
		// Methods
		public static P3dPaintableState Pop(); // 0x000000018CAB75AC-0x000000018CAB7660
		public void Write(RenderTexture current); // 0x000000018CAB7660-0x000000018CAB7748
		public void Write(List<P3dCommand> commands); // 0x000000018CAB7748-0x000000018CAB77A8
		public void Write(RenderTexture current, List<P3dCommand> commands); // 0x000000018CAB77A8-0x000000018CAB78C4
		private void Clear(); // 0x000000018CAB7430-0x000000018CAB7534
		public void Pool(); // 0x000000018CAB7534-0x000000018CAB75AC
	}

	[AddComponentMenu("Paint in 3D/P3D Paintable Texture")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintableTexture")]
	public class P3dPaintableTexture : MonoBehaviour // TypeDefIndex: 86776
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
		public P3dSlot Slot { get; set; } // 0x00000001845C28E0-0x00000001845C28F0 0x000000018CABC4FC-0x000000018CABC50C
		public P3dCoord Coord { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public P3dGroup Group { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public UndoRedoType UndoRedo { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public int StateLimit { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public SaveLoadType SaveLoad { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public string SaveName { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public int Width { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public int Height { get; set; } // 0x0000000187233730-0x0000000187233740 0x0000000187233740-0x0000000187233750
		public Texture Texture { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public UnityEngine.Color Color { get; set; } // 0x0000000187234DB0-0x0000000187234DC0 0x0000000187234090-0x00000001872340A0
		public RenderTextureFormat Format { get; set; } // 0x0000000182271AE0-0x0000000182271AF0 0x0000000185B8E660-0x0000000185B8E8A0
		public MipType MipMaps { get; set; } // 0x00000001872333A0-0x00000001872333B0 0x0000000187233400-0x0000000187233410
		public FilterType Filter { get; set; } // 0x0000000187233370-0x0000000187233380 0x00000001872333D0-0x00000001872333E0
		public AnisoType Aniso { get; set; } // 0x0000000187233390-0x00000001872333A0 0x00000001872333F0-0x0000000187233400
		public WrapType WrapU { get; set; } // 0x0000000187233090-0x00000001872330A0 0x0000000187233100-0x0000000187233110
		public WrapType WrapV { get; set; } // 0x00000001872330E0-0x00000001872330F0 0x0000000187233140-0x0000000187233150
		public ExistingType Existing { get; set; } // 0x0000000187233080-0x0000000187233090 0x00000001872330F0-0x0000000187233100
		public ConversionType Conversion { get; set; } // 0x000000018723DA60-0x000000018723DA70 0x000000018723DA70-0x000000018723DA80
		public Texture LocalMaskTexture { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public P3dChannel LocalMaskChannel { get; set; } // 0x00000001872333B0-0x00000001872333C0 0x0000000185FD6920-0x0000000185FD6930
		public string ShaderKeyword { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public P3dHash Hash { get; set; } // 0x0000000187235C10-0x0000000187235C20 0x000000018CABC4A8-0x000000018CABC4FC
		public bool IsDummy { get; set; } // 0x0000000187235C80-0x0000000187235C90 0x0000000187235C90-0x0000000187235CA0
		public string Output { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public static LinkedList<P3dPaintableTexture> Instances { get; } // 0x000000018CABC15C-0x000000018CABC1AC 
		public bool Activated { get; } // 0x0000000184F560B0-0x0000000184F560C0 
		public bool CanUndo { get; } // 0x000000018CABC0F4-0x000000018CABC108 
		public bool CanRedo { get; } // 0x000000018CABC09C-0x000000018CABC0F4 
		public List<P3dPaintableState> States { get; } // 0x0000000187235E40-0x0000000187235E50 
		public int StateIndex { get; } // 0x00000001872406F0-0x0000000187240700 
		public Material Material { get; } // 0x000000018CABC1AC-0x000000018CABC1DC 
		public P3dPaintable Paintable { get; } // 0x000000018CABC1DC-0x000000018CABC26C 
		public RenderTexture Current { get; set; } // 0x000000018723BB00-0x000000018723BB10 0x000000018CABC450-0x000000018CABC4A8
		public RenderTexture Preview { get; } // 0x0000000187234580-0x0000000187234590 
		public bool CommandsPending { get; } // 0x000000018CABC108-0x000000018CABC15C 
	
		// Events
		public event Action<P3dCommand> OnAddCommand {
			add; // 0x000000018CABBF7C-0x000000018CABC00C
			remove; // 0x000000018CABC330-0x000000018CABC3C0
		}
		public static event Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal {
			add; // 0x000000018CABBEB8-0x000000018CABBF7C
			remove; // 0x000000018CABC26C-0x000000018CABC330
		}
		public event Action<bool> OnModified {
			add; // 0x000000018CABC00C-0x000000018CABC09C
			remove; // 0x000000018CABC3C0-0x000000018CABC450
		}
	
		// Nested types
		public enum UndoRedoType // TypeDefIndex: 86767
		{
			None = 0,
			FullTextureCopy = 1,
			LocalCommandCopy = 2
		}
	
		public enum SaveLoadType // TypeDefIndex: 86768
		{
			Manual = 0,
			Automatic = 1,
			SemiManual = 2
		}
	
		public enum MipType // TypeDefIndex: 86769
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum FilterType // TypeDefIndex: 86770
		{
			Auto = -1,
			Point = 0,
			Bilinear = 1,
			Trilinear = 2
		}
	
		public enum AnisoType // TypeDefIndex: 86771
		{
			Auto = -1,
			Off = 0,
			One = 1,
			Four = 4,
			Eight = 8,
			Sixteen = 16
		}
	
		public enum WrapType // TypeDefIndex: 86772
		{
			Auto = -1,
			Repeat = 0,
			Clamp = 1,
			Mirror = 2,
			MirrorOnce = 3
		}
	
		public enum ExistingType // TypeDefIndex: 86773
		{
			Ignore = 0,
			Use = 1,
			UseAndKeep = 2
		}
	
		public enum ConversionType // TypeDefIndex: 86774
		{
			None = 0,
			Normal = 1,
			Premultiply = 2
		}
	
		[Serializable]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture> // TypeDefIndex: 86775
		{
			// Constructors
			public PaintableTextureEvent(); // 0x000000018CABEC6C-0x000000018CABECA8
		}
	
		// Constructors
		public P3dPaintableTexture(); // 0x000000018CABBCF4-0x000000018CABBEB8
		static P3dPaintableTexture(); // 0x000000018CABBBB4-0x000000018CABBCF4
	
		// Methods
		public static List<P3dPaintableTexture> FilterAll(P3dModel model, P3dGroup group); // 0x000000018CABA0C8-0x000000018CABA320
		[ContextMenu("Clear States")]
		public void ClearStates(); // 0x000000018CAB92AC-0x000000018CAB9360
		[ContextMenu("Store State")]
		public void StoreState(); // 0x000000018CABB790-0x000000018CABB81C
		[ContextMenu("Undo")]
		public void Undo(); // 0x000000018CABB9EC-0x000000018CABBAE4
		[ContextMenu("Redo")]
		public void Redo(); // 0x000000018CABB264-0x000000018CABB32C
		public void SetColor(string html); // 0x000000018CABB684-0x000000018CABB698
		public Vector2 GetCoord(ref P3dHit hit); // 0x000000018CABA320-0x000000018CABA354
		public Vector2 GetCoord(ref RaycastHit hit); // 0x000000018CABA354-0x000000018CABA380
		private bool StatesContainTextureOrCommands(); // 0x000000018CABB698-0x000000018CABB790
		private bool LastStateWithTextureOr0(ref int startIndex); // 0x000000018CABA988-0x000000018CABAA58
		private void RebuildFromCommands(); // 0x000000018CABAEBC-0x000000018CABB264
		private void AddState(); // 0x000000018CAB8F6C-0x000000018CAB90A8
		private void TrimFuture(); // 0x000000018CABB81C-0x000000018CABB93C
		private void TrimPast(); // 0x000000018CABB93C-0x000000018CABB9EC
		public void NotifyOnModified(bool preview); // 0x000000018CABABF4-0x000000018CABAC10
		public Texture2D GetReadableCopy(bool convertBack = false /* Metadata: 0x02645C44 */); // 0x000000018CABA42C-0x000000018CABA6DC
		public byte[] GetPngData(bool convertBack = false /* Metadata: 0x02645C45 */); // 0x000000018CABA380-0x000000018CABA42C
		public byte[] GetTgaData(bool convertBack = false /* Metadata: 0x02645C46 */); // 0x000000018CABA6DC-0x000000018CABA788
		[ContextMenu("Clear")]
		public void Clear(); // 0x000000018CAB9360-0x000000018CAB938C
		public void Clear(Texture texture, UnityEngine.Color tint, bool updateMips = true /* Metadata: 0x02645C47 */); // 0x000000018CAB938C-0x000000018CAB94C0
		[ContextMenu("Replace")]
		public void Replace(); // 0x000000018CABB408-0x000000018CABB42C
		public void Replace(Texture texture, UnityEngine.Color tint); // 0x000000018CABB32C-0x000000018CABB408
		public bool Resize(int width, int height, bool copyContents = true /* Metadata: 0x02645C48 */); // 0x000000018CABB42C-0x000000018CABB600
		[ContextMenu("Save")]
		public void Save(); // 0x000000018CABB678-0x000000018CABB684
		public void Save(string saveName); // 0x000000018CABB600-0x000000018CABB678
		[ContextMenu("Load")]
		public void Load(); // 0x000000018CABABE4-0x000000018CABABF4
		public void Load(string saveName, bool replace = true /* Metadata: 0x02645C49 */); // 0x000000018CABAB7C-0x000000018CABABE4
		public void LoadFromData(byte[] data, bool allowResize = true /* Metadata: 0x02645C4A */); // 0x000000018CABAA58-0x000000018CABAB7C
		public void HidePreview(); // 0x000000018CABA8D4-0x000000018CABA988
		public static void HideAllPreviews(); // 0x000000018CABA788-0x000000018CABA8D4
		[ContextMenu("Clear Save")]
		public void ClearSave(); // 0x000000018CAB925C-0x000000018CAB92AC
		public static void ClearSave(string saveName); // 0x000000018CAB9210-0x000000018CAB925C
		[ContextMenu("Update Material")]
		public void UpdateMaterial(); // 0x000000018CABBAE4-0x000000018CABBBB4
		[ContextMenu("Copy Size")]
		public void CopySize(); // 0x000000018CAB94C0-0x000000018CAB9564
		[ContextMenu("Copy Texture")]
		public void CopyTexture(); // 0x000000018CAB9564-0x000000018CAB95A0
		[ContextMenu("Activate")]
		public void Activate(); // 0x000000018CAB8910-0x000000018CAB8DDC
		[ContextMenu("Deactivate")]
		public void Deactivate(); // 0x000000018CAB95A0-0x000000018CAB96BC
		protected virtual void OnEnable(); // 0x000000018CABADC4-0x000000018CABAEBC
		protected virtual void OnDisable(); // 0x000000018CABACFC-0x000000018CABADC4
		protected virtual void OnApplicationPause(bool paused); // 0x000000018CABAC10-0x000000018CABAC44
		protected virtual void OnDestroy(); // 0x000000018CABAC44-0x000000018CABACFC
		public void AddCommand(P3dCommand command); // 0x000000018CAB8DDC-0x000000018CAB8F6C
		public void ClearCommands(); // 0x000000018CAB90A8-0x000000018CAB9210
		public void ExecuteCommands(bool sendNotifications, bool doSort); // 0x000000018CAB96BC-0x000000018CAB9A68
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, RenderTexture main, ref RenderTexture swap); // 0x000000018CAB9A68-0x000000018CABA0C8
	}

	public abstract class P3dPaintableTextureMonitor : MonoBehaviour // TypeDefIndex: 86777
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
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018CAB88EC-0x000000018CAB8910
		public float Interval { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public bool Async { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
		public int DownsampleSteps { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public bool Registered { get; } // 0x000000018CAB8808-0x000000018CAB8858 
		public P3dReader CurrentReader { get; } // 0x000000018226EE80-0x000000018226EE90 
	
		// Events
		public event Action OnUpdated {
			add; // 0x000000018CAB8774-0x000000018CAB8808
			remove; // 0x000000018CAB8858-0x000000018CAB88EC
		}
	
		// Constructors
		protected P3dPaintableTextureMonitor(); // 0x000000018CAB8754-0x000000018CAB8774
	
		// Methods
		public void MarkCurrentReaderAsDirty(); // 0x000000018CAB8230-0x000000018CAB8240
		[ContextMenu("Register")]
		public void Register(); // 0x000000018CAB83D8-0x000000018CAB84B0
		[ContextMenu("Unregister")]
		public void Unregister(); // 0x000000018CAB84B0-0x000000018CAB8580
		protected void InvokeOnUpdated(); // 0x000000018CAB821C-0x000000018CAB8230
		protected virtual void OnEnable(); // 0x000000018CAB833C-0x000000018CAB83D8
		protected virtual void OnDisable(); // 0x000000018CAB82A0-0x000000018CAB833C
		protected virtual void OnDestroy(); // 0x000000018CAB8240-0x000000018CAB82A0
		protected virtual void Update(); // 0x000000018CAB8580-0x000000018CAB8754
		private void HandleCompleteCurrent(NativeArray<Color32> pixels); // 0x000000018CAB8104-0x000000018CAB8208
		private void HandleModified(bool preview); // 0x000000018CAB8208-0x000000018CAB821C
		protected abstract void HandleComplete(int boost);
	}

	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor // TypeDefIndex: 86778
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
		public Mesh MaskMesh { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public int MaskSubmesh { get; set; } // 0x0000000182271AE0-0x0000000182271AF0 0x0000000185B8E660-0x0000000185B8E8A0
		public Texture MaskTexture { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public P3dChannel MaskChannel { get; set; } // 0x0000000187233090-0x00000001872330A0 0x0000000187233100-0x0000000187233110
		public int Total { get; } // 0x00000001872330E0-0x00000001872330F0 
		public P3dReader MaskReader { get; } // 0x00000001828D49D0-0x00000001828D49E0 
	
		// Constructors
		protected P3dPaintableTextureMonitorMask(); // 0x000000018CAB80F4-0x000000018CAB8104
	
		// Methods
		public void MarkMaskReaderAsDirty(); // 0x000000018CAB7BD4-0x000000018CAB7BEC
		private void HandleCompleteMask(NativeArray<Color32> pixels); // 0x000000018CAB79C8-0x000000018CAB7BD4
		protected override void OnEnable(); // 0x000000018CAB7D08-0x000000018CAB7DAC
		protected override void OnDisable(); // 0x000000018CAB7C64-0x000000018CAB7D08
		protected override void OnDestroy(); // 0x000000018CAB7BEC-0x000000018CAB7C64
		protected override void Update(); // 0x000000018CAB7DAC-0x000000018CAB80F4
	}

	[Serializable]
	public class P3dPointConnector // TypeDefIndex: 86780
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
		public float HitSpacing { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public int HitLimit { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public bool ConnectHits { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool ClipConnected { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public P3dHitCache HitCache { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		private class Link // TypeDefIndex: 86779
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
			public Link(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public P3dPointConnector(); // 0x000000018CABE118-0x000000018CABE1CC
		static P3dPointConnector(); // 0x000000018CABE08C-0x000000018CABE118
	
		// Methods
		public void ClearHitCache(); // 0x000000018CAB2C04-0x000000018CAB2C24
		public void ResetConnections(); // 0x000000018CABD624-0x000000018CABD70C
		public void BreakHits(object owner); // 0x000000018CABD518-0x000000018CABD624
		public void SubmitLastPoint(GameObject gameObject, bool preview, object owner); // 0x000000018CABD70C-0x000000018CABD95C
		public void SubmitPoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner); // 0x000000018CABD95C-0x000000018CABDEA8
		public void Update(); // 0x000000018CABDF5C-0x000000018CABE08C
		private bool TryGetLink(object owner, ref Link link); // 0x000000018CABDEA8-0x000000018CABDF5C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Read Color")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dReadColor")]
	public class P3dReadColor : MonoBehaviour, IHitCoord // TypeDefIndex: 86782
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
		public P3dGroup Group { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public bool Preview { get; set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
		public UnityEngine.Color Color { get; set; } // 0x0000000187238F60-0x0000000187238F70 0x0000000187238F70-0x0000000187238F80
		public ColorEvent OnColor { get; } // 0x000000018CABE394-0x000000018CABE404 
	
		// Nested types
		[Serializable]
		public class ColorEvent : UnityEvent<UnityEngine.Color> // TypeDefIndex: 86781
		{
			// Constructors
			public ColorEvent(); // 0x000000018CAA8A28-0x000000018CAA8A64
		}
	
		// Constructors
		public P3dReadColor(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CABE1CC-0x000000018CABE394
	}

	[Serializable]
	public class P3dReader // TypeDefIndex: 86783
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
		public bool Dirty { get; } // 0x0000000182246E50-0x0000000182246E60 
		public bool Requested { get; } // 0x000000018225E090-0x000000018225E0A0 
		public Vector2Int OriginalSize { get; } // 0x00000001829600D0-0x00000001829600E0 
		public int DownsampleSteps { get; } // 0x0000000182271C50-0x0000000182271C60 
		public Vector2Int DownsampledSize { get; } // 0x0000000182986470-0x0000000182986480 
		public int DownsampleBoost { get; } // 0x0000000182271C40-0x0000000182271C50 
	
		// Events
		public event Action<NativeArray<Color32>> OnComplete {
			add; // 0x000000018CABEB54-0x000000018CABEBE0
			remove; // 0x000000018CABEBE0-0x000000018CABEC6C
		}
	
		// Constructors
		public P3dReader(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void MarkAsDirty(); // 0x000000018723D2B0-0x000000018723D2C0
		public void UpdateRequest(); // 0x000000018CABEA70-0x000000018CABEB54
		public static bool NeedsUpdating<T>(P3dReader reader, NativeArray<T> array, RenderTexture texture, int downsampleSteps)
			where T : struct;
		public void Request(RenderTexture texture, int downsample, bool async); // 0x000000018CABE798-0x000000018CABEA70
		public void Release(); // 0x000000018CABE6F8-0x000000018CABE798
		private void CompleteDirectly(); // 0x000000018CABE404-0x000000018CABE6F8
	}

	public static class P3dSerialization // TypeDefIndex: 86784
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
		static P3dSerialization(); // 0x000000018CAC29E0-0x000000018CAC2D48
	
		// Methods
		public static void TryRegister(P3dPaintableTexture paintableTexture, P3dHash hash); // 0x000000018CAC2964-0x000000018CAC29E0
		public static void TryRegister(P3dModel model, P3dHash hash); // 0x000000018CAC25E8-0x000000018CAC2670
		public static void TryRegister(Texture texture, P3dHash hash); // 0x000000018CAC28E8-0x000000018CAC2964
		public static void TryRegister<T>(T obj, P3dHash hash, Dictionary<P3dHash, T> hashToObj, Dictionary<T, P3dHash> objToHash)
			where T : UnityEngine.Object;
		public static int TryRegister(Material material); // 0x000000018CAC2670-0x000000018CAC28E8
		private static int GetStableStringHash(string s); // 0x000000018CAC2594-0x000000018CAC25E8
	}

	[Serializable]
	public struct P3dSlot // TypeDefIndex: 86785
	{
		// Fields
		public int Index; // 0x00
		public string Name; // 0x08
	
		// Constructors
		public P3dSlot(int newIndex, string newName); // 0x000000018783C19C-0x000000018783C1AC
	
		// Methods
		public Texture FindTexture(GameObject gameObject); // 0x000000018CAC2DA8-0x000000018CAC2ED8
		public bool IsTransformed(GameObject gameObject); // 0x000000018CAC2F04-0x000000018CAC30B4
		public override bool Equals(object obj); // 0x000000018CAC2D48-0x000000018CAC2DA8
		public override int GetHashCode(); // 0x000000018CAC2ED8-0x000000018CAC2F04
		public static bool operator ==(P3dSlot a, P3dSlot b); // 0x000000018CAC30B4-0x000000018CAC30D0
		public static bool operator !=(P3dSlot a, P3dSlot b); // 0x000000018CAC30D0-0x000000018CAC30EC
	}

	public static class P3dStateManager // TypeDefIndex: 86786
	{
		// Properties
		public static bool CanUndo { get; } // 0x000000018CAC3738-0x000000018CAC3884 
		public static bool CanRedo { get; } // 0x000000018CAC35EC-0x000000018CAC3738 
	
		// Methods
		public static void StoreAllStates(); // 0x000000018CAC336C-0x000000018CAC34AC
		public static void ClearAllStates(); // 0x000000018CAC30EC-0x000000018CAC322C
		public static void UndoAll(); // 0x000000018CAC34AC-0x000000018CAC35EC
		public static void RedoAll(); // 0x000000018CAC322C-0x000000018CAC336C
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Texture Hash")]
	[DefaultExecutionOrder(-200)]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dTextureHash")]
	public class P3dTextureHash : MonoBehaviour // TypeDefIndex: 86787
	{
		// Fields
		[SerializeField]
		private Texture texture; // 0x18
		[SerializeField]
		private P3dHash hash; // 0x20
	
		// Properties
		public Texture Texture { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public P3dHash Hash { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018CAC3928-0x000000018CAC39B8
	
		// Constructors
		public P3dTextureHash(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018CAC38D4-0x000000018CAC3928
		protected virtual void OnDestroy(); // 0x000000018CAC3884-0x000000018CAC38D4
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Decal")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintDecal")]
	public class P3dPaintDecal : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 86788
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
		public LayerMask Layers { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public P3dModel TargetModel { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public P3dGroup Group { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public P3dPaintableTexture TargetTexture { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public P3dBlendMode BlendMode { get; set; } // 0x0000000187253ED0-0x0000000187253F00 0x000000018CAC0548-0x000000018CAC0574
		public Texture Texture { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public Texture Shape { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public P3dChannel ShapeChannel { get; set; } // 0x0000000187233080-0x0000000187233090 0x00000001872330F0-0x0000000187233100
		public UnityEngine.Color Color { get; set; } // 0x0000000187253F00-0x0000000187253F10 0x0000000187253F10-0x0000000187253F20
		public float Opacity { get; set; } // 0x000000018723CA50-0x000000018723CA60 0x000000018723CA80-0x000000018723CA90
		public float Angle { get; set; } // 0x000000018723B920-0x000000018723B930 0x000000018723B940-0x000000018723B950
		public Vector3 Scale { get; set; } // 0x000000018723EC70-0x000000018723EC90 0x000000018723ECD0-0x000000018723ECF0
		public float Radius { get; set; } // 0x0000000187250E40-0x0000000187250E50 0x0000000187250F10-0x0000000187250F20
		public float Hardness { get; set; } // 0x000000018723F560-0x000000018723F570 0x000000018723F650-0x000000018723F660
		public float Wrapping { get; set; } // 0x000000018723BAE0-0x000000018723BAF0 0x000000018723BB40-0x000000018723BB50
		public float NormalFront { get; set; } // 0x000000018723BB10-0x000000018723BB20 0x000000018723BB60-0x000000018723BB70
		public float NormalBack { get; set; } // 0x000000018723F570-0x000000018723F580 0x0000000187234DE0-0x0000000187234DF0
		public float NormalFade { get; set; } // 0x000000018723F5B0-0x000000018723F5C0 0x000000018723F690-0x000000018723F6A0
		public Texture TileTexture { get; set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		public Transform TileTransform { get; set; } // 0x000000018723BB00-0x000000018723BB10 0x0000000188D9C9D0-0x0000000188D9C9E4
		public float TileOpacity { get; set; } // 0x000000018723B6F0-0x000000018723B700 0x000000018723B730-0x000000018723B740
		public float TileTransition { get; set; } // 0x000000018723B6D0-0x000000018723B6E0 0x000000018723B710-0x000000018723B720
		public P3dModifierList Modifiers { get; } // 0x000000018CAC04E0-0x000000018CAC0548 
	
		// Constructors
		public P3dPaintDecal(); // 0x000000018CAC03B4-0x000000018CAC04E0
	
		// Methods
		[ContextMenu("Flip Horizontal")]
		public void FlipHorizontal(); // 0x0000000187253E70-0x0000000187253E90
		[ContextMenu("Flip Vertical")]
		public void FlipVertical(); // 0x0000000187253E90-0x0000000187253EB0
		public void IncrementOpacity(float delta); // 0x000000018CAC0340-0x000000018CAC0364
		public void IncrementAngle(float degrees); // 0x000000018CAC0300-0x000000018CAC0340
		public void MultiplyScale(float multiplier); // 0x000000018CAC0364-0x000000018CAC03B4
		public void MultiplyHardness(float multiplier); // 0x0000000187253EB0-0x0000000187253ED0
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018CABF95C-0x000000018CABFBD0
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018CABF6F4-0x000000018CABF95C
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018CABFECC-0x000000018CAC016C
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018CABFBD0-0x000000018CABFECC
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CABF388-0x000000018CABF6F4
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation); // 0x000000018CABEE94-0x000000018CABF388
		private void HandleMaskCommon(Vector3 worldPosition); // 0x000000018CAC016C-0x000000018CAC0300
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Fill")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintFill")]
	public class P3dPaintFill : MonoBehaviour, IHitCoord // TypeDefIndex: 86789
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
		public P3dGroup Group { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public P3dBlendMode BlendMode { get; set; } // 0x0000000187253F20-0x0000000187253F50 0x000000018CAC09D4-0x000000018CAC0A00
		public Texture Texture { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public UnityEngine.Color Color { get; set; } // 0x000000018724F4E0-0x000000018724F4F0 0x0000000187233C80-0x0000000187233C90
		public float Opacity { get; set; } // 0x000000018723E550-0x000000018723E560 0x000000018723E540-0x000000018723E550
		public float Minimum { get; set; } // 0x0000000187253CF0-0x0000000187253D00 0x0000000187253D00-0x0000000187253D10
		public P3dModifierList Modifiers { get; } // 0x000000018CAC0978-0x000000018CAC09D4 
	
		// Constructors
		public P3dPaintFill(); // 0x000000018CAC08BC-0x000000018CAC0978
	
		// Methods
		public void IncrementOpacity(float delta); // 0x000000018CAC08A0-0x000000018CAC08BC
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CAC0574-0x000000018CAC08A0
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplace")]
	public class P3dPaintReplace : MonoBehaviour, IHitCoord // TypeDefIndex: 86790
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
		public P3dGroup Group { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public Texture Texture { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public UnityEngine.Color Color { get; set; } // 0x000000018723D770-0x000000018723D780 0x000000018723D780-0x000000018723D790
		public P3dModifierList Modifiers { get; } // 0x000000018CAC0F6C-0x000000018CAC0FC8 
	
		// Constructors
		public P3dPaintReplace(); // 0x000000018CAC0F34-0x000000018CAC0F6C
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CAC0C84-0x000000018CAC0F34
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Replace Channels")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintReplaceChannels")]
	public class P3dPaintReplaceChannels : MonoBehaviour, IHitCoord // TypeDefIndex: 86791
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
		public P3dGroup Group { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public Texture TextureR { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Texture TextureG { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public Texture TextureB { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public Texture TextureA { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public Vector4 ChannelR { get; set; } // 0x000000018723E4C0-0x000000018723E4D0 0x0000000187234080-0x0000000187234090
		public Vector4 ChannelG { get; set; } // 0x0000000187239B00-0x0000000187239B10 0x0000000187234080-0x0000000187234090
		public Vector4 ChannelB { get; set; } // 0x000000018724F4E0-0x000000018724F4F0 0x0000000187234080-0x0000000187234090
		public Vector4 ChannelA { get; set; } // 0x000000018723DAE0-0x000000018723DAF0 0x0000000187234080-0x0000000187234090
	
		// Constructors
		public P3dPaintReplaceChannels(); // 0x000000018CAC0C54-0x000000018CAC0C84
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CAC0A00-0x000000018CAC0C54
	}

	[AddComponentMenu("Paint in 3D/Hit/P3D Paint Sphere")]
	[HelpURL("https://carloswilkes.com/Documentation/PaintIn3D#P3dPaintSphere")]
	public class P3dPaintSphere : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 86792
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
		public LayerMask Layers { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public P3dGroup Group { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public P3dModel TargetModel { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public P3dPaintableTexture TargetTexture { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public P3dBlendMode BlendMode { get; set; } // 0x0000000187253F70-0x0000000187253FA0 0x000000018CAC2568-0x000000018CAC2594
		public UnityEngine.Color Color { get; set; } // 0x0000000187253FA0-0x0000000187253FB0 0x0000000187233C70-0x0000000187233C80
		public float Opacity { get; set; } // 0x000000018723C6E0-0x000000018723C6F0 0x000000018723C710-0x000000018723C720
		public float Angle { get; set; } // 0x0000000187235DD0-0x0000000187235DE0 0x000000018723C730-0x000000018723C740
		public Vector3 Scale { get; set; } // 0x000000018723F7F0-0x000000018723F810 0x000000018723F840-0x000000018723F860
		public float Radius { get; set; } // 0x000000018723B530-0x000000018723B540 0x000000018723B550-0x000000018723B560
		public float Hardness { get; set; } // 0x000000018723DAD0-0x000000018723DAE0 0x000000018723DB10-0x000000018723DB20
		public Texture TileTexture { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public Transform TileTransform { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public float TileOpacity { get; set; } // 0x0000000187250E40-0x0000000187250E50 0x0000000187250F10-0x0000000187250F20
		public float TileTransition { get; set; } // 0x000000018723F560-0x000000018723F570 0x000000018723F650-0x000000018723F660
		public P3dModifierList Modifiers { get; } // 0x000000018CAC2500-0x000000018CAC2568 
	
		// Constructors
		public P3dPaintSphere(); // 0x000000018CAC23F8-0x000000018CAC2500
	
		// Methods
		public void IncrementOpacity(float delta); // 0x000000018CAC238C-0x000000018CAC23A8
		public void IncrementAngle(float degrees); // 0x000000018CAC2350-0x000000018CAC238C
		public void MultiplyRadius(float multiplier); // 0x0000000187253F50-0x0000000187253F70
		public void MultiplyScale(float multiplier); // 0x000000018CAC23A8-0x000000018CAC23F8
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation); // 0x000000018CAC19AC-0x000000018CAC1C20
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip); // 0x000000018CAC1744-0x000000018CAC19AC
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation); // 0x000000018CAC1F1C-0x000000018CAC21BC
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip); // 0x000000018CAC1C20-0x000000018CAC1F1C
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation); // 0x000000018CAC13D8-0x000000018CAC1744
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation); // 0x000000018CAC0FC8-0x000000018CAC13D8
		private void HandleMaskCommon(Vector3 worldPosition); // 0x000000018CAC21BC-0x000000018CAC2350
	}
}
