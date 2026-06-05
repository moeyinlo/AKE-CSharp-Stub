/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using CW.Common;
using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Image 43: PaintIn3D.dll - Assembly: PaintIn3D, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56956-57119

namespace PaintIn3D
{
	public class P3dButtonClearAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 56957
	{
		// Fields
		private bool clearStates; // 0x18
	
		// Properties
		public bool ClearStates { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
	
		// Constructors
		public P3dButtonClearAll() {} // 0x00000001864717D0-0x00000001864717DC
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018B4176CC-0x000000018B4176D4
		public void ClearAll() {} // 0x000000018B417540-0x000000018B4176CC
	}

	public class P3dButtonRedoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 56958
	{
		// Constructors
		public P3dButtonRedoAll() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018B4176D4-0x000000018B4176DC
		public void RedoAll() {} // 0x000000018B4176D4-0x000000018B4176DC
		protected virtual void Update() {} // 0x000000018B4176DC-0x000000018B417778
	}

	public class P3dButtonUndoAll : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 56959
	{
		// Constructors
		public P3dButtonUndoAll() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018B417778-0x000000018B417780
		public void UndoAll() {} // 0x000000018B417778-0x000000018B417780
		protected virtual void Update() {} // 0x000000018B417780-0x000000018B41781C
	}

	public class P3dChangeCounterEvent : MonoBehaviour // TypeDefIndex: 56960
	{
		// Fields
		private List<P3dChangeCounter> counters; // 0x18
		private Vector2 range; // 0x20
		private bool inside; // 0x28
		private UnityEvent onInside; // 0x30
		private UnityEvent onOutside; // 0x38
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x000000018B4178C8-0x000000018B41794C 
		public Vector2 Range { get => default; set {} } // 0x0000000185FD22C0-0x0000000185FD22E0 0x00000001813BDF70-0x00000001813BDF80
		public bool Inside { get => default; set {} } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public UnityEvent OnInside { get => default; } // 0x000000018B41794C-0x000000018B4179BC 
		public UnityEvent OnOutside { get => default; } // 0x000000018B4179BC-0x000000018B417A2C 
		public float Ratio { get => default; } // 0x000000018B417A2C-0x000000018B417A94 
	
		// Constructors
		public P3dChangeCounterEvent() {} // 0x000000018B4178B0-0x000000018B4178C8
	
		// Methods
		protected virtual void Update() {} // 0x000000018B41788C-0x000000018B4178B0
		private void UpdateInside(float ratio) {} // 0x000000018B41781C-0x000000018B41788C
	}

	public class P3dChangeCounterFill : MonoBehaviour // TypeDefIndex: 56961
	{
		// Fields
		private List<P3dChangeCounter> counters; // 0x18
		private bool inverse; // 0x20
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x000000018B417B7C-0x000000018B417C00 
		public bool Inverse { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		public P3dChangeCounterFill() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B417A94-0x000000018B417ADC
		protected virtual void Update() {} // 0x000000018B417ADC-0x000000018B417B7C
	}

	public class P3dChangeCounterText : MonoBehaviour // TypeDefIndex: 56963
	{
		// Fields
		private List<P3dChangeCounter> counters; // 0x18
		private bool inverse; // 0x20
		private int decimalPlaces; // 0x24
		private string format; // 0x28
		private StringEvent onString; // 0x30
	
		// Properties
		public List<P3dChangeCounter> Counters { get => default; } // 0x00000001813EE9B0-0x00000001813EE9C0 
		public bool Inverse { get => default; set {} } // 0x0000000181424940-0x0000000181424950 0x00000001813ECBF0-0x00000001813ECC00
		public int DecimalPlaces { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x0000000181424480-0x0000000181424490
		public string Format { get => default; set {} } // 0x000000018B417E98-0x000000018B417F08 0x00000001813B8590-0x00000001813B85A0
		public StringEvent OnString { get => default; } // 0x000000018B417C00-0x000000018B417DCC 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 56962
		{
			// Constructors
			public StringEvent() {} // 0x000000018B417E14-0x000000018B417E98
		}
	
		// Constructors
		public P3dChangeCounterText() {} // 0x000000018B429378-0x000000018B429454
	
		// Methods
		protected virtual void Update() {} // 0x000000018B417DCC-0x000000018B417E14
	}

	public class P3dChannelCounterEvent : MonoBehaviour // TypeDefIndex: 56965
	{
		// Fields
		private List<P3dChannelCounter> counters; // 0x18
		private ChannelType channel; // 0x20
		private Vector2 range; // 0x24
		private bool inside; // 0x2C
		private UnityEvent onInside; // 0x30
		private UnityEvent onOutside; // 0x38
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x000000018B417FB4-0x000000018B418038 
		public ChannelType Channel { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public Vector2 Range { get => default; set {} } // 0x0000000185FB1F70-0x0000000185FB1F90 0x0000000185FD22E0-0x0000000185FD22F0
		public bool Inside { get => default; set {} } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
		public UnityEvent OnInside { get => default; } // 0x000000018B418038-0x000000018B4180A8 
		public UnityEvent OnOutside { get => default; } // 0x000000018B4180A8-0x000000018B418118 
		public float Ratio { get => default; } // 0x000000018B418118-0x000000018B4181EC 
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 56964
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterEvent() {} // 0x000000018B417F9C-0x000000018B417FB4
	
		// Methods
		protected virtual void Update() {} // 0x000000018B417F78-0x000000018B417F9C
		private void UpdateInside(float ratio) {} // 0x000000018B417F08-0x000000018B417F78
	}

	public class P3dChannelCounterFill : MonoBehaviour // TypeDefIndex: 56967
	{
		// Fields
		private List<P3dChannelCounter> counters; // 0x18
		private ChannelType channel; // 0x20
		private bool inverse; // 0x24
		[NonSerialized]
		private Image cachedImage; // 0x28
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x000000018B418340-0x000000018B4183C4 
		public ChannelType Channel { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public bool Inverse { get => default; set {} } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
	
		// Nested types
		public enum ChannelType // TypeDefIndex: 56966
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterFill() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B4181EC-0x000000018B418234
		protected virtual void Update() {} // 0x000000018B418234-0x000000018B418340
	}

	public class P3dChannelCounterText : MonoBehaviour // TypeDefIndex: 56970
	{
		// Fields
		private List<P3dChannelCounter> counters; // 0x18
		private ChannelType channel; // 0x20
		private bool inverse; // 0x24
		private int decimalPlaces; // 0x28
		private string format; // 0x30
		private StringEvent onString; // 0x38
	
		// Properties
		public List<P3dChannelCounter> Counters { get => default; } // 0x00000001813B9430-0x00000001813B9440 
		public ChannelType Channel { get => default; set {} } // 0x0000000185FB0820-0x0000000185FB0830 0x00000001813B88B0-0x00000001813B88C0
		public bool Inverse { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x0000000185FB0810-0x0000000185FB0820
		public int DecimalPlaces { get => default; set {} } // 0x00000001864721F0-0x0000000186472200 0x0000000181C9AC80-0x0000000181C9AC90
		public string Format { get => default; set {} } // 0x000000018B4186CC-0x000000018B41873C 0x00000001813B51D0-0x00000001813B51E0
		public StringEvent OnString { get => default; } // 0x000000018B4183C4-0x000000018B418600 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 56968
		{
			// Constructors
			public StringEvent() {} // 0x000000018B418648-0x000000018B4186CC
		}
	
		public enum ChannelType // TypeDefIndex: 56969
		{
			Red = 0,
			Green = 1,
			Blue = 2,
			Alpha = 3
		}
	
		// Constructors
		public P3dChannelCounterText() {} // 0x000000018B42933C-0x000000018B429378
	
		// Methods
		protected virtual void Update() {} // 0x000000018B418600-0x000000018B418648
	}

	public class P3dColorCounterEvent : MonoBehaviour // TypeDefIndex: 56971
	{
		// Fields
		private List<P3dColorCounter> counters; // 0x18
		private P3dColor color; // 0x20
		private Vector2 range; // 0x28
		private bool inside; // 0x30
		private UnityEvent onInside; // 0x38
		private UnityEvent onOutside; // 0x40
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x000000018B4187E8-0x000000018B41886C 
		public P3dColor Color { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Vector2 Range { get => default; set {} } // 0x0000000185FB2D60-0x0000000185FB2D80 0x0000000185FB0620-0x0000000185FB0630
		public bool Inside { get => default; set {} } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public UnityEvent OnInside { get => default; } // 0x000000018B41886C-0x000000018B4188DC 
		public UnityEvent OnOutside { get => default; } // 0x000000018B4188DC-0x000000018B41894C 
		public float Ratio { get => default; } // 0x000000018B41894C-0x000000018B4189C0 
	
		// Constructors
		public P3dColorCounterEvent() {} // 0x000000018B4187D0-0x000000018B4187E8
	
		// Methods
		protected virtual void Update() {} // 0x000000018B4187AC-0x000000018B4187D0
		private void UpdateInside(float ratio) {} // 0x000000018B41873C-0x000000018B4187AC
	}

	public class P3dColorCounterFill : MonoBehaviour // TypeDefIndex: 56972
	{
		// Fields
		private List<P3dColorCounter> counters; // 0x18
		private P3dColor color; // 0x20
		private bool inverse; // 0x28
		[NonSerialized]
		private Image cachedImage; // 0x30
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x000000018B418ABC-0x000000018B418B40 
		public P3dColor Color { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public bool Inverse { get => default; set {} } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
	
		// Constructors
		public P3dColorCounterFill() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B4189C0-0x000000018B418A08
		protected virtual void Update() {} // 0x000000018B418A08-0x000000018B418ABC
	}

	public class P3dColorCounterText : MonoBehaviour // TypeDefIndex: 56974
	{
		// Fields
		private List<P3dColorCounter> counters; // 0x18
		private P3dColor color; // 0x20
		private bool inverse; // 0x28
		private int decimalPlaces; // 0x2C
		private string format; // 0x30
		private StringEvent onString; // 0x38
	
		// Properties
		public List<P3dColorCounter> Counters { get => default; } // 0x000000018646EE40-0x000000018646EE50 
		public P3dColor Color { get => default; set {} } // 0x00000001813B4840-0x00000001813B4850 0x00000001813B31A0-0x00000001813B31B0
		public bool Inverse { get => default; set {} } // 0x0000000185FB0640-0x0000000185FB0650 0x00000001813B31B0-0x00000001813B31C0
		public int DecimalPlaces { get => default; set {} } // 0x00000001864721F0-0x0000000186472200 0x0000000185FB0630-0x0000000185FB0640
		public string Format { get => default; set {} } // 0x000000018B418DDC-0x000000018B418E4C 0x00000001813B51D0-0x00000001813B51E0
		public StringEvent OnString { get => default; } // 0x000000018B418B40-0x000000018B418D10 
	
		// Nested types
		[Serializable]
		public class StringEvent : UnityEvent<string> // TypeDefIndex: 56973
		{
			// Constructors
			public StringEvent() {} // 0x000000018B418D58-0x000000018B418DDC
		}
	
		// Constructors
		public P3dColorCounterText() {} // 0x000000018B429300-0x000000018B42933C
	
		// Methods
		protected virtual void Update() {} // 0x000000018B418D10-0x000000018B418D58
	}

	public class P3dPaintDebug : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad // TypeDefIndex: 56975
	{
		// Fields
		private UnityEngine.Color color; // 0x18
		private float duration; // 0x28
		private float size; // 0x2C
	
		// Properties
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FB30D0-0x0000000185FB30E0 0x0000000185FB30E0-0x0000000185FB30F0
		public float Duration { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public float Size { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x0000000185FB09B0-0x0000000185FB09C0
	
		// Constructors
		public P3dPaintDebug() {} // 0x000000018B42598C-0x000000018B4259C4
	
		// Methods
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x000000018B425388-0x000000018B425530
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x000000018B425268-0x000000018B425388
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018B425768-0x000000018B42598C
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018B425530-0x000000018B425768
		private UnityEngine.Color GetColor(bool preview, float pressure, UnityEngine.Color color) => default; // 0x000000018B425224-0x000000018B425268
		private void DrawArrow(Vector3 position, Quaternion rotation, UnityEngine.Color tint) {} // 0x000000018B424D5C-0x000000018B425224
	}

	public class P3dCommandDecal : P3dCommand // TypeDefIndex: 56976
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
		public override bool RequireMesh { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		static P3dCommandDecal() {} // 0x000000018B41A3B4-0x000000018B41AA1C
		public P3dCommandDecal() {} // 0x000000018B41AA1C-0x000000018B41AA5C
	
		// Methods
		public override void Apply(Material material) {} // 0x000000018B418F6C-0x000000018B419704
		public override void Pool() {} // 0x000000018B419770-0x000000018B4197E0
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x000000018B41A184-0x000000018B41A3B4
		public override P3dCommand SpawnCopy() => default; // 0x000000018B419E00-0x000000018B41A184
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x000000018B418F10-0x000000018B418F6C
		public void SetShape(Quaternion rotation, Vector3 size, float angle) {} // 0x000000018B419C78-0x000000018B419E00
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x0207D4A4 */) {} // 0x0000000185FD2370-0x0000000185FD23A0
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x0207D4A5 */, bool clip = false /* Metadata: 0x0207D4A6 */) {} // 0x0000000185FD23A0-0x0000000185FD23F0
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x0207D4A7 */) {} // 0x0000000185FD22F0-0x0000000185FD2370
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x0207D4A8 */, bool clip = false /* Metadata: 0x0207D4A9 */) {} // 0x0000000185FD23F0-0x0000000185FD2470
		public void ClearMask() {} // 0x000000018B419704-0x000000018B419770
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch) {} // 0x000000018B4197E0-0x000000018B4198DC
		public void ApplyAspect(Texture texture) {} // 0x000000018B418E4C-0x000000018B418F10
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition) {} // 0x000000018B4198DC-0x000000018B419C78
	}

	public class P3dCommandFill : P3dCommand // TypeDefIndex: 56977
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
		public override bool RequireMesh { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		static P3dCommandFill() {} // 0x000000018B41B28C-0x000000018B41B4C4
		public P3dCommandFill() {} // 0x000000018B41B4C4-0x000000018B41B504
	
		// Methods
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) => default; // 0x000000018B41AE50-0x000000018B41AFB8
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) {} // 0x000000018B41AC04-0x000000018B41AE50
		public override void Apply(Material material) {} // 0x000000018B41AA5C-0x000000018B41AC04
		public override void Pool() {} // 0x000000018B41AFB8-0x000000018B41B028
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x0000000185492010-0x0000000185492020
		public override P3dCommand SpawnCopy() => default; // 0x000000018B41B188-0x000000018B41B28C
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x000000018B418F10-0x000000018B418F6C
		public Material SetMaterial(P3dBlendMode blendMode, Texture texture, UnityEngine.Color color, float opacity, float minimum) => default; // 0x000000018B41B028-0x000000018B41B188
	}

	public class P3dCommandReplace : P3dCommand // TypeDefIndex: 56978
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
		public override bool RequireMesh { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		static P3dCommandReplace() {} // 0x000000018B41C47C-0x000000018B41C604
		public P3dCommandReplace() {} // 0x000000018B41C604-0x000000018B41C644
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint) {} // 0x000000018B41C1B8-0x000000018B41C2A8
		public static void BlitFast(RenderTexture renderTexture, Texture texture, UnityEngine.Color tint) {} // 0x000000018B41C0E4-0x000000018B41C1B8
		public override void Apply(Material material) {} // 0x000000018B41BFD8-0x000000018B41C0E4
		public override void Pool() {} // 0x000000018B41C2A8-0x000000018B41C318
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x0000000185492010-0x0000000185492020
		public override P3dCommand SpawnCopy() => default; // 0x000000018B41C3E4-0x000000018B41C47C
		public Material SetMaterial(Texture texture, UnityEngine.Color color) => default; // 0x000000018B41C318-0x000000018B41C3E4
	}

	public class P3dCommandReplaceChannels : P3dCommand // TypeDefIndex: 56979
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
		public override bool RequireMesh { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		static P3dCommandReplaceChannels() {} // 0x000000018B41BD08-0x000000018B41BF98
		public P3dCommandReplaceChannels() {} // 0x000000018B41BF98-0x000000018B41BFD8
	
		// Methods
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA, Vector4 channels) {} // 0x000000018B41B868-0x000000018B41B9E8
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA) {} // 0x000000018B41B704-0x000000018B41B868
		public override void Apply(Material material) {} // 0x000000018B41B504-0x000000018B41B704
		public override void Pool() {} // 0x000000018B41B9E8-0x000000018B41BA58
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x0000000185492010-0x0000000185492020
		public override P3dCommand SpawnCopy() => default; // 0x000000018B41BBE8-0x000000018B41BD08
		public Material SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA) => default; // 0x000000018B41BA58-0x000000018B41BBE8
	}

	public class P3dCommandSphere : P3dCommand // TypeDefIndex: 56980
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
		public override bool RequireMesh { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		static P3dCommandSphere() {} // 0x000000018B41D788-0x000000018B41DCB0
		public P3dCommandSphere() {} // 0x000000018B41DCB0-0x000000018B41DCF0
	
		// Methods
		public override void Apply(Material material) {} // 0x000000018B41C708-0x000000018B41CCD4
		public override void Pool() {} // 0x000000018B41CD40-0x000000018B41CDB0
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix) {} // 0x000000018B41D5C0-0x000000018B41D788
		public override P3dCommand SpawnCopy() => default; // 0x000000018B41D2F8-0x000000018B41D5C0
		public override void Apply(P3dPaintableTexture paintableTexture) {} // 0x000000018B418F10-0x000000018B418F6C
		public void SetLocation(Vector3 position, bool in3D = true /* Metadata: 0x0207D4AA */) {} // 0x0000000185FD2370-0x0000000185FD23A0
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true /* Metadata: 0x0207D4AB */, bool clip = false /* Metadata: 0x0207D4AC */) {} // 0x0000000185FD23A0-0x0000000185FD23F0
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true /* Metadata: 0x0207D4AD */) {} // 0x0000000185FD22F0-0x0000000185FD2370
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true /* Metadata: 0x0207D4AE */, bool clip = false /* Metadata: 0x0207D4AF */) {} // 0x0000000185FD23F0-0x0000000185FD2470
		public void ClearMask() {} // 0x000000018B41CCD4-0x000000018B41CD40
		public void SetMask(Matrix4x4 matrix, Texture shape, P3dChannel channel, Vector3 stretch) {} // 0x000000018B41CDB0-0x000000018B41CEAC
		public void ApplyAspect(Texture texture) {} // 0x000000018B41C644-0x000000018B41C708
		public void SetShape(float radius) {} // 0x000000018B41D22C-0x000000018B41D2F8
		public void SetShape(Quaternion rotation, Vector3 size, float angle) {} // 0x000000018B41D0F0-0x000000018B41D22C
		public void SetMaterial(P3dBlendMode blendMode, float hardness, UnityEngine.Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity, float tileTransition) {} // 0x000000018B41CEAC-0x000000018B41D0F0
	}

	public class P3dHitBetween : MonoBehaviour // TypeDefIndex: 56985
	{
		// Fields
		private PhaseType paintIn; // 0x18
		private float interval; // 0x1C
		private Transform pointA; // 0x20
		private Transform pointB; // 0x28
		private float fraction; // 0x30
		private LayerMask layers; // 0x34
		private OrientationType orientation; // 0x38
		private Camera _camera; // 0x40
		private Transform customTransform; // 0x48
		private NormalType normal; // 0x50
		private float offset; // 0x54
		private bool preview; // 0x58
		private int priority; // 0x5C
		private float pressure; // 0x60
		private EmitType emit; // 0x64
		private Transform point; // 0x68
		private LineRenderer line; // 0x70
		private P3dPointConnector connector; // 0x78
		[NonSerialized]
		private float current; // 0x80
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float Interval { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public Transform PointA { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Transform PointB { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public float Fraction { get => default; } // 0x0000000185FB0BE0-0x0000000185FB0BF0 
		public LayerMask Layers { get => default; set {} } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		public OrientationType Orientation { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public Camera Camera { get => default; set {} } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public Transform CustomTransform { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public NormalType Normal { get => default; set {} } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		public float Offset { get => default; set {} } // 0x0000000183F80440-0x0000000183F80450 0x0000000183F804D0-0x0000000183F804E0
		public bool Preview { get => default; set {} } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
		public int Priority { get => default; set {} } // 0x0000000183F80460-0x0000000183F80470 0x0000000183F804F0-0x0000000183F80500
		public float Pressure { get => default; set {} } // 0x0000000185FB2200-0x0000000185FB2210 0x0000000185FB2230-0x0000000185FB2240
		public EmitType Draw { get => default; set {} } // 0x0000000185FB2020-0x0000000185FB2030 0x0000000185FB2030-0x0000000185FB2040
		public Transform Point { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public LineRenderer Line { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public P3dPointConnector Connector { get => default; } // 0x000000018B41E988-0x000000018B41E9F8 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 56981
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 56982
		{
			WorldUp = 0,
			CameraUp = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum NormalType // TypeDefIndex: 56983
		{
			HitNormal = 0,
			RayDirection = 1
		}
	
		public enum EmitType // TypeDefIndex: 56984
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		// Constructors
		public P3dHitBetween() {} // 0x000000018B41E964-0x000000018B41E988
	
		// Methods
		public void ManuallyHitNow() {} // 0x000000018B41DFA4-0x000000018B41DFB0
		public void ClearHitCache() {} // 0x000000018B41DF64-0x000000018B41DF88
		public void ResetConnections() {} // 0x000000018B41E098-0x000000018B41E0B8
		protected virtual void OnEnable() {} // 0x000000018B41E074-0x000000018B41E098
		protected virtual void OnDisable() {} // 0x000000018B41DFB0-0x000000018B41E074
		protected virtual void Update() {} // 0x000000018B41E914-0x000000018B41E964
		protected virtual void LateUpdate() {} // 0x000000018B41DF9C-0x000000018B41DFA4
		protected virtual void FixedUpdate() {} // 0x000000018B41DF88-0x000000018B41DF9C
		private void SubmitHit(bool preview) {} // 0x000000018B41E0B8-0x000000018B41E6B8
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, out Vector3 finalPosition, out Quaternion finalRotation) {
			finalPosition = default;
			finalRotation = default;
		} // 0x000000018B41DCF0-0x000000018B41DF64
		private void UpdatePointAndLine() {} // 0x000000018B41E728-0x000000018B41E914
		private void UpdateHit() {} // 0x000000018B41E6B8-0x000000018B41E728
	}

	public class P3dHitCache // TypeDefIndex: 56986
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
		public bool Cached { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
		// Constructors
		public P3dHitCache() {} // 0x000000018B41F690-0x000000018B41F834
		static P3dHitCache() {} // 0x000000018B41F604-0x000000018B41F690
	
		// Methods
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation) {} // 0x000000018B41F07C-0x000000018B41F1A0
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x000000018B41EF1C-0x000000018B41F07C
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation) {} // 0x000000018B41F4B4-0x000000018B41F604
		public void InvokeTriangle(GameObject gameObject, bool preview, int priority, float pressure, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018B41F32C-0x000000018B41F4B4
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018B41F1A0-0x000000018B41F32C
		public void InvokeCoord(GameObject gameObject, bool preview, int priority, float pressure, P3dHit hit, Quaternion rotation) {} // 0x000000018B41EDF0-0x000000018B41EF1C
		public void Clear() {} // 0x000000018B41ED20-0x000000018B41EDF0
		private void Cache(GameObject gameObject) {} // 0x000000018B41E9F8-0x000000018B41ED20
	}

	public class P3dHitCollisions : MonoBehaviour // TypeDefIndex: 56990
	{
		// Fields
		private EmitType emit; // 0x18
		private float raycastDistance; // 0x1C
		private LayerMask layers; // 0x20
		private bool onlyUseFirstContact; // 0x24
		private float delay; // 0x28
		private OrientationType orientation; // 0x2C
		private Camera _camera; // 0x30
		private bool preview; // 0x38
		private float threshold; // 0x3C
		private PressureType pressureMode; // 0x40
		private float pressureMin; // 0x44
		private float pressureMax; // 0x48
		private float pressureConstant; // 0x4C
		private float pressureMultiplier; // 0x50
		private float offset; // 0x54
		private int priority; // 0x58
		private GameObject root; // 0x60
		private float cooldown; // 0x68
		[NonSerialized]
		private P3dHitCache hitCache; // 0x70
	
		// Properties
		public EmitType Emit { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float RaycastDistance { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public LayerMask Layers { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public bool OnlyUseFirstContact { get => default; set {} } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
		public float Delay { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public OrientationType Orientation { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public Camera Camera { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public bool Preview { get => default; set {} } // 0x0000000185FB0700-0x0000000185FB0710 0x0000000185FAFE20-0x0000000185FAFE30
		public float Threshold { get => default; set {} } // 0x0000000185FB0580-0x0000000185FB0590 0x0000000185FB05E0-0x0000000185FB05F0
		public PressureType PressureMode { get => default; set {} } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public float PressureMin { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public float PressureMax { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float PressureConstant { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float PressureMultiplier { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public float Offset { get => default; set {} } // 0x0000000183F80440-0x0000000183F80450 0x0000000183F804D0-0x0000000183F804E0
		public int Priority { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public GameObject Root { get => default; set {} } // 0x0000000185FB0530-0x0000000185FB0540 0x000000018B41FFF8-0x000000018B420028
		public P3dHitCache HitCache { get => default; } // 0x0000000181460F70-0x0000000181460F80 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 56987
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 56988
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum PressureType // TypeDefIndex: 56989
		{
			Constant = 0,
			ImpactSpeed = 1
		}
	
		// Constructors
		public P3dHitCollisions() {} // 0x000000018B41FF54-0x000000018B41FFF8
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B41FDB0-0x000000018B41FDD0
		protected virtual void OnCollisionEnter(UnityEngine.Collision collision) {} // 0x000000018B41FDD0-0x000000018B41FDD8
		protected virtual void OnCollisionStay(UnityEngine.Collision collision) {} // 0x000000018B41FDD0-0x000000018B41FDD8
		protected virtual void Update() {} // 0x000000018B41FF24-0x000000018B41FF54
		private bool TryGetRaycastHit(ContactPoint contact, ref RaycastHit hit) => default; // 0x000000018B41FDD8-0x000000018B41FF24
		private void CheckCollision(UnityEngine.Collision collision) {} // 0x000000018B41F834-0x000000018B41FDB0
	}

	public class P3dHitNearby : MonoBehaviour // TypeDefIndex: 56992
	{
		// Fields
		private PhaseType paintIn; // 0x18
		private float interval; // 0x1C
		private bool preview; // 0x20
		private int priority; // 0x24
		private float pressure; // 0x28
		private P3dPointConnector connector; // 0x30
		[NonSerialized]
		private float current; // 0x38
		private Vector3 lastPosition; // 0x3C
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float Interval { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public bool Preview { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public int Priority { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public float Pressure { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public P3dPointConnector Connector { get => default; } // 0x000000018B420294-0x000000018B420304 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 56991
		{
			ManuallyOnly = -1,
			Update = 0,
			FixedUpdate = 1
		}
	
		// Constructors
		public P3dHitNearby() {} // 0x000000018B42027C-0x000000018B420294
	
		// Methods
		public void ManuallyHitNow() {} // 0x000000018B420060-0x000000018B42006C
		public void ClearHitCache() {} // 0x000000018B420028-0x000000018B42004C
		public void ResetConnections() {} // 0x000000018B420090-0x000000018B4200B0
		protected virtual void OnEnable() {} // 0x000000018B42006C-0x000000018B420090
		protected virtual void Update() {} // 0x000000018B42022C-0x000000018B42027C
		protected virtual void FixedUpdate() {} // 0x000000018B42004C-0x000000018B420060
		private void SubmitHit(bool preview) {} // 0x000000018B4200B0-0x000000018B4201BC
		private void UpdateHit() {} // 0x000000018B4201BC-0x000000018B42022C
	}

	public class P3dHitParticles : MonoBehaviour // TypeDefIndex: 56997
	{
		// Fields
		private EmitType emit; // 0x18
		private float raycastDistance; // 0x1C
		private LayerMask layers; // 0x20
		private OrientationType orientation; // 0x24
		private Camera _camera; // 0x28
		private NormalType normal; // 0x30
		private float offset; // 0x34
		private int skip; // 0x38
		private bool preview; // 0x3C
		private int priority; // 0x40
		private PressureType pressureMode; // 0x44
		private float pressureMin; // 0x48
		private float pressureMax; // 0x4C
		private float pressureConstant; // 0x50
		private float pressureMultiplier; // 0x54
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
		public EmitType Emit { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float RaycastDistance { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public LayerMask Layers { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public OrientationType Orientation { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public Camera Camera { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public NormalType Normal { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public float Offset { get => default; set {} } // 0x0000000185FB8060-0x0000000185FB8070 0x0000000185FB8A50-0x0000000185FB8A60
		public int Skip { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public bool Preview { get => default; set {} } // 0x0000000185FB0A40-0x0000000185FB0A50 0x0000000183AC91F0-0x0000000183AC9200
		public int Priority { get => default; set {} } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public PressureType PressureMode { get => default; set {} } // 0x0000000183908D10-0x0000000183908D20 0x0000000183909010-0x0000000183909020
		public float PressureMin { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float PressureMax { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float PressureConstant { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public float PressureMultiplier { get => default; set {} } // 0x0000000183F80440-0x0000000183F80450 0x0000000183F804D0-0x0000000183F804E0
		public GameObject Root { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x000000018B420DB4-0x000000018B420DE4
		public P3dHitCache HitCache { get => default; } // 0x0000000181460F70-0x0000000181460F80 
	
		// Nested types
		public enum EmitType // TypeDefIndex: 56993
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum OrientationType // TypeDefIndex: 56994
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		public enum NormalType // TypeDefIndex: 56995
		{
			ParticleVelocity = 0,
			CollisionNormal = 1
		}
	
		public enum PressureType // TypeDefIndex: 56996
		{
			Constant = 0,
			Distance = 1,
			Speed = 2
		}
	
		// Constructors
		public P3dHitParticles() {} // 0x000000018B420D30-0x000000018B420DB4
		static P3dHitParticles() {} // 0x000000018B420CA4-0x000000018B420D30
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B41FDB0-0x000000018B41FDD0
		private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit) => default; // 0x000000018B420AF0-0x000000018B420CA4
		protected virtual void OnParticleCollision(GameObject hitGameObject) {} // 0x000000018B420304-0x000000018B420AF0
	}

	public class P3dHitScreen : P3dHitScreenBase // TypeDefIndex: 57000
	{
		// Fields
		private FrequencyType frequency; // 0x70
		private float interval; // 0x74
		private P3dPointConnector connector; // 0x78
		[NonSerialized]
		private List<Link> links; // 0x80
	
		// Properties
		public FrequencyType Frequency { get => default; set {} } // 0x000000018B422D3C-0x000000018B422D60 0x000000018B4238AC-0x000000018B42391C
		public float Interval { get => default; set {} } // 0x000000018B423050-0x000000018B4231A4 0x000000018B41E098-0x000000018B41E0B8
		public P3dPointConnector Connector { get => default; } // 0x000000018B4237F8-0x000000018B423818 
	
		// Nested types
		protected class Link : CwInputManager.Link // TypeDefIndex: 56998
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
			public Link() {} // 0x0000000185FB89F0-0x0000000185FB8A00
	
			// Methods
			public void Move(Vector2 screenNew) {} // 0x0000000185FB06C0-0x0000000185FB06D0
			private bool TryMove(Vector2 screenNew) => default; // 0x0000000185FB0690-0x0000000185FB06A0
			public override void Clear() {} // 0x0000000185FBA030-0x0000000185FBA040
		}
	
		public enum FrequencyType // TypeDefIndex: 56999
		{
			PixelInterval = 0,
			ScaledPixelInterval = 1,
			TimeInterval = 2,
			OnceOnRelease = 3,
			OnceOnPress = 4,
			OnceEveryFrame = 5
		}
	
		// Constructors
		public P3dHitScreen() {} // 0x000000018B416910-0x000000018B416988
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B422E30-0x000000018B423048
		public void ResetConnections() {} // 0x000000018B422D60-0x000000018B422E30
		protected override void OnEnable() {} // 0x000000018B423448-0x000000018B423724
		protected virtual void Update() {} // 0x0000000185492010-0x0000000185492020
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x000000018B423230-0x000000018B423320
		protected override void HandleFingerUp(CwInputManager.Finger finger) {} // 0x000000018B4233AC-0x000000018B423448
		private void PaintSmooth(Link link, bool down, float pixelSpacing) {} // 0x000000018B423320-0x000000018B4233AC
		protected virtual void OnFingerUp(Link link) {} // 0x000000018B4231A4-0x000000018B423230
		private void PaintInterval(Link link, bool down) {} // 0x000000018B423724-0x000000018B4237F8
		private void PaintRelease(Link link, bool up) {} // 0x000000018B423818-0x000000018B4238AC
		private void PaintPress(Link link, bool down) {} // 0x000000018B41684C-0x000000018B416884
		private void PaintEvery(Link link, bool down) {} // 0x000000018B416884-0x000000018B416910
		private void RecordAndPaintAt(Link link, Vector2 screenNew, Vector2 screenOld, bool preview, float pressure, object owner) {} // 0x000000018B4167E8-0x000000018B41684C
	}

	public abstract class P3dHitScreenBase : MonoBehaviour // TypeDefIndex: 57006
	{
		// Fields
		private Camera _camera; // 0x18
		private LayerMask layers; // 0x20
		private ButtonTypes requiredButtons; // 0x24
		private KeyCode requiredKey; // 0x28
		private LayerMask guiLayers; // 0x2C
		private EmitType emit; // 0x30
		private RotationType rotateTo; // 0x34
		private DirectionType normalDirection; // 0x38
		private RelativeType normalRelativeTo; // 0x3C
		private Transform customTransform; // 0x40
		private float normalOffset; // 0x48
		private float mouseOffset; // 0x4C
		private float touchOffset; // 0x50
		protected bool storeStates; // 0x54
		protected bool showPreview; // 0x55
		private int priority; // 0x58
		[NonSerialized]
		protected List<CwInputManager.Finger> fingers; // 0x60
		protected bool keyPressed; // 0x68
	
		// Properties
		public Camera Camera { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public LayerMask Layers { get; set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public ButtonTypes RequiredButtons { get; set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public KeyCode RequiredKey { get; set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public LayerMask GuiLayers { get; set; } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public EmitType Emit { get; set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public RotationType RotateTo { get; set; } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		public DirectionType NormalDirection { get; set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public RelativeType NormalRelativeTo { get; set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public Transform CustomTransform { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public float NormalOffset { get; set; } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float MouseOffset { get; set; } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float TouchOffset { get; set; } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public bool StoreStates { get; set; } // 0x0000000185FB0A80-0x0000000185FB0A90 0x0000000185FB0AA0-0x0000000185FB0AB0
		public bool ShowPreview { get; set; } // 0x0000000185FB0A70-0x0000000185FB0A80 0x0000000185FB0A90-0x0000000185FB0AA0
		public int Priority { get; set; } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public bool NeedsDrawAngle { get; } // 0x000000018B421FC4-0x000000018B421FD8 
	
		// Nested types
		public enum RotationType // TypeDefIndex: 57001
		{
			Normal = 0,
			World = 1,
			ThisRotation = 2,
			ThisLocalRotation = 3,
			CustomRotation = 4,
			CustomLocalRotation = 5
		}
	
		public enum RelativeType // TypeDefIndex: 57002
		{
			WorldUp = 0,
			CameraUp = 1,
			DrawAngle = 2
		}
	
		public enum DirectionType // TypeDefIndex: 57003
		{
			HitNormal = 0,
			RayDirection = 1,
			CameraDirection = 2
		}
	
		public enum EmitType // TypeDefIndex: 57004
		{
			PointsIn3D = 0,
			PointsOnUV = 20,
			TrianglesIn3D = 30
		}
	
		public enum ButtonTypes // TypeDefIndex: 57005
		{
			LeftMouse = 1,
			RightMouse = 2,
			MiddleMouse = 4,
			Touch = 32
		}
	
		// Constructors
		protected P3dHitScreenBase() {} // 0x000000018B421F1C-0x000000018B421FC4
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B42181C-0x000000018B4219DC
		protected virtual void LateUpdate() {} // 0x000000018B421554-0x000000018B421768
		protected virtual void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void HandleFingerUp(CwInputManager.Finger finger) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDisable() {} // 0x000000018B421768-0x000000018B42181C
		private bool FingerWentDown(CwInputManager.Finger finger) => default; // 0x000000018B4213A8-0x000000018B421484
		private void HandleFingerDown(CwInputManager.Finger finger) {} // 0x000000018B421484-0x000000018B421554
		protected virtual void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D) {} // 0x000000018B421230-0x000000018B4213A8
		protected void PaintAt(P3dPointConnector connector, P3dHitCache hitCache, Vector2 screenPosition, Vector2 screenPositionOld, bool preview, float pressure, object owner) {} // 0x000000018B4219DC-0x000000018B421F1C
		private void CalcHitData(Vector3 hitPoint, Vector3 hitNormal, Ray ray, Camera camera, Vector2 screenPositionOld, ref Vector3 finalPosition, ref Quaternion finalRotation) {} // 0x000000018B420DE4-0x000000018B421230
	}

	public class P3dHitScreenFill : P3dHitScreen // TypeDefIndex: 57007
	{
		// Fields
		private float fillSpacing; // 0x88
	
		// Properties
		public float FillSpacing { get => default; set {} } // 0x0000000185FB8BC0-0x0000000185FB8BD0 0x0000000185FB8BE0-0x0000000185FB8BF0
	
		// Constructors
		public P3dHitScreenFill() {} // 0x000000018B422694-0x000000018B4226A8
	
		// Methods
		protected override void OnFingerUp(Link link) {} // 0x000000018B4223C0-0x000000018B422694
		private static Rect GetArea(List<Vector2> points) => default; // 0x000000018B42217C-0x000000018B4223C0
		private static double LineSide(Vector2 a, Vector2 b, Vector2 p) => default; // 0x0000000185FD2470-0x0000000185FD24D0
		private static bool Contains(List<Vector2> points, Vector2 xy) => default; // 0x000000018B421FD8-0x000000018B42217C
	}

	public class P3dHitScreenLine : P3dHitScreenBase // TypeDefIndex: 57009
	{
		// Fields
		private FrequencyType frequency; // 0x70
		private float interval; // 0x74
		private float position; // 0x78
		private float pixelOffset; // 0x7C
		private P3dPointConnector connector; // 0x80
	
		// Properties
		public FrequencyType Frequency { get => default; set {} } // 0x0000000185FB0690-0x0000000185FB06A0 0x0000000185FB06C0-0x0000000185FB06D0
		public float Interval { get => default; set {} } // 0x0000000185FB89F0-0x0000000185FB8A00 0x0000000185FBA030-0x0000000185FBA040
		public float Position { get => default; set {} } // 0x0000000185FB89E0-0x0000000185FB89F0 0x0000000185FBA050-0x0000000185FBA060
		public float PixelOffset { get => default; set {} } // 0x0000000185FB2E90-0x0000000185FB2EA0 0x0000000185FBD3A0-0x0000000185FBD3B0
		public P3dPointConnector Connector { get => default; } // 0x000000018B422CC0-0x000000018B422D3C 
	
		// Nested types
		public enum FrequencyType // TypeDefIndex: 57008
		{
			StartAndEnd = 0,
			PixelInterval = 1,
			ScaledPixelInterval = 2,
			StretchedPixelInterval = 3,
			StretchedScaledPixelInterval = 4,
			Once = 5
		}
	
		// Constructors
		public P3dHitScreenLine() {} // 0x000000018B422CA8-0x000000018B422CC0
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B4226A8-0x000000018B4226CC
		public void ResetConnections() {} // 0x000000018B422C60-0x000000018B422C84
		protected override void OnEnable() {} // 0x000000018B422844-0x000000018B422878
		protected virtual void Update() {} // 0x000000018B422C84-0x000000018B422CA8
		protected override void HandleFingerUpdate(CwInputManager.Finger finger, bool down, bool up) {} // 0x000000018B4226CC-0x000000018B422844
		private void PaintStartEnd(CwInputManager.Finger finger, bool up) {} // 0x000000018B4229BC-0x000000018B422AE4
		private void PaintStartInterval(CwInputManager.Finger finger, bool up, float pixelSpacing, bool stretch) {} // 0x000000018B422AE4-0x000000018B422C60
		private void PaintOne(CwInputManager.Finger finger, bool up, float frac, float pixelOff) {} // 0x000000018B422878-0x000000018B4229BC
	}

	public class P3dHitThrough : MonoBehaviour // TypeDefIndex: 57012
	{
		// Fields
		private PhaseType paintIn; // 0x18
		private float interval; // 0x1C
		private Transform pointA; // 0x20
		private Transform pointB; // 0x28
		private OrientationType orientation; // 0x30
		private Camera _camera; // 0x38
		private float pressure; // 0x40
		private bool preview; // 0x44
		private int priority; // 0x48
		private LineRenderer line; // 0x50
		private P3dLineConnector connector; // 0x58
		[NonSerialized]
		private float current; // 0x60
	
		// Properties
		public PhaseType PaintIn { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float Interval { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public Transform PointA { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Transform PointB { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public OrientationType Orientation { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public Camera Camera { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public float Pressure { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public bool Preview { get => default; set {} } // 0x0000000185FB08A0-0x0000000185FB08B0 0x0000000185FB08B0-0x0000000185FB08C0
		public int Priority { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public LineRenderer Line { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public P3dLineConnector Connector { get => default; } // 0x000000018B423F00-0x000000018B423F70 
	
		// Nested types
		public enum PhaseType // TypeDefIndex: 57010
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		public enum OrientationType // TypeDefIndex: 57011
		{
			WorldUp = 0,
			CameraUp = 1
		}
	
		// Constructors
		public P3dHitThrough() {} // 0x000000018B423EE8-0x000000018B423F00
	
		// Methods
		public void ManuallyHitNow() {} // 0x000000018B42395C-0x000000018B423968
		public void ClearHitCache() {} // 0x000000018B42391C-0x000000018B423940
		public void ResetConnections() {} // 0x000000018B42398C-0x000000018B4239AC
		protected virtual void OnEnable() {} // 0x000000018B423968-0x000000018B42398C
		protected virtual void Update() {} // 0x000000018B423E98-0x000000018B423EE8
		protected virtual void LateUpdate() {} // 0x000000018B423954-0x000000018B42395C
		protected virtual void FixedUpdate() {} // 0x000000018B423940-0x000000018B423954
		private void SubmitHit(bool preview) {} // 0x000000018B4239AC-0x000000018B423CCC
		private void UpdateHit() {} // 0x000000018B423CCC-0x000000018B423D34
		private void UpdatePointAndLine() {} // 0x000000018B423D34-0x000000018B423E98
	}

	public interface IClone // TypeDefIndex: 57013
	{
		// Methods
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}

	public interface IHit // TypeDefIndex: 57014
	{
	}

	public interface IHitCoord : IHit // TypeDefIndex: 57015
	{
		// Methods
		void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation);
	}

	public interface IHitLine : IHit // TypeDefIndex: 57016
	{
		// Methods
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip);
	}

	public interface IHitPoint : IHit // TypeDefIndex: 57017
	{
		// Methods
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}

	public interface IHitQuad : IHit // TypeDefIndex: 57018
	{
		// Methods
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip);
	}

	public interface IHitTriangle : IHit // TypeDefIndex: 57019
	{
		// Methods
		void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation);
	}

	public interface IBrowsable // TypeDefIndex: 57020
	{
		// Methods
		string GetCategory();
		string GetTitle();
		Texture2D GetIcon();
		UnityEngine.Object GetObject();
	}

	public class P3dHitScreen_InEditor : P3dHitScreen // TypeDefIndex: 57021
	{
		// Constructors
		public P3dHitScreen_InEditor() {} // 0x000000018B423048-0x000000018B423050
	
		// Methods
		protected override void DoQuery(Vector2 screenPosition, ref Camera camera, ref Ray ray, ref RaycastHit hit3D, ref RaycastHit2D hit2D) {} // 0x0000000185492010-0x0000000185492020
		protected override void LateUpdate() {} // 0x0000000185492010-0x0000000185492020
	}

	public class P3dMaterial : MonoBehaviour, IBrowsable // TypeDefIndex: 57022
	{
		// Fields
		private string category; // 0x18
		private Texture2D icon; // 0x20
		private List<Texture> textures; // 0x28
		private static List<P3dMaterial> cachedMaterials; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Texture2D Icon { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public List<Texture> Textures { get => default; } // 0x000000018B424070-0x000000018B4240F4 
		public static List<P3dMaterial> CachedMaterials { get => default; } // 0x000000018B423FBC-0x000000018B424070 
	
		// Constructors
		public P3dMaterial() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static void ClearCache() {} // 0x000000018B423F70-0x000000018B423FBC
		public string GetCategory() => default; // 0x0000000181377E40-0x0000000181377E50
		public string GetTitle() => default; // 0x00000001864746E4-0x00000001864746EC
		public Texture2D GetIcon() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public UnityEngine.Object GetObject() => default; // 0x0000000185779060-0x0000000185779070
	}

	public class P3dPreset : MonoBehaviour // TypeDefIndex: 57023
	{
		// Fields
		private string title; // 0x18
		private bool addMaterialCloner; // 0x20
		private static List<P3dPreset> cachedPresets; // 0x00
	
		// Properties
		public string Title { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public bool AddMaterialCloner { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		public P3dPreset() {} // 0x0000000185C20250-0x0000000185C20260
	}

	public class P3dSeamFixer : ScriptableObject // TypeDefIndex: 57029
	{
		// Fields
		private Mesh source; // 0x18
		private Mesh mesh; // 0x20
		private List<Pair> meshes; // 0x28
		private P3dCoord coord; // 0x30
		private float threshold; // 0x34
		private float border; // 0x38
		private static Dictionary<Mesh, Mesh> cacheFirst; // 0x00
		private static Dictionary<Mesh, Mesh> cacheSecond; // 0x08
		private static Dictionary<Mesh, Mesh> cacheThird; // 0x10
		private static Dictionary<Mesh, Mesh> cacheFourth; // 0x18
	
		// Properties
		public List<Pair> Meshes { get => default; } // 0x000000018B42880C-0x000000018B428910 
		public P3dCoord Coord { get => default; set {} } // 0x000000018B425AB0-0x000000018B425B68 0x000000018B428BDC-0x000000018B428D78
		public float Threshold { get => default; set {} } // 0x000000018B4284CC-0x000000018B42880C 0x000000018B425ECC-0x000000018B425FB8
		public float Border { get => default; set {} } // 0x000000018B4259C4-0x000000018B425AB0 0x000000018B4276F4-0x000000018B4284CC
	
		// Nested types
		[Serializable]
		public class Pair // TypeDefIndex: 57024
		{
			// Fields
			public Mesh Source; // 0x10
			public Mesh Output; // 0x18
	
			// Constructors
			public Pair() {} // 0x000000018B428F0C-0x000000018B428F90
		}
	
		private class Ring // TypeDefIndex: 57025
		{
			// Fields
			public List<Point> Points; // 0x10
	
			// Constructors
			public Ring() {} // 0x00000001813CFF60-0x00000001813CFF70
	
			// Methods
			public Point GetPoint(int index) => default; // 0x00000001813D0A90-0x00000001813D0AA0
		}
	
		private class Edge // TypeDefIndex: 57026
		{
			// Fields
			public bool Used; // 0x10
			public Point PointA; // 0x18
			public Point PointB; // 0x20
			public bool Flip; // 0x28
	
			// Constructors
			public Edge() {} // 0x0000000185FB8060-0x0000000185FB8070
	
			// Methods
			public bool Match(Point a, Point b) => default; // 0x0000000185FB8A50-0x0000000185FB8A60
		}
	
		private class Point // TypeDefIndex: 57027
		{
			// Fields
			public int Index; // 0x10
			public Vector2 Coord; // 0x14
			public Insertion Outer; // 0x20
			public List<Edge> Edges; // 0x28
	
			// Constructors
			public Point() {} // 0x0000000185FB24C0-0x0000000185FB24D0
		}
	
		private class Insertion // TypeDefIndex: 57028
		{
			// Fields
			public int Index; // 0x10
			public int NewIndex; // 0x14
			public Vector2 NewCoord; // 0x18
	
			// Constructors
			public Insertion() {} // 0x0000000185FB24B0-0x0000000185FB24C0
		}
	
		// Constructors
		public P3dSeamFixer() {} // 0x000000018B429190-0x000000018B429208
		static P3dSeamFixer() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static Mesh GetCachedMesh(Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x0207D4F4 */) => default; // 0x000000018B425FB8-0x000000018B4276F4
		private static Mesh TryGetCachedMesh(Dictionary<Mesh, Mesh> cache, Mesh source, P3dCoord coord, bool allowGeneration = true /* Metadata: 0x0207D4F5 */) => default; // 0x000000018B428ABC-0x000000018B428BDC
		public void AddMesh(Mesh mesh) {} // 0x000000018B425B68-0x000000018B425C68
		public void ConvertLegacy() {} // 0x000000018B425D14-0x000000018B425ECC
		public void Generate() {} // 0x000000018B425C68-0x000000018B425D14
		public static void Generate(Mesh source, Mesh output, P3dCoord coord, float threshold, float border) {} // 0x000000018B428910-0x000000018B428ABC
		private static void AddCoord(List<Vector4> coords, Insertion insertion, bool write) {} // 0x000000018B428EF4-0x000000018B428F0C
		private static void FixSeams(Mesh source, Mesh output, List<List<int>> submeshes, List<Ring> rings, List<Insertion> insertions, P3dCoord coord) {} // 0x000000018B428D78-0x000000018B428EF4
		private static void TraceEdges(Ring ring, Point point) {} // 0x0000000185492010-0x0000000185492020
		private static void AddPoint(Dictionary<Vector2, Point> points, Vector2 coord, int index) {} // 0x000000018B429208-0x000000018B429288
		private static void AddTriangle(List<Edge> edges, Point pointA, Point pointB, Point pointC) {} // 0x000000018B429288-0x000000018B429300
		private static void AddTriangle2(List<Edge> edges, Point pointA, Point pointB, Point pointC, bool flip) {} // 0x000000018B4167C8-0x000000018B4167E8
		private static void RemoveOrAddEdge(List<Edge> edges, Point pointA, Point pointB, bool flip) {} // 0x0000000185492010-0x0000000185492020
	}

	public class P3dShape : MonoBehaviour, IBrowsable // TypeDefIndex: 57030
	{
		// Fields
		private string category; // 0x18
		private Texture2D icon; // 0x20
		private static List<P3dShape> cachedShapes; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Texture2D Icon { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public static List<P3dShape> CachedShapes { get => default; } // 0x000000018B428FDC-0x000000018B429090 
	
		// Constructors
		public P3dShape() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static void ClearCache() {} // 0x000000018B428F90-0x000000018B428FDC
		public string GetCategory() => default; // 0x0000000181377E40-0x0000000181377E50
		public string GetTitle() => default; // 0x00000001864746E4-0x00000001864746EC
		public Texture2D GetIcon() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public UnityEngine.Object GetObject() => default; // 0x0000000185779060-0x0000000185779070
	}

	public class P3dTool : MonoBehaviour, IBrowsable // TypeDefIndex: 57031
	{
		// Fields
		private string category; // 0x18
		private Texture2D icon; // 0x20
		private static List<P3dTool> cachedTools; // 0x00
	
		// Properties
		public string Category { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Texture2D Icon { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public static List<P3dTool> CachedTools { get => default; } // 0x000000018B4290DC-0x000000018B429190 
	
		// Constructors
		public P3dTool() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static void ClearCache() {} // 0x000000018B429090-0x000000018B4290DC
		public string GetCategory() => default; // 0x0000000181377E40-0x0000000181377E50
		public string GetTitle() => default; // 0x00000001864746E4-0x00000001864746EC
		public Texture2D GetIcon() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public UnityEngine.Object GetObject() => default; // 0x0000000185779060-0x0000000185779070
	}

	[Serializable]
	public class P3dModifyAngleRandom : P3dModifier // TypeDefIndex: 57033
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float min; // 0x18
		private float max; // 0x1C
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public float Max { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57032
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyAngleRandom() {} // 0x0000000185FD24D0-0x0000000185FD24F0
		static P3dModifyAngleRandom() {} // 0x000000018B424140-0x000000018B4241D8
	
		// Methods
		protected override void OnModifyAngle(ref float angle, float pressure) {} // 0x000000018B4240F4-0x000000018B424140
	}

	[Serializable]
	public class P3dModifyColorRandom : P3dModifier // TypeDefIndex: 57035
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private Gradient gradient; // 0x18
		private BlendType blend; // 0x20
	
		// Properties
		public Gradient Gradient { get => default; } // 0x000000018B42432C-0x000000018B4243A0 
		public BlendType Blend { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57034
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyColorRandom() {} // 0x0000000185FD24F0-0x0000000185FD2500
		static P3dModifyColorRandom() {} // 0x000000018B424294-0x000000018B42432C
	
		// Methods
		protected override void OnModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x000000018B4241D8-0x000000018B424294
	}

	public class P3dModifyHardnessPressure : P3dModifier // TypeDefIndex: 57037
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float hardness; // 0x18
		private BlendType blend; // 0x1C
	
		// Properties
		public float Hardness { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57036
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessPressure() {} // 0x0000000185FD2500-0x0000000185FD2510
		static P3dModifyHardnessPressure() {} // 0x000000018B4243E4-0x000000018B42447C
	
		// Methods
		protected override void OnModifyHardness(ref float currentHardness, float pressure) {} // 0x000000018B4243A0-0x000000018B4243E4
	}

	[Serializable]
	public class P3dModifyHardnessRandom : P3dModifier // TypeDefIndex: 57039
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float min; // 0x18
		private float max; // 0x1C
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public float Max { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57038
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyHardnessRandom() {} // 0x0000000185FD2510-0x0000000185FD2530
		static P3dModifyHardnessRandom() {} // 0x000000018B42447C-0x000000018B424514
	
		// Methods
		protected override void OnModifyHardness(ref float hardness, float pressure) {} // 0x000000018B4240F4-0x000000018B424140
	}

	[Serializable]
	public class P3dModifyOpacityPressure : P3dModifier // TypeDefIndex: 57041
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float opacity; // 0x18
		private BlendType blend; // 0x1C
	
		// Properties
		public float Opacity { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57040
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityPressure() {} // 0x0000000185FD2500-0x0000000185FD2510
		static P3dModifyOpacityPressure() {} // 0x000000018B424514-0x000000018B4245AC
	
		// Methods
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure) {} // 0x000000018B4243A0-0x000000018B4243E4
	}

	[Serializable]
	public class P3dModifyOpacityRandom : P3dModifier // TypeDefIndex: 57043
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float min; // 0x18
		private float max; // 0x1C
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public float Max { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57042
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyOpacityRandom() {} // 0x0000000185FD2510-0x0000000185FD2530
		static P3dModifyOpacityRandom() {} // 0x000000018B4245AC-0x000000018B424644
	
		// Methods
		protected override void OnModifyOpacity(ref float opacity, float pressure) {} // 0x000000018B4240F4-0x000000018B424140
	}

	[Serializable]
	public class P3dModifyPositionRandom : P3dModifier // TypeDefIndex: 57044
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float radius; // 0x18
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
	
		// Constructors
		public P3dModifyPositionRandom() {} // 0x0000000185FD2500-0x0000000185FD2510
		static P3dModifyPositionRandom() {} // 0x000000018B4246EC-0x000000018B424784
	
		// Methods
		protected override void OnModifyPosition(ref Vector3 position, float pressure) {} // 0x000000018B424644-0x000000018B4246EC
	}

	[Serializable]
	public class P3dModifyRadiusPressure : P3dModifier // TypeDefIndex: 57046
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float radius; // 0x18
		private BlendType blend; // 0x1C
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57045
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusPressure() {} // 0x0000000185FD2500-0x0000000185FD2510
		static P3dModifyRadiusPressure() {} // 0x000000018B424784-0x000000018B42481C
	
		// Methods
		protected override void OnModifyRadius(ref float currentRadius, float pressure) {} // 0x000000018B4243A0-0x000000018B4243E4
	}

	[Serializable]
	public class P3dModifyRadiusRandom : P3dModifier // TypeDefIndex: 57048
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private float min; // 0x18
		private float max; // 0x1C
		private BlendType blend; // 0x20
	
		// Properties
		public float Min { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public float Max { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public BlendType Blend { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57047
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyRadiusRandom() {} // 0x0000000185FD2510-0x0000000185FD2530
		static P3dModifyRadiusRandom() {} // 0x000000018B42481C-0x000000018B4248B4
	
		// Methods
		protected override void OnModifyRadius(ref float radius, float pressure) {} // 0x000000018B4240F4-0x000000018B424140
	}

	[Serializable]
	public class P3dModifyScaleRandom : P3dModifier // TypeDefIndex: 57050
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private Vector3 min; // 0x18
		private Vector3 max; // 0x24
		private BlendType blend; // 0x30
		private bool uniform; // 0x34
	
		// Properties
		public Vector3 Min { get => default; set {} } // 0x0000000185FB3830-0x0000000185FB3850 0x0000000185FB3850-0x0000000185FB3860
		public Vector3 Max { get => default; set {} } // 0x0000000185FB8980-0x0000000185FB89A0 0x0000000185FBC070-0x0000000185FBC080
		public BlendType Blend { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public bool Uniform { get => default; set {} } // 0x0000000185FB0B90-0x0000000185FB0BA0 0x0000000185FB0BB0-0x0000000185FB0BC0
	
		// Nested types
		public enum BlendType // TypeDefIndex: 57049
		{
			Replace = 0,
			Multiply = 1,
			Increment = 2
		}
	
		// Constructors
		public P3dModifyScaleRandom() {} // 0x0000000185FD2530-0x0000000185FD2570
		static P3dModifyScaleRandom() {} // 0x000000018B424A64-0x000000018B424AFC
	
		// Methods
		protected override void OnModifyScale(ref Vector3 scale, float pressure) {} // 0x000000018B4248B4-0x000000018B424A64
	}

	[Serializable]
	public class P3dModifyTexturePressure : P3dModifier // TypeDefIndex: 57051
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private Texture texture; // 0x18
		private float pressureMin; // 0x20
		private float pressureMax; // 0x24
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float PressureMin { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public float PressureMax { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
	
		// Constructors
		public P3dModifyTexturePressure() {} // 0x0000000185FD2570-0x0000000185FD2590
		static P3dModifyTexturePressure() {} // 0x000000018B424B1C-0x000000018B424BB4
	
		// Methods
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure) {} // 0x000000018B424AFC-0x000000018B424B1C
	}

	[Serializable]
	public class P3dModifyTextureRandom : P3dModifier // TypeDefIndex: 57052
	{
		// Fields
		public static string Group; // 0x00
		public static string Title; // 0x08
		private List<Texture> textures; // 0x18
	
		// Properties
		public List<Texture> Textures { get => default; } // 0x000000018B424CD8-0x000000018B424D5C 
	
		// Constructors
		public P3dModifyTextureRandom() {} // 0x0000000185FD24F0-0x0000000185FD2500
		static P3dModifyTextureRandom() {} // 0x000000018B424C40-0x000000018B424CD8
	
		// Methods
		protected override void OnModifyTexture(ref Texture texture, float pressure) {} // 0x000000018B424BB4-0x000000018B424C40
	}

	[Serializable]
	public struct P3dBlendMode // TypeDefIndex: 57053
	{
		// Fields
		public const int ALPHA_BLEND = 0; // Metadata: 0x0207D511
		public const int ALPHA_BLEND_INVERSE = 1; // Metadata: 0x0207D512
		public const int PREMULTIPLIED = 2; // Metadata: 0x0207D513
		public const int ADDITIVE = 3; // Metadata: 0x0207D514
		public const int ADDITIVE_SOFT = 4; // Metadata: 0x0207D515
		public const int SUBTRACTIVE = 5; // Metadata: 0x0207D516
		public const int SUBTRACTIVE_SOFT = 6; // Metadata: 0x0207D517
		public const int REPLACE = 7; // Metadata: 0x0207D518
		public const int REPLACE_ORIGINAL = 8; // Metadata: 0x0207D519
		public const int REPLACE_CUSTOM = 9; // Metadata: 0x0207D51A
		public const int MULTIPLY_INVERSE_RGB = 10; // Metadata: 0x0207D51B
		public const int BLUR = 11; // Metadata: 0x0207D51C
		public const int NORMAL_BLEND = 12; // Metadata: 0x0207D51D
		public const int NORMAL_REPLACE = 13; // Metadata: 0x0207D51E
		public const int FLOW = 14; // Metadata: 0x0207D51F
		public const int NORMAL_REPLACE_ORIGINAL = 15; // Metadata: 0x0207D520
		public const int NORMAL_REPLACE_CUSTOM = 16; // Metadata: 0x0207D521
		public const int COUNT = 17; // Metadata: 0x0207D522
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
		} // 0x000000018B4171C8-0x000000018B417538
	
		// Methods
		public static P3dBlendMode AlphaBlend(Vector4 channels) => default; // 0x000000018B416A60-0x000000018B416AA4
		public static P3dBlendMode AlphaBlendInverse(Vector4 channels) => default; // 0x000000018B416A18-0x000000018B416A60
		public static P3dBlendMode Premultiplied(Vector4 channels) => default; // 0x000000018B417010-0x000000018B417058
		public static P3dBlendMode Additive(Vector4 channels) => default; // 0x000000018B4169D0-0x000000018B416A18
		public static P3dBlendMode AdditiveSoft(Vector4 channels) => default; // 0x000000018B416988-0x000000018B4169D0
		public static P3dBlendMode Subtractive(Vector4 channels) => default; // 0x000000018B417180-0x000000018B4171C8
		public static P3dBlendMode SubtractiveSoft(Vector4 channels) => default; // 0x000000018B417138-0x000000018B417180
		public static P3dBlendMode Replace(Vector4 channels) => default; // 0x000000018B4170F0-0x000000018B417138
		public static P3dBlendMode ReplaceOriginal(Vector4 channels) => default; // 0x000000018B4170A8-0x000000018B4170F0
		public static P3dBlendMode ReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels) => default; // 0x000000018B417058-0x000000018B4170A8
		public static P3dBlendMode MultiplyInverseRGB(Vector4 channels) => default; // 0x000000018B416EA0-0x000000018B416EE8
		public static P3dBlendMode Blur(float kernel, Vector4 channels) => default; // 0x000000018B416CC4-0x000000018B416D08
		public static P3dBlendMode NormalBlend(Vector4 channels) => default; // 0x000000018B416EE8-0x000000018B416F30
		public static P3dBlendMode NormalReplace(Vector4 channels) => default; // 0x000000018B416FC8-0x000000018B417010
		public static P3dBlendMode Flow(float kernel, Vector4 channels) => default; // 0x000000018B416D84-0x000000018B416DC8
		public static P3dBlendMode NormalReplaceOriginal(Vector4 channels) => default; // 0x000000018B416F80-0x000000018B416FC8
		public static P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, Texture texture, Vector4 channels) => default; // 0x000000018B416F30-0x000000018B416F80
		public void Apply(Material material) {} // 0x000000018B416AA4-0x000000018B416CC4
		public static string GetName(int index) => default; // 0x000000018B416E34-0x000000018B416EA0
		public static bool operator ==(P3dBlendMode a, int b) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public static bool operator !=(P3dBlendMode a, int b) => default; // 0x000000018B417538-0x000000018B417540
		public static implicit operator int(P3dBlendMode a) => default; // 0x00000001818226B0-0x00000001818226C0
		public override int GetHashCode() => default; // 0x000000018B416DC8-0x000000018B416E34
		public override bool Equals(object obj) => default; // 0x000000018B416D08-0x000000018B416D84
	}

	public static class P3dBlit // TypeDefIndex: 57054
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
		static P3dBlit() {} // 0x000000018B429F08-0x000000018B429FDC
	
		// Methods
		public static void White(RenderTexture rendertexture, Mesh mesh, int submesh, P3dCoord coord) {} // 0x000000018B429CC8-0x000000018B429F08
		public static void Texture(RenderTexture rendertexture, Mesh mesh, int submesh, Texture texture, P3dCoord coord) {} // 0x000000018B429A48-0x000000018B429CC8
		public static void Normal(RenderTexture rendertexture, Texture texture) {} // 0x000000018B429740-0x000000018B429888
		public static void Premultiply(RenderTexture rendertexture, Texture texture, UnityEngine.Color tint) {} // 0x000000018B429888-0x000000018B429A48
	}

	public class P3dChangeCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 57055
	{
		// Fields
		public static LinkedList<P3dChangeCounter> Instances; // 0x00
		private LinkedListNode<P3dChangeCounter> instancesNode; // 0x98
		private float threshold; // 0xA0
		private Texture texture; // 0xA8
		private UnityEngine.Color color; // 0xB0
		private int count; // 0xC0
		private P3dReader changeReader; // 0xC8
		protected NativeArray<Color32> changePixels; // 0xD0
	
		// Properties
		public float Threshold { get => default; set {} } // 0x0000000185FB9B70-0x0000000185FB9B80 0x000000018B42ADA8-0x000000018B42ADD8
		public Texture Texture { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018B42AD24-0x000000018B42ADA8
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FCCCB0-0x0000000185FCCCC0 0x000000018B42ACD4-0x000000018B42AD24
		public int Count { get => default; } // 0x0000000185FBE0C0-0x0000000185FBE0D0 
		public float Ratio { get => default; } // 0x000000018B42ACB0-0x000000018B42ACD4 
		public P3dReader ChangeReader { get => default; } // 0x0000000185FB0300-0x0000000185FB0310 
	
		// Constructors
		public P3dChangeCounter() {} // 0x000000018B42AC7C-0x000000018B42ACB0
		static P3dChangeCounter() {} // 0x000000018B42AC00-0x000000018B42AC7C
	
		// Methods
		public void MarkChangeReaderAsDirty() {} // 0x000000018B42A6A0-0x000000018B42A6B8
		public static long GetTotal(ICollection<P3dChangeCounter> counters = null) => default; // 0x000000018B42A200-0x000000018B42A394
		public static long GetCount(ICollection<P3dChangeCounter> counters = null) => default; // 0x000000018B429FDC-0x000000018B42A174
		public static float GetRatio(ICollection<P3dChangeCounter> counters = null) => default; // 0x000000018B42A174-0x000000018B42A200
		private void HandleCompleteChange(NativeArray<Color32> pixels) {} // 0x000000018B42A394-0x000000018B42A4FC
		protected override void HandleComplete(int boost) {} // 0x000000018B42A4FC-0x000000018B42A6A0
		protected override void OnEnable() {} // 0x000000018B42A838-0x000000018B42A93C
		protected override void OnDisable() {} // 0x000000018B42A730-0x000000018B42A838
		protected override void OnDestroy() {} // 0x000000018B42A6B8-0x000000018B42A730
		protected override void Update() {} // 0x000000018B42A93C-0x000000018B42AC00
	}

	public enum P3dChannel // TypeDefIndex: 57056
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Alpha = 3
	}

	public class P3dChannelCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 57057
	{
		// Fields
		public static LinkedList<P3dChannelCounter> Instances; // 0x00
		private LinkedListNode<P3dChannelCounter> instancesNode; // 0x98
		private float threshold; // 0xA0
		private int countR; // 0xA4
		private int countG; // 0xA8
		private int countB; // 0xAC
		private int countA; // 0xB0
	
		// Properties
		public float Threshold { get => default; set {} } // 0x0000000185FB9B70-0x0000000185FB9B80 0x000000018B42BF34-0x000000018B42BF5C
		public int CountR { get => default; } // 0x0000000185FB2CE0-0x0000000185FB2CF0 
		public int CountG { get => default; } // 0x0000000185FB2CD0-0x0000000185FB2CE0 
		public int CountB { get => default; } // 0x0000000185FB2CF0-0x0000000185FB2D00 
		public int CountA { get => default; } // 0x0000000185FBB310-0x0000000185FBB320 
		public float RatioR { get => default; } // 0x000000018B42BF10-0x000000018B42BF34 
		public float RatioG { get => default; } // 0x000000018B42BE38-0x000000018B42BE5C 
		public float RatioB { get => default; } // 0x000000018B42BE14-0x000000018B42BE38 
		public float RatioA { get => default; } // 0x000000018B42BDF0-0x000000018B42BE14 
		public Vector4 RatioRGBA { get => default; } // 0x000000018B42BE5C-0x000000018B42BF10 
	
		// Constructors
		public P3dChannelCounter() {} // 0x000000018B42BDDC-0x000000018B42BDF0
		static P3dChannelCounter() {} // 0x000000018B42BD60-0x000000018B42BDDC
	
		// Methods
		public static long GetTotal(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B980-0x000000018B42BB14
		public static long GetCountR(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B2A0-0x000000018B42B438
		public static long GetCountG(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B108-0x000000018B42B2A0
		public static long GetCountB(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42AF70-0x000000018B42B108
		public static long GetCountA(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42ADD8-0x000000018B42AF70
		public static float GetRatioR(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B8F4-0x000000018B42B980
		public static float GetRatioG(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B550-0x000000018B42B5DC
		public static float GetRatioB(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B4C4-0x000000018B42B550
		public static float GetRatioA(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B438-0x000000018B42B4C4
		public static Vector4 GetRatioRGBA(ICollection<P3dChannelCounter> counters = null) => default; // 0x000000018B42B5DC-0x000000018B42B8F4
		protected override void OnEnable() {} // 0x000000018B42BCD4-0x000000018B42BD60
		protected override void OnDisable() {} // 0x000000018B42BC44-0x000000018B42BCD4
		protected override void HandleComplete(int boost) {} // 0x000000018B42BB14-0x000000018B42BC44
	}

	public abstract class P3dClone : MonoBehaviour, IClone // TypeDefIndex: 57058
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
		public static LinkedList<P3dClone> Instances { get; } // 0x000000018B42D064-0x000000018B42D0B4 
	
		// Constructors
		protected P3dClone() {} // 0x000000018646DB20-0x000000018646DB28
		static P3dClone() {} // 0x000000018B42CEC8-0x000000018B42D064
	
		// Methods
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
		public static void BuildCloners(List<IClone> cloners = null) {} // 0x000000018B42C698-0x000000018B42CACC
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex) {} // 0x000000018B42CACC-0x000000018B42CDCC
		protected virtual void OnEnable() {} // 0x000000018B42CE4C-0x000000018B42CEC8
		protected virtual void OnDisable() {} // 0x000000018B42CDCC-0x000000018B42CE4C
	}

	public class P3dCloneMirror : P3dClone // TypeDefIndex: 57059
	{
		// Fields
		private bool flip; // 0x20
	
		// Properties
		public bool Flip { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		public P3dCloneMirror() {} // 0x000000018B42C64C-0x000000018B42C698
	
		// Methods
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix) {} // 0x000000018B42BF5C-0x000000018B42C64C
	}

	public class P3dColor : MonoBehaviour // TypeDefIndex: 57061
	{
		// Fields
		private UnityEngine.Color color; // 0x18
		private List<Contribution> contributions; // 0x28
		private static LinkedList<P3dColor> instances; // 0x00
		private LinkedListNode<P3dColor> instancesNode; // 0x30
	
		// Properties
		public UnityEngine.Color Color { get => default; set {} } // 0x000000018B42E618-0x000000018B42E668 0x0000000185FB30D0-0x0000000185FB30E0
		public static LinkedList<P3dColor> Instances { get => default; } // 0x000000018B42E7A0-0x000000018B42E908 
		public int Total { get => default; } // 0x000000018B42E6B0-0x000000018B42E7A0 
		public int Solid { get => default; } // 0x000000018B42E668-0x000000018B42E6B0 
		public float Ratio { get => default; } // 0x000000018B42E2B4-0x000000018B42E46C 
	
		// Nested types
		private class Contribution // TypeDefIndex: 57060
		{
			// Fields
			public P3dColorCounter Counter; // 0x10
			public int Solid; // 0x18
	
			// Constructors
			public Contribution() {} // 0x0000000185FB30E0-0x0000000185FB30F0
		}
	
		// Constructors
		public P3dColor() {} // 0x000000018B42E59C-0x000000018B42E618
		static P3dColor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B42E0EC-0x000000018B42E2B4
		protected virtual void OnDisable() {} // 0x000000018B42E020-0x000000018B42E0EC
		public void Contribute(P3dColorCounter counter, int solid) {} // 0x000000018B42E46C-0x000000018B42E59C
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution) => default; // 0x000000018646DB20-0x000000018646DB28
	}

	public class P3dColorCounter : P3dPaintableTextureMonitorMask // TypeDefIndex: 57063
	{
		// Fields
		public static LinkedList<P3dColorCounter> Instances; // 0x00
		private LinkedListNode<P3dColorCounter> instancesNode; // 0x98
		private float threshold; // 0xA0
		[NonSerialized]
		private List<Contribution> contributions; // 0xA8
	
		// Properties
		public float Threshold { get => default; set {} } // 0x000000018B42D6F8-0x000000018B42D88C 0x000000018349D730-0x000000018349D740
		public List<Contribution> Contributions { get => default; } // 0x000000018B42D4B8-0x000000018B42D668 
	
		// Nested types
		public class Contribution // TypeDefIndex: 57062
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
			public Contribution() {} // 0x000000018B42BF34-0x000000018B42BF5C
			static Contribution() {} // 0x0000000185FB9B70-0x0000000185FB9B80
		}
	
		// Constructors
		public P3dColorCounter() {} // 0x0000000185492010-0x0000000185492020
		static P3dColorCounter() {} // 0x000000018B429490-0x000000018B42951C
	
		// Methods
		public static long GetTotal(ICollection<P3dColorCounter> counters = null) => default; // 0x000000018B42D668-0x000000018B42D6F8
		public static long GetCount(P3dColor color, ICollection<P3dColorCounter> counters = null) => default; // 0x000000018B42D354-0x000000018B42D4B8
		public static float GetRatio(P3dColor color, ICollection<P3dColorCounter> counters = null) => default; // 0x000000018B42DEDC-0x000000018B42DF14
		public int Count(P3dColor color) => default; // 0x000000018B42DB84-0x000000018B42DC10
		public float Ratio(P3dColor color) => default; // 0x000000018B42DAE8-0x000000018B42DB84
		protected override void OnEnable() {} // 0x000000018B42D88C-0x000000018B42DAE8
		protected override void OnDisable() {} // 0x000000018B42D0B4-0x000000018B42D1A4
		protected override void HandleComplete(int boost) {} // 0x000000018B42DC10-0x000000018B42DEDC
		private void ClearContributions() {} // 0x000000018B42D1A4-0x000000018B42D354
		private void PrepareContributions() {} // 0x000000018B42DF90-0x000000018B42E020
		private void Contribute(int scale) {} // 0x000000018B42DF14-0x000000018B42DF90
	}

	[Serializable]
	public abstract class P3dCommand // TypeDefIndex: 57064
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
		protected P3dCommand() {} // 0x0000000185492010-0x0000000185492020
		static P3dCommand() {} // 0x000000018B42EDD4-0x000000018B42EE50
	
		// Methods
		public static void BuildMaterial(ref Material material, ref int materialHash, string path, string keyword = null) {} // 0x000000018B42EA58-0x000000018B42EAF8
		public static int Compare(P3dCommand a, P3dCommand b) => default; // 0x000000018B42EAF8-0x000000018B42EB54
		public void SetState(bool preview, int priority) {} // 0x0000000185FD2590-0x0000000185FD25A0
		public virtual void Apply(Material material) {} // 0x000000018B42E908-0x000000018B42E9C4
		public abstract void Pool();
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);
		public abstract P3dCommand SpawnCopy();
		public P3dCommand SpawnCopyLocal(Transform transform) => default; // 0x000000018B42EB54-0x000000018B42EC94
		public P3dCommand SpawnCopyWorld(Transform transform) => default; // 0x000000018B42EC94-0x000000018B42EDD4
		protected T SpawnCopy<T>(Stack<T> pool)
			where T : P3dCommand, new() => default;
		public virtual void Apply(P3dPaintableTexture paintableTexture) {} // 0x000000018B42E9C4-0x000000018B42EA58
	}

	public static class P3dCommon // TypeDefIndex: 57066
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/PaintIn3D#"; // Metadata: 0x0207D531
		public const string ComponentMenuPrefix = "Paint in 3D/P3D "; // Metadata: 0x0207D563
		public const string ComponentHitMenuPrefix = "Paint in 3D/Hit/P3D "; // Metadata: 0x0207D574
		public static Action<Camera> OnCameraDraw; // 0x00
		private static int _Coord; // 0x08
		private static Mesh sphereMesh; // 0x10
		private static bool sphereMeshSet; // 0x18
		private static Mesh quadMesh; // 0x20
		private static bool quadMeshSet; // 0x28
		private static Texture2D tempReadTexture; // 0x30
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57065
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018B43168C-0x000000018B43186C
			public __c() {} // 0x000000018B4310BC-0x000000018B431168
	
			// Methods
			internal void _.cctor_b__5_0(Camera camera) {} // 0x000000018B430AAC-0x000000018B430B64
			internal void _.cctor_b__5_1(ScriptableRenderContext context, Camera camera) {} // 0x000000018B43094C-0x000000018B430A30
		}
	
		// Constructors
		static P3dCommon() {} // 0x000000018B430B64-0x000000018B430BE0
	
		// Methods
		public static float RatioToPercentage(float ratio01, int decimalPlaces) => default; // 0x000000018B430A30-0x000000018B430AAC
		public static RenderTexture GetRenderTexture(RenderTexture other) => default; // 0x000000018B4315CC-0x000000018B4315D4
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, RenderTexture other) => default; // 0x000000018B430F78-0x000000018B4310BC
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc) => default; // 0x000000018B42F958-0x000000018B42FA1C
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB) => default; // 0x000000018B42F1B4-0x000000018B42F1CC
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture) => default; // 0x000000018B431168-0x000000018B431360
		public static Quaternion NormalToCameraRotation(Vector3 normal, Camera optionalCamera = null) => default; // 0x000000018B431360-0x000000018B4315CC
		public static Vector3 GetCameraUp(Camera camera = null) => default; // 0x000000018B42F3E8-0x000000018B42F66C
		public static bool CanReadPixels(TextureFormat format) => default; // 0x000000018B430CF8-0x000000018B430DF8
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture) {} // 0x000000018B430BE0-0x000000018B430CF8
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture) {} // 0x000000018B42FAA4-0x000000018B42FBB0
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary) => default; // 0x000000018B430094-0x000000018B4301B0
		public static bool HasMipMaps(Texture texture) => default; // 0x000000018B42FBB0-0x000000018B42FE78
		public static Mesh GetSphereMesh() => default; // 0x000000018B4306FC-0x000000018B43094C
		public static Mesh GetMesh(GameObject root, Mesh mesh = null) => default; // 0x000000018B4315D4-0x000000018B431650
		public static Mesh GetQuadMesh() => default; // 0x000000018B430E50-0x000000018B430EB0
		public static UnityEngine.Color GetPixel(RenderTexture renderTexture, Vector2 uv, bool mipMaps = false /* Metadata: 0x0207D527 */) => default; // 0x000000018B431650-0x000000018B431658
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x0207D528 */, bool mipMaps = false /* Metadata: 0x0207D529 */, int width = 0 /* Metadata: 0x0207D52A */, int height = 0 /* Metadata: 0x0207D52B */) => default; // 0x000000018B42F1CC-0x000000018B42F208
		public static void SaveBytes(string saveName, byte[] data, bool save = true /* Metadata: 0x0207D52C */) {} // 0x000000018B42FE78-0x000000018B42FEFC
		public static byte[] LoadBytes(string saveName) => default; // 0x000000018B42FEFC-0x000000018B42FFB0
		public static bool SaveExists(string saveName) => default; // 0x000000018B42FFB0-0x000000018B430094
		public static void ClearSave(string saveName, bool save = true /* Metadata: 0x0207D52D */) {} // 0x000000018B430468-0x000000018B4304A0
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition) => default; // 0x000000018B4301B0-0x000000018B4302A4
		public static Vector3 GetPosition(Vector3 positionA, Vector3 positionB, Vector3 positionC) => default; // 0x000000018B4302A4-0x000000018B430468
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2) => default; // 0x000000018B4304A0-0x000000018B4306FC
		public static float GetRadius(Vector3 size) => default; // 0x000000018B431658-0x000000018B43168C
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition) => default; // 0x000000018B42F880-0x000000018B42F958
		public static float GetRadius(Vector3 size, Vector3 positionA, Vector3 positionB, Vector3 positionC) => default; // 0x000000018B42EFB4-0x000000018B42F024
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2) => default; // 0x000000018B42F024-0x000000018B42F0AC
		public static Vector3 ScaleAspect(Vector3 size, float aspect) => default; // 0x000000018B430DF8-0x000000018B430E50
		public static float GetAspect(Texture textureA, Texture textureB = null) => default; // 0x000000018B42F768-0x000000018B42F880
		public static void Blit(RenderTexture renderTexture, Texture other) {} // 0x000000018B42F66C-0x000000018B42F768
		public static void Blit(RenderTexture renderTexture, Material material, int pass) {} // 0x000000018B42F348-0x000000018B42F3E8
		public static Vector4 IndexToVector(int index) => default; // 0x000000018B42FA1C-0x000000018B42FAA4
		public static void Draw(Material material, int pass, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord) {} // 0x000000018B42F208-0x000000018B42F348
		public static void Draw(Material material, int pass) {} // 0x000000018B42EE50-0x000000018B42EFB4
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps) => default; // 0x000000018B430EB0-0x000000018B430F78
		public static Material GetMaterial(Renderer renderer, int materialIndex = 0 /* Metadata: 0x0207D52E */) => default; // 0x000000018B42F0AC-0x000000018B42F10C
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x0207D52F */) => default; // 0x000000018B42F10C-0x000000018B42F1B4
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1 /* Metadata: 0x0207D530 */) => default; // 0x000000018B43F548-0x000000018B43F5AC
		public static Shader LoadShader(string shaderName) => default; // 0x0000000185492010-0x0000000185492020
		public static Material BuildMaterial(Shader shader) => default; // 0x000000018B43F458-0x000000018B43F4D0
		public static Material BuildMaterial(string shaderName, string keyword = null) => default; // 0x000000018B43F4D0-0x000000018B43F548
	}

	public enum P3dCoord // TypeDefIndex: 57067
	{
		First = 0,
		Second = 1,
		Third = 2,
		Fourth = 3
	}

	public class P3dCoordCopier : ScriptableObject // TypeDefIndex: 57069
	{
		// Fields
		private Mesh source; // 0x18
		private Coord first; // 0x20
		private Coord second; // 0x24
		private Coord third; // 0x28
		private Coord fourth; // 0x2C
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
		public Mesh Source { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Coord First { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public Coord Second { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public Coord Third { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public Coord Fourth { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
	
		// Nested types
		public enum Coord // TypeDefIndex: 57068
		{
			First = 0,
			Second = 1,
			Third = 2,
			Fourth = 3,
			None = 4
		}
	
		// Constructors
		public P3dCoordCopier() {} // 0x000000018B4324A0-0x000000018B4324C4
		static P3dCoordCopier() {} // 0x000000018B432090-0x000000018B4324A0
	
		// Methods
		public List<Vector4> GetCoords(Coord coord) => default; // 0x000000018B431F8C-0x000000018B432038
		public void Generate() {} // 0x000000018B43186C-0x000000018B431F8C
		protected virtual void OnDestroy() {} // 0x000000018B432038-0x000000018B432090
	}

	public class P3dGraduallyFade : MonoBehaviour // TypeDefIndex: 57070
	{
		// Fields
		private P3dPaintableTexture paintableTexture; // 0x18
		private float threshold; // 0x20
		private float speed; // 0x24
		private P3dBlendMode blendMode; // 0x28
		private Texture blendTexture; // 0x60
		private P3dPaintableTexture blendPaintableTexture; // 0x68
		private UnityEngine.Color blendColor; // 0x70
		private Texture maskTexture; // 0x80
		private P3dPaintableTexture maskPaintableTexture; // 0x88
		private P3dChannel maskChannel; // 0x90
		private float counter; // 0x94
	
		// Properties
		public P3dPaintableTexture PaintableTexture { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float Threshold { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public float Speed { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000185FD25A0-0x0000000185FD25D0 0x000000018B432914-0x000000018B432940
		public Texture BlendTexture { get => default; set {} } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public P3dPaintableTexture BlendPaintableTexture { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public UnityEngine.Color BlendColor { get => default; set {} } // 0x0000000185FBB870-0x0000000185FBB880 0x0000000185FCCD80-0x0000000185FCCD90
		public Texture MaskTexture { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public P3dPaintableTexture MaskPaintableTexture { get => default; set {} } // 0x0000000185FB0510-0x0000000185FB0520 0x0000000186472AA8-0x0000000186472ABC
		public P3dChannel MaskChannel { get => default; set {} } // 0x00000001834A0D50-0x00000001834A0D60 0x00000001834A2260-0x00000001834A2270
	
		// Constructors
		public P3dGraduallyFade() {} // 0x000000018B432850-0x000000018B432914
	
		// Methods
		protected virtual void Update() {} // 0x000000018B4324C4-0x000000018B432850
	}

	[Serializable]
	public struct P3dGroup // TypeDefIndex: 57071
	{
		// Fields
		private int index; // 0x00
	
		// Constructors
		public P3dGroup(int newIndex) {
			index = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public static implicit operator int(P3dGroup group) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static implicit operator P3dGroup(int index) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public override string ToString() => default; // 0x000000018B432ECC-0x000000018B432ED4
	}

	public class P3dGroupData : ScriptableObject // TypeDefIndex: 57074
	{
		// Fields
		private int index; // 0x18
		private List<TextureData> textureDatas; // 0x20
		private string shaderData; // 0x28
		private List<Entry> entries; // 0x30
	
		// Properties
		public int Index { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x000000018B432E48-0x000000018B432ECC
		public List<TextureData> TextureDatas { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public string ShaderData { get => default; set {} } // 0x000000018B4329B4-0x000000018B432A30 0x000000018B432A30-0x000000018B432DC8
	
		// Nested types
		[Serializable]
		public class TextureData // TypeDefIndex: 57072
		{
			// Fields
			public string Name; // 0x10
			public P3dBlendMode BlendMode; // 0x18
	
			// Constructors
			public TextureData() {} // 0x00000001813AE9C0-0x00000001813AE9D0
		}
	
		private class Entry // TypeDefIndex: 57073
		{
			// Fields
			public string Path; // 0x10
			public string Property; // 0x18
	
			// Constructors
			public Entry() {} // 0x00000001813AE560-0x00000001813AE570
		}
	
		// Constructors
		public P3dGroupData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void TryGetShaderSlotName(string shaderPath, ref string propertyName) {} // 0x000000018B432940-0x000000018B4329B4
		public bool Supports(Shader shader) => default; // 0x000000018B432DC8-0x000000018B432E48
		public string GetName(bool prefixNumber) => default; // 0x000000018B43F3C0-0x000000018B43F458
	}

	[Serializable]
	public struct P3dHash // TypeDefIndex: 57075
	{
		// Fields
		private int v; // 0x00
	
		// Constructors
		public P3dHash(int newValue) {
			v = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018B432ED4-0x000000018B432F30
		public override int GetHashCode() => default; // 0x00000001818226B0-0x00000001818226C0
		public static implicit operator int(P3dHash hash) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static implicit operator P3dHash(int index) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public override string ToString() => default; // 0x000000018B432ECC-0x000000018B432ED4
	}

	[Serializable]
	public struct P3dHashedMaterial // TypeDefIndex: 57076
	{
		// Fields
		[NonSerialized]
		private Material instance; // 0x00
		private int hash; // 0x08
	
		// Constructors
		public P3dHashedMaterial(Material newInstance, int newHash) {
			instance = default;
			hash = default;
		} // 0x0000000186472594-0x00000001864725B0
	
		// Methods
		public bool TryGetInstance(out Material model) {
			model = default;
			return default;
		} // 0x000000018B432F30-0x000000018B432FF8
	}

	[Serializable]
	public struct P3dHashedModel // TypeDefIndex: 57077
	{
		// Fields
		[NonSerialized]
		private P3dModel instance; // 0x00
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedModel(P3dModel newInstance) => default; // 0x000000018B4330F0-0x000000018B433184
		public bool TryGetInstance(out P3dModel model) {
			model = default;
			return default;
		} // 0x000000018B432FF8-0x000000018B4330F0
	}

	[Serializable]
	public struct P3dHashedTexture // TypeDefIndex: 57078
	{
		// Fields
		[NonSerialized]
		private Texture instance; // 0x00
		private P3dHash hash; // 0x08
	
		// Methods
		public static implicit operator P3dHashedTexture(Texture newInstance) => default; // 0x000000018B433270-0x000000018B433334
		public static implicit operator Texture(P3dHashedTexture hashed) => default; // 0x000000018B43324C-0x000000018B433270
		public bool TryGetInstance(out Texture texture) {
			texture = default;
			return default;
		} // 0x000000018B433184-0x000000018B43324C
	}

	public struct P3dHit // TypeDefIndex: 57079
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
		} // 0x000000018B433334-0x000000018B4333C4
	}

	[Serializable]
	public class P3dLineConnector // TypeDefIndex: 57081
	{
		// Fields
		private float hitSpacing; // 0x10
		private int hitLimit; // 0x14
		protected bool connectHits; // 0x18
		protected bool clipConnected; // 0x19
		[NonSerialized]
		private List<Link> links; // 0x20
		[NonSerialized]
		private static Stack<Link> linkPool; // 0x00
		[NonSerialized]
		protected P3dHitCache hitCache; // 0x28
	
		// Properties
		public float HitSpacing { get => default; set {} } // 0x0000000185FBB0B0-0x0000000185FBB0C0 0x0000000181DCCCE0-0x0000000181DCCCF0
		public int HitLimit { get => default; set {} } // 0x00000001813C0520-0x00000001813C0530 0x0000000185FB21A0-0x0000000185FB21B0
		public bool ConnectHits { get => default; set {} } // 0x0000000181A73EB0-0x0000000181A73EC0 0x00000001813C0430-0x00000001813C0440
		public bool ClipConnected { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000181A73E90-0x0000000181A73EA0
		public P3dHitCache HitCache { get => default; } // 0x000000018B4334D0-0x000000018B4334F0 
	
		// Nested types
		private class Link // TypeDefIndex: 57080
		{
			// Fields
			public object Owner; // 0x10
			public Vector3 Position; // 0x18
			public Vector3 EndPosition; // 0x24
			public float Age; // 0x30
			public bool Preview; // 0x34
	
			// Constructors
			public Link() {} // 0x0000000181A6E380-0x0000000181A6E390
		}
	
		// Constructors
		public P3dLineConnector() {} // 0x000000018B433F24-0x000000018B433FB0
		static P3dLineConnector() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B4334F0-0x000000018B4335D8
		public void ResetConnections() {} // 0x000000018B4333C4-0x000000018B4334D0
		public void BreakHits(object owner) {} // 0x000000018B4335D8-0x000000018B433D40
		public void SubmitLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation, object owner) {} // 0x000000018B433DF4-0x000000018B433F24
		public void Update() {} // 0x000000018B433D40-0x000000018B433DF4
		private bool TryGetLink(object owner, ref Link link) => default; // 0x000000018B433FB0-0x000000018B434064
	}

	public class P3dMask : MonoBehaviour // TypeDefIndex: 57082
	{
		// Fields
		private Texture texture; // 0x18
		private P3dChannel channel; // 0x20
		private Vector2 stretch; // 0x24
		private static LinkedList<P3dMask> instances; // 0x00
		private LinkedListNode<P3dMask> instancesNode; // 0x30
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public P3dChannel Channel { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public Vector2 Stretch { get => default; set {} } // 0x0000000185FB1F70-0x0000000185FB1F90 0x0000000185FD22E0-0x0000000185FD22F0
		public static LinkedList<P3dMask> Instances { get => default; } // 0x000000018B43447C-0x000000018B4344CC 
		public Matrix4x4 Matrix { get => default; } // 0x000000018B4344CC-0x000000018B434524 
	
		// Constructors
		public P3dMask() {} // 0x000000018B434460-0x000000018B43447C
		static P3dMask() {} // 0x000000018B4343E4-0x000000018B434460
	
		// Methods
		public static P3dMask Find(Vector3 position, LayerMask layers) => default; // 0x000000018B434064-0x000000018B4342EC
		protected virtual void OnEnable() {} // 0x000000018B434368-0x000000018B4343E4
		protected virtual void OnDisable() {} // 0x000000018B4342EC-0x000000018B434368
	}

	public class P3dMaterialCloner : MonoBehaviour // TypeDefIndex: 57083
	{
		// Fields
		private int index; // 0x18
		[NonSerialized]
		private Renderer cachedRenderer; // 0x20
		[NonSerialized]
		private bool cachedRendererSet; // 0x28
		[NonSerialized]
		private P3dPaintable cachedPaintable; // 0x30
		[NonSerialized]
		private bool cachedPaintableSet; // 0x38
		private bool activated; // 0x39
		private Material current; // 0x40
		private Material original; // 0x48
	
		// Properties
		public int Index { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public Renderer CachedRenderer { get => default; } // 0x000000018B434948-0x000000018B4349A0 
		public P3dPaintable CachedPaintable { get => default; } // 0x000000018B4348F0-0x000000018B434948 
		public Material Original { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public Material Current { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public bool Activated { get => default; } // 0x0000000185FB0710-0x0000000185FB0720 
	
		// Constructors
		public P3dMaterialCloner() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Activate() {} // 0x000000018B434524-0x000000018B434638
		public void Deactivate() {} // 0x000000018B434638-0x000000018B4346C0
		public void ReplaceAll(Material from, Material to) {} // 0x000000018B4346C0-0x000000018B434810
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial) {} // 0x000000018B434810-0x000000018B4348F0
	}

	public static class P3dMeshCache // TypeDefIndex: 57085
	{
		// Fields
		private static Dictionary<Mesh, MeshData> cachedData; // 0x00
	
		// Nested types
		private class MeshData // TypeDefIndex: 57084
		{
			// Fields
			private Vector3[] positions; // 0x10
			private int[] indices; // 0x18
			private int total; // 0x20
	
			// Constructors
			public MeshData() {} // 0x000000018B4296D0-0x000000018B429740
	
			// Methods
			public void Update(Mesh mesh) {} // 0x000000018B4349A0-0x000000018B434BB8
			public bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC) => default; // 0x000000018B434BB8-0x000000018B434C44
		}
	
		// Constructors
		static P3dMeshCache() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool GetTrianglePositions(RaycastHit hit, ref Vector3 positionA, ref Vector3 positionB, ref Vector3 positionC) => default; // 0x000000018B42951C-0x000000018B4296D0
	}

	public class P3dModel : MonoBehaviour // TypeDefIndex: 57087
	{
		// Fields
		protected P3dPaintable paintable; // 0x18
		protected bool includeScale; // 0x20
		protected UseMeshType useMesh; // 0x24
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
		public virtual P3dPaintable Paintable { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public virtual bool IncludeScale { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public UseMeshType UseMesh { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public P3dHash Hash { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x000000018B435FF0-0x000000018B436044
		public static LinkedList<P3dModel> Instances { get => default; } // 0x000000018B435F58-0x000000018B435FA8 
		public bool Prepared { get => default; set {} } // 0x0000000185FBBA50-0x0000000185FBBA60 0x0000000185FBBA60-0x0000000185FBBA70
		public Mesh PreparedMesh { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public GameObject CachedGameObject { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public Renderer CachedRenderer { get => default; } // 0x000000018B435F30-0x000000018B435F58 
		public Material[] Materials { get => default; } // 0x000000018B435FA8-0x000000018B435FF0 
	
		// Nested types
		public enum UseMeshType // TypeDefIndex: 57086
		{
			AsIs = 0,
			AutoSeamFix = 1
		}
	
		// Constructors
		public P3dModel() {} // 0x0000000185C20250-0x0000000185C20260
		static P3dModel() {} // 0x000000018B435E50-0x000000018B435F30
	
		// Methods
		public int GetMaterialIndex(Material material) => default; // 0x000000018B4350BC-0x000000018B43520C
		private void CacheRenderer() {} // 0x000000018B434C44-0x000000018B434D18
		public void DirtyMaterials() {} // 0x0000000185FD25D0-0x0000000185FD25E0
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask) => default; // 0x000000018B434D18-0x000000018B4350BC
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC) {} // 0x000000018B43559C-0x000000018B435794
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC) {} // 0x000000018B43520C-0x000000018B4353D4
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC) {} // 0x000000018B4353D4-0x000000018B43559C
		public int GetSubmesh(P3dPaintableTexture paintableTexture) => default; // 0x000000018B435BBC-0x000000018B435C64
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix, P3dCoord coord) {} // 0x000000018B435794-0x000000018B435BBC
		protected virtual void OnEnable() {} // 0x000000018B435D70-0x000000018B435E50
		protected virtual void OnDisable() {} // 0x000000018B435CE8-0x000000018B435D70
		protected virtual void OnDestroy() {} // 0x000000018B435C64-0x000000018B435CE8
	}

	[Serializable]
	public abstract class P3dModifier // TypeDefIndex: 57088
	{
		// Fields
		private bool preview; // 0x10
		private bool unique; // 0x11
	
		// Properties
		public bool Preview { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public bool Unique { get; set; } // 0x0000000185FB22C0-0x0000000185FB22D0 0x0000000185FB2560-0x0000000185FB2570
	
		// Constructors
		protected P3dModifier() {} // 0x0000000185FD24F0-0x0000000185FD2500
	
		// Methods
		public void ModifyAngle(ref float angle, float pressure) {} // 0x000000018B436B08-0x000000018B436B94
		protected virtual void OnModifyAngle(ref float angle, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x000000018B436B94-0x000000018B436C18
		protected virtual void OnModifyColor(ref UnityEngine.Color color, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyHardness(ref float hardness, float pressure) {} // 0x000000018B436C18-0x000000018B436CA4
		protected virtual void OnModifyHardness(ref float hardness, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyOpacity(ref float opacity, float pressure) {} // 0x000000018B436CA4-0x000000018B436D30
		protected virtual void OnModifyOpacity(ref float opacity, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyRadius(ref float radius, float pressure) {} // 0x000000018B436DBC-0x000000018B436E48
		protected virtual void OnModifyRadius(ref float radius, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyScale(ref Vector3 scale, float pressure) {} // 0x000000018B436E48-0x000000018B436ED4
		protected virtual void OnModifyScale(ref Vector3 scale, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyTexture(ref Texture texture, float pressure) {} // 0x000000018B436ED4-0x000000018B436F58
		protected virtual void OnModifyTexture(ref Texture texture, float pressure) {} // 0x0000000185492010-0x0000000185492020
		public void ModifyPosition(ref Vector3 position, float pressure) {} // 0x000000018B436D30-0x000000018B436DBC
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class P3dModifierList // TypeDefIndex: 57089
	{
		// Fields
		private List<P3dModifier> modifiers; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x000000018B436A44-0x000000018B436A84 
		public List<P3dModifier> Instances { get => default; } // 0x000000018B436A84-0x000000018B436B08 
	
		// Constructors
		public P3dModifierList() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ModifyAngle(ref float angle, bool preview, float pressure) {} // 0x000000018B436044-0x000000018B436184
		public void ModifyColor(ref UnityEngine.Color color, bool preview, float pressure) {} // 0x000000018B436184-0x000000018B4362C4
		public void ModifyHardness(ref float hardness, bool preview, float pressure) {} // 0x000000018B4362C4-0x000000018B436404
		public void ModifyOpacity(ref float opacity, bool preview, float pressure) {} // 0x000000018B436404-0x000000018B436544
		public void ModifyRadius(ref float radius, bool preview, float pressure) {} // 0x000000018B436684-0x000000018B4367C4
		public void ModifyScale(ref Vector3 scale, bool preview, float pressure) {} // 0x000000018B4367C4-0x000000018B436904
		public void ModifyTexture(ref Texture texture, bool preview, float pressure) {} // 0x000000018B436904-0x000000018B436A44
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure) {} // 0x000000018B436544-0x000000018B436684
	}

	public class P3dPaintable : P3dModel // TypeDefIndex: 57091
	{
		// Fields
		private ActivationType activation; // 0xF8
		private Vector3 baseScale; // 0xFC
		private List<Renderer> otherRenderers; // 0x108
		private UnityEvent onActivating; // 0x110
		private UnityEvent onActivated; // 0x118
		private bool activated; // 0x120
		[NonSerialized]
		private HashSet<P3dPaintableTexture> paintableTextures; // 0x128
		[NonSerialized]
		private static List<P3dMaterialCloner> materialCloners; // 0x00
		[NonSerialized]
		private List<P3dPaintableTexture> tempPaintableTextures; // 0x130
	
		// Properties
		public override P3dPaintable Paintable { get => default; set {} } // 0x000000018B43DC24-0x000000018B43DC44 0x0000000185492010-0x0000000185492020
		public ActivationType Activation { get => default; set {} } // 0x0000000185FCD270-0x0000000185FCD280 0x0000000185FCD280-0x0000000185FCD290
		public Vector3 BaseScale { get => default; set {} } // 0x0000000185FBA310-0x0000000185FBA330 0x0000000185FD2600-0x0000000185FD2620
		public List<Renderer> OtherRenderers { get => default; set {} } // 0x0000000181ABEDF0-0x0000000181ABEE00 0x0000000187A474C4-0x0000000187A474D8
		public UnityEvent OnActivating { get => default; } // 0x000000018B43DBA8-0x000000018B43DC24 
		public UnityEvent OnActivated { get => default; } // 0x000000018B43DB2C-0x000000018B43DBA8 
		public bool Activated { get => default; } // 0x0000000185FB9310-0x0000000185FB9320 
		public HashSet<P3dPaintableTexture> PaintableTextures { get => default; } // 0x0000000185FB8550-0x0000000185FB8560 
	
		// Nested types
		public enum ActivationType // TypeDefIndex: 57090
		{
			Awake = 0,
			OnEnable = 1,
			Start = 2,
			OnFirstUse = 3
		}
	
		// Constructors
		public P3dPaintable() {} // 0x000000018B43DA30-0x000000018B43DB2C
		static P3dPaintable() {} // 0x000000018B43D9A4-0x000000018B43DA30
	
		// Methods
		public void RemoveComponents() {} // 0x000000018B43D6B8-0x000000018B43D820
		public void ScaleSize(ref int width, ref int height) {} // 0x000000018B43D820-0x000000018B43D930
		public void Activate() {} // 0x000000018B43CC84-0x000000018B43CEE8
		private void AddPaintableTextures(Transform root) {} // 0x000000018B43CEE8-0x000000018B43D130
		public void Deactivate() {} // 0x000000018B43D2D4-0x000000018B43D5FC
		public void ClearAll(UnityEngine.Color color) {} // 0x000000018B43D14C-0x000000018B43D16C
		public void ClearAll(Texture texture, UnityEngine.Color color) {} // 0x000000018B43D16C-0x000000018B43D2D4
		public void Register(P3dPaintableTexture paintableTexture) {} // 0x000000018B43D660-0x000000018B43D6B8
		public void Unregister(P3dPaintableTexture paintableTexture) {} // 0x000000018B43D94C-0x000000018B43D9A4
		protected virtual void Awake() {} // 0x000000018B43D130-0x000000018B43D14C
		protected override void OnEnable() {} // 0x000000018B43D5FC-0x000000018B43D660
		protected virtual void Start() {} // 0x000000018B43D930-0x000000018B43D94C
	}

	public class P3dPaintableManager : MonoBehaviour // TypeDefIndex: 57092
	{
		// Fields
		private static LinkedList<P3dPaintableManager> instances; // 0x00
		private LinkedListNode<P3dPaintableManager> instancesNode; // 0x18
	
		// Properties
		public static LinkedList<P3dPaintableManager> Instances { get => default; } // 0x000000018B437BE4-0x000000018B437C34 
	
		// Constructors
		public P3dPaintableManager() {} // 0x000000018646DB20-0x000000018646DB28
		static P3dPaintableManager() {} // 0x000000018B437B68-0x000000018B437BE4
	
		// Methods
		public static P3dPaintableManager GetOrCreateInstance() => default; // 0x000000018B437210-0x000000018B43735C
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture) {} // 0x000000018B437690-0x000000018B437894
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture) {} // 0x000000018B437094-0x000000018B437210
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group) {} // 0x000000018B437594-0x000000018B437690
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group) {} // 0x000000018B437894-0x000000018B437974
		public static P3dCommand Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture) => default; // 0x000000018B437974-0x000000018B437A24
		protected virtual void OnEnable() {} // 0x000000018B437518-0x000000018B437594
		protected virtual void OnDisable() {} // 0x000000018B43749C-0x000000018B437518
		protected virtual void LateUpdate() {} // 0x000000018B43735C-0x000000018B43749C
		private void ClearAll() {} // 0x000000018B436F58-0x000000018B437094
		private void UpdateAll() {} // 0x000000018B437A24-0x000000018B437B68
	}

	public class P3dPaintableState // TypeDefIndex: 57093
	{
		// Fields
		public RenderTexture Texture; // 0x10
		public List<P3dCommand> Commands; // 0x18
		private static Stack<P3dPaintableState> pool; // 0x00
	
		// Constructors
		public P3dPaintableState() {} // 0x000000018B438150-0x000000018B4381C8
		static P3dPaintableState() {} // 0x000000018B4380C4-0x000000018B438150
	
		// Methods
		public static P3dPaintableState Pop() => default; // 0x000000018B437DAC-0x000000018B437E60
		public void Write(RenderTexture current) {} // 0x000000018B437E60-0x000000018B437F48
		public void Write(List<P3dCommand> commands) {} // 0x000000018B437F48-0x000000018B437FA8
		public void Write(RenderTexture current, List<P3dCommand> commands) {} // 0x000000018B437FA8-0x000000018B4380C4
		private void Clear() {} // 0x000000018B437C34-0x000000018B437D34
		public void Pool() {} // 0x000000018B437D34-0x000000018B437DAC
	}

	public class P3dPaintableTexture : MonoBehaviour // TypeDefIndex: 57103
	{
		// Fields
		private P3dSlot slot; // 0x18
		private P3dCoord coord; // 0x28
		private P3dGroup group; // 0x2C
		private UndoRedoType undoRedo; // 0x30
		private int stateLimit; // 0x34
		private SaveLoadType saveLoad; // 0x38
		private string saveName; // 0x40
		private int width; // 0x48
		private int height; // 0x4C
		private Texture texture; // 0x50
		private UnityEngine.Color color; // 0x58
		private RenderTextureFormat format; // 0x68
		private MipType mipMaps; // 0x6C
		private FilterType filter; // 0x70
		private AnisoType aniso; // 0x74
		private WrapType wrapU; // 0x78
		private WrapType wrapV; // 0x7C
		private ExistingType existing; // 0x80
		private ConversionType conversion; // 0x84
		private Texture localMaskTexture; // 0x88
		private P3dChannel localMaskChannel; // 0x90
		private string shaderKeyword; // 0x98
		protected P3dHash hash; // 0xA0
		private bool isDummy; // 0xA4
		private string output; // 0xA8
		private Action<P3dCommand> OnAddCommand; // 0xB0
		private static Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal; // 0x00
		public static Action<P3dPaintableTexture> OnInstanceAdded; // 0x08
		public static Action<P3dPaintableTexture> OnInstanceRemoved; // 0x10
		private Action<bool> OnModified; // 0xB8
		private bool activated; // 0xC0
		private RenderTexture current; // 0xC8
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
		public P3dSlot Slot { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x0000000185FB30D0-0x0000000185FB30E0
		public P3dCoord Coord { get => default; set {} } // 0x0000000185FB0640-0x0000000185FB0650 0x0000000181C9AC80-0x0000000181C9AC90
		public P3dGroup Group { get => default; set {} } // 0x00000001813D0A90-0x00000001813D0AA0 0x0000000185FB0630-0x0000000185FB0640
		public UndoRedoType UndoRedo { get => default; set {} } // 0x0000000185FB07E0-0x0000000185FB07F0 0x00000001813CFF60-0x00000001813CFF70
		public int StateLimit { get => default; set {} } // 0x00000001813E6F50-0x00000001813E6F60 0x0000000185FB07C0-0x0000000185FB07D0
		public SaveLoadType SaveLoad { get => default; set {} } // 0x0000000185F05C80-0x0000000185F05C90 0x00000001813E5E30-0x00000001813E5E40
		public string SaveName { get => default; set {} } // 0x0000000185FB05D0-0x0000000185FB05E0 0x00000001813FF010-0x00000001813FF020
		public int Width { get => default; set {} } // 0x0000000185FB06F0-0x0000000185FB0700 0x0000000185FB0570-0x0000000185FB0580
		public int Height { get => default; set {} } // 0x0000000184A4E570-0x0000000184A4E580 0x0000000185FB06E0-0x0000000185FB06F0
		public Texture Texture { get => default; set {} } // 0x0000000185FD25E0-0x0000000185FD25F0 0x0000000181460F60-0x0000000181460F70
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FB0B10-0x0000000185FB0B20 0x0000000185FB1D60-0x0000000185FB1D70
		public RenderTextureFormat Format { get => default; set {} } // 0x0000000185FB0A30-0x0000000185FB0A40 0x0000000185FB0B00-0x0000000185FB0B10
		public MipType MipMaps { get => default; set {} } // 0x0000000185FB06C0-0x0000000185FB06D0 0x0000000185FB09F0-0x0000000185FB0A00
		public FilterType Filter { get => default; set {} } // 0x0000000185FB0840-0x0000000185FB0850 0x0000000185FB0690-0x0000000185FB06A0
		public AnisoType Aniso { get => default; set {} } // 0x0000000185FB05C0-0x0000000185FB05D0 0x0000000185FB0830-0x0000000185FB0840
		public WrapType WrapU { get => default; set {} } // 0x0000000185FB0610-0x0000000185FB0620 0x0000000185FB0560-0x0000000185FB0570
		public WrapType WrapV { get => default; set {} } // 0x000000018140C940-0x000000018140C950 0x0000000185FB05B0-0x0000000185FB05C0
		public ExistingType Existing { get => default; set {} } // 0x0000000185FBB860-0x0000000185FBB870 0x000000018140C930-0x000000018140C940
		public ConversionType Conversion { get => default; set {} } // 0x0000000186472AA8-0x0000000186472ABC 0x0000000182FB0000-0x0000000182FB0010
		public Texture LocalMaskTexture { get => default; set {} } // 0x00000001834A2260-0x00000001834A2270 0x0000000185FB0510-0x0000000185FB0520
		public P3dChannel LocalMaskChannel { get => default; set {} } // 0x00000001873350D4-0x00000001873350E8 0x00000001834A0D50-0x00000001834A0D60
		public string ShaderKeyword { get => default; set {} } // 0x000000018B43CC20-0x000000018B43CC74 0x0000000181E336C0-0x0000000181E336D0
		public P3dHash Hash { get => default; set {} } // 0x0000000185FD25F0-0x0000000185FD2600 0x0000000185FB2320-0x0000000185FB2330
		public bool IsDummy { get => default; set {} } // 0x000000018774BD8C-0x000000018774BDA0 0x0000000185FB9C80-0x0000000185FB9C90
		public string Output { get => default; set {} } // 0x000000018B43C6F4-0x000000018B43C784 0x000000018349D730-0x000000018349D740
		public static LinkedList<P3dPaintableTexture> Instances { get => default; } // 0x0000000185FB9C20-0x0000000185FB9C30 
		public bool Activated { get => default; } // 0x000000018B43C86C-0x000000018B43C880 
		public bool CanUndo { get => default; } // 0x000000018B43C814-0x000000018B43C86C 
		public bool CanRedo { get => default; } // 0x0000000185FB02F0-0x0000000185FB0300 
		public List<P3dPaintableState> States { get => default; } // 0x0000000185FB2390-0x0000000185FB23A0 
		public int StateIndex { get => default; } // 0x000000018B43C924-0x000000018B43C954 
		public Material Material { get => default; } // 0x000000018B43C954-0x000000018B43C9E4 
		public P3dPaintable Paintable { get => default; } // 0x000000018B43CBC8-0x000000018B43CC20 
		public RenderTexture Current { get => default; set {} } // 0x0000000185FB15A0-0x0000000185FB15B0 0x0000000185FB0300-0x0000000185FB0310
		public RenderTexture Preview { get => default; } // 0x000000018B43A878-0x000000018B43AACC 
		public bool CommandsPending { get => default; } // 0x000000018B43988C-0x000000018B4399F4 
	
		// Events
		public event Action<P3dCommand> OnAddCommand;
		public static event Action<P3dPaintableTexture, P3dCommand> OnAddCommandGlobal;
		public event Action<bool> OnModified;
	
		// Nested types
		public enum UndoRedoType // TypeDefIndex: 57094
		{
			None = 0,
			FullTextureCopy = 1,
			LocalCommandCopy = 2
		}
	
		public enum SaveLoadType // TypeDefIndex: 57095
		{
			Manual = 0,
			Automatic = 1,
			SemiManual = 2
		}
	
		public enum MipType // TypeDefIndex: 57096
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum FilterType // TypeDefIndex: 57097
		{
			Auto = -1,
			Point = 0,
			Bilinear = 1,
			Trilinear = 2
		}
	
		public enum AnisoType // TypeDefIndex: 57098
		{
			Auto = -1,
			Off = 0,
			One = 1,
			Four = 4,
			Eight = 8,
			Sixteen = 16
		}
	
		public enum WrapType // TypeDefIndex: 57099
		{
			Auto = -1,
			Repeat = 0,
			Clamp = 1,
			Mirror = 2,
			MirrorOnce = 3
		}
	
		public enum ExistingType // TypeDefIndex: 57100
		{
			Ignore = 0,
			Use = 1,
			UseAndKeep = 2
		}
	
		public enum ConversionType // TypeDefIndex: 57101
		{
			None = 0,
			Normal = 1,
			Premultiply = 2
		}
	
		[Serializable]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture> // TypeDefIndex: 57102
		{
			// Constructors
			public PaintableTextureEvent() {} // 0x000000018B43CC74-0x000000018B43CC84
		}
	
		// Constructors
		public P3dPaintableTexture() {} // 0x000000018B43C328-0x000000018B43C468
		static P3dPaintableTexture() {} // 0x000000018B43F384-0x000000018B43F3C0
	
		// Methods
		public static List<P3dPaintableTexture> FilterAll(P3dModel model, P3dGroup group) => default; // 0x000000018B439A90-0x000000018B439B40
		public void ClearStates() {} // 0x000000018B43BF04-0x000000018B43BF90
		public void StoreState() {} // 0x000000018B43C160-0x000000018B43C258
		public void Undo() {} // 0x000000018B43B9E0-0x000000018B43BAA8
		public void Redo() {} // 0x000000018B43BDF8-0x000000018B43BE0C
		public void SetColor(string html) {} // 0x000000018B43AACC-0x000000018B43AB00
		public Vector2 GetCoord(ref P3dHit hit) => default; // 0x000000018B43AB00-0x000000018B43AB2C
		public Vector2 GetCoord(ref RaycastHit hit) => default; // 0x000000018B43BE0C-0x000000018B43BF04
		private bool StatesContainTextureOrCommands() => default; // 0x000000018B43B120-0x000000018B43B1EC
		private bool LastStateWithTextureOr0(ref int startIndex) => default; // 0x000000018B43B644-0x000000018B43B9E0
		private void RebuildFromCommands() {} // 0x000000018B439750-0x000000018B43988C
		private void AddState() {} // 0x000000018B43BF90-0x000000018B43C0B0
		private void TrimFuture() {} // 0x000000018B43C0B0-0x000000018B43C160
		private void TrimPast() {} // 0x000000018B43B380-0x000000018B43B39C
		public void NotifyOnModified(bool preview) {} // 0x000000018B43ABD8-0x000000018B43AE74
		public Texture2D GetReadableCopy(bool convertBack = false /* Metadata: 0x0207D598 */) => default; // 0x000000018B43AB2C-0x000000018B43ABD8
		public byte[] GetPngData(bool convertBack = false /* Metadata: 0x0207D599 */) => default; // 0x000000018B43AE74-0x000000018B43AF20
		public byte[] GetTgaData(bool convertBack = false /* Metadata: 0x0207D59A */) => default; // 0x000000018B439B40-0x000000018B439B6C
		public void Clear() {} // 0x000000018B439B6C-0x000000018B439CA0
		public void Clear(Texture texture, UnityEngine.Color tint, bool updateMips = true /* Metadata: 0x0207D59B */) {} // 0x000000018B43BB7C-0x000000018B43BBA0
		public void Replace() {} // 0x000000018B43BAA8-0x000000018B43BB7C
		public void Replace(Texture texture, UnityEngine.Color tint) {} // 0x000000018B43BBA0-0x000000018B43BD74
		public bool Resize(int width, int height, bool copyContents = true /* Metadata: 0x0207D59C */) => default; // 0x000000018B43BDEC-0x000000018B43BDF8
		public void Save() {} // 0x000000018B43BD74-0x000000018B43BDEC
		public void Save(string saveName) {} // 0x000000018B43B370-0x000000018B43B380
		public void Load() {} // 0x000000018B43B308-0x000000018B43B370
		public void Load(string saveName, bool replace = true /* Metadata: 0x0207D59D */) {} // 0x000000018B43B1EC-0x000000018B43B308
		public void LoadFromData(byte[] data, bool allowResize = true /* Metadata: 0x0207D59E */) {} // 0x000000018B43B06C-0x000000018B43B120
		public void HidePreview() {} // 0x000000018B43AF20-0x000000018B43B06C
		public static void HideAllPreviews() {} // 0x000000018B439A40-0x000000018B439A90
		public void ClearSave() {} // 0x000000018B4399F4-0x000000018B439A40
		public static void ClearSave(string saveName) {} // 0x000000018B43C258-0x000000018B43C328
		public void UpdateMaterial() {} // 0x000000018B439CA0-0x000000018B439D44
		public void CopySize() {} // 0x000000018B439D44-0x000000018B439D80
		public void CopyTexture() {} // 0x000000018B4390FC-0x000000018B4395C0
		public void Activate() {} // 0x000000018B439D80-0x000000018B439E9C
		public void Deactivate() {} // 0x000000018B43B54C-0x000000018B43B644
		protected virtual void OnEnable() {} // 0x000000018B43B488-0x000000018B43B54C
		protected virtual void OnDisable() {} // 0x000000018B43B39C-0x000000018B43B3D0
		protected virtual void OnApplicationPause(bool paused) {} // 0x000000018B43B3D0-0x000000018B43B488
		protected virtual void OnDestroy() {} // 0x000000018B4395C0-0x000000018B439750
		public void AddCommand(P3dCommand command) {} // 0x000000018B43C880-0x000000018B43C8D4
		public void ClearCommands() {} // 0x000000018B439E9C-0x000000018B43A244
		public void ExecuteCommands(bool sendNotifications, bool doSort) {} // 0x000000018B43A244-0x000000018B43A878
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, RenderTexture main, ref RenderTexture swap) {} // 0x000000018B43C468-0x000000018B43C630
	}

	public abstract class P3dPaintableTextureMonitor : MonoBehaviour // TypeDefIndex: 57104
	{
		// Fields
		private P3dPaintableTexture paintableTexture; // 0x18
		private float interval; // 0x20
		private bool async; // 0x24
		protected int downsampleSteps; // 0x28
		private Action OnUpdated; // 0x30
		protected P3dPaintableTexture registeredPaintableTexture; // 0x38
		private float cooldown; // 0x40
		private P3dReader currentReader; // 0x48
		protected NativeArray<Color32> currentPixels; // 0x50
	
		// Properties
		public P3dPaintableTexture PaintableTexture { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x000000018B4390D8-0x000000018B4390FC
		public float Interval { get; set; } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public bool Async { get; set; } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
		public int DownsampleSteps { get; set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public bool Registered { get; } // 0x000000018B438FF4-0x000000018B439044 
		public P3dReader CurrentReader { get; } // 0x00000001813ECF20-0x00000001813ECF30 
	
		// Events
		public event Action OnUpdated;
	
		// Constructors
		protected P3dPaintableTextureMonitor() {} // 0x000000018B438F4C-0x000000018B438F60
	
		// Methods
		public void MarkCurrentReaderAsDirty() {} // 0x000000018B438A30-0x000000018B438A40
		public void Register() {} // 0x000000018B438BD8-0x000000018B438CB0
		public void Unregister() {} // 0x000000018B438CB0-0x000000018B438D7C
		protected void InvokeOnUpdated() {} // 0x000000018B438A1C-0x000000018B438A30
		protected virtual void OnEnable() {} // 0x000000018B438B3C-0x000000018B438BD8
		protected virtual void OnDisable() {} // 0x000000018B438AA0-0x000000018B438B3C
		protected virtual void OnDestroy() {} // 0x000000018B438A40-0x000000018B438AA0
		protected virtual void Update() {} // 0x000000018B438D7C-0x000000018B438F4C
		private void HandleCompleteCurrent(NativeArray<Color32> pixels) {} // 0x000000018B438904-0x000000018B438A08
		private void HandleModified(bool preview) {} // 0x000000018B438A08-0x000000018B438A1C
		protected abstract void HandleComplete(int boost);
	}

	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor // TypeDefIndex: 57105
	{
		// Fields
		private Mesh maskMesh; // 0x60
		private int maskSubmesh; // 0x68
		private Texture maskTexture; // 0x70
		private P3dChannel maskChannel; // 0x78
		protected int total; // 0x7C
		private P3dReader maskReader; // 0x80
		protected NativeArray<byte> maskPixels; // 0x88
	
		// Properties
		public Mesh MaskMesh { get; set; } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public int MaskSubmesh { get; set; } // 0x0000000185FB0B00-0x0000000185FB0B10 0x0000000185FB0B10-0x0000000185FB0B20
		public Texture MaskTexture { get; set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public P3dChannel MaskChannel { get; set; } // 0x0000000185FB0560-0x0000000185FB0570 0x0000000185FB05C0-0x0000000185FB05D0
		public int Total { get; } // 0x0000000185FB05B0-0x0000000185FB05C0 
		public P3dReader MaskReader { get; } // 0x000000018140CF50-0x000000018140CF60 
	
		// Constructors
		protected P3dPaintableTextureMonitorMask() {} // 0x000000018B4388E8-0x000000018B438904
	
		// Methods
		public void MarkMaskReaderAsDirty() {} // 0x000000018B4383D4-0x000000018B4383EC
		private void HandleCompleteMask(NativeArray<Color32> pixels) {} // 0x000000018B4381C8-0x000000018B4383D4
		protected override void OnEnable() {} // 0x000000018B438508-0x000000018B4385AC
		protected override void OnDisable() {} // 0x000000018B438464-0x000000018B438508
		protected override void OnDestroy() {} // 0x000000018B4383EC-0x000000018B438464
		protected override void Update() {} // 0x000000018B4385AC-0x000000018B4388E8
	}

	[Serializable]
	public class P3dPointConnector // TypeDefIndex: 57107
	{
		// Fields
		private float hitSpacing; // 0x10
		private int hitLimit; // 0x14
		protected bool connectHits; // 0x18
		protected bool clipConnected; // 0x19
		[NonSerialized]
		private List<Link> links; // 0x20
		[NonSerialized]
		private static Stack<Link> linkPool; // 0x00
		[NonSerialized]
		protected P3dHitCache hitCache; // 0x28
	
		// Properties
		public float HitSpacing { get => default; set {} } // 0x0000000185FBB0B0-0x0000000185FBB0C0 0x0000000181DCCCE0-0x0000000181DCCCF0
		public int HitLimit { get => default; set {} } // 0x00000001813C0520-0x00000001813C0530 0x0000000185FB21A0-0x0000000185FB21B0
		public bool ConnectHits { get => default; set {} } // 0x0000000181A73EB0-0x0000000181A73EC0 0x00000001813C0430-0x00000001813C0440
		public bool ClipConnected { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000181A73E90-0x0000000181A73EA0
		public P3dHitCache HitCache { get => default; } // 0x000000018B4334D0-0x000000018B4334F0 
	
		// Nested types
		private class Link // TypeDefIndex: 57106
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
			public Link() {} // 0x0000000181A6E380-0x0000000181A6E390
		}
	
		// Constructors
		public P3dPointConnector() {} // 0x000000018B43E7B4-0x000000018B43E840
		static P3dPointConnector() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ClearHitCache() {} // 0x000000018B43DD50-0x000000018B43DE38
		public void ResetConnections() {} // 0x000000018B43DC44-0x000000018B43DD50
		public void BreakHits(object owner) {} // 0x000000018B43DE38-0x000000018B43E07C
		public void SubmitLastPoint(GameObject gameObject, bool preview, object owner) {} // 0x000000018B43E07C-0x000000018B43E5D0
		public void SubmitPoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner) {} // 0x000000018B43E684-0x000000018B43E7B4
		public void Update() {} // 0x000000018B43E5D0-0x000000018B43E684
		private bool TryGetLink(object owner, ref Link link) => default; // 0x000000018B43E840-0x000000018B43E8F4
	}

	public class P3dReadColor : MonoBehaviour, IHitCoord // TypeDefIndex: 57109
	{
		// Fields
		private P3dGroup group; // 0x18
		private bool preview; // 0x1C
		private UnityEngine.Color color; // 0x20
		private ColorEvent onColor; // 0x30
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x0000000181408D10-0x0000000181408D20 0x00000001813AE560-0x00000001813AE570
		public bool Preview { get => default; set {} } // 0x0000000185FB6130-0x0000000185FB6140 0x00000001814088D0-0x00000001814088E0
		public UnityEngine.Color Color { get => default; set {} } // 0x000000018B43EABC-0x000000018B43EB2C 0x0000000185FB6120-0x0000000185FB6130
		public ColorEvent OnColor { get => default; } // 0x000000018B43E8F4-0x000000018B43EABC 
	
		// Nested types
		[Serializable]
		public class ColorEvent : UnityEvent<UnityEngine.Color> // TypeDefIndex: 57108
		{
			// Constructors
			public ColorEvent() {} // 0x00000001813AE9C0-0x00000001813AE9D0
		}
	
		// Constructors
		public P3dReadColor() {} // 0x000000018B429454-0x000000018B429490
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018646DB20-0x000000018646DB28
	}

	[Serializable]
	public class P3dReader // TypeDefIndex: 57110
	{
		// Fields
		private AsyncGPUReadbackRequest request; // 0x10
		private bool dirty; // 0x20
		private bool requested; // 0x21
		private RenderTexture buffer; // 0x28
		private Vector2Int originalSize; // 0x30
		private Vector2Int downsampledSize; // 0x38
		private int downsampleSteps; // 0x40
		private int downsampleBoost; // 0x44
		private Texture2D tempTexture; // 0x48
		private Action<NativeArray<Color32>> OnComplete; // 0x50
	
		// Properties
		public bool Dirty { get => default; } // 0x00000001813ECBF0-0x00000001813ECC00 
		public bool Requested { get => default; } // 0x00000001813ECBD0-0x00000001813ECBE0 
		public Vector2Int OriginalSize { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public int DownsampleSteps { get => default; } // 0x00000001813ECF10-0x00000001813ECF20 
		public Vector2Int DownsampledSize { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public int DownsampleBoost { get => default; } // 0x0000000183908D10-0x0000000183908D20 
	
		// Events
		public event Action<NativeArray<Color32>> OnComplete;
	
		// Constructors
		public P3dReader() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void MarkAsDirty() {} // 0x0000000185FBB160-0x0000000185FBB170
		public void UpdateRequest() {} // 0x000000018B43F18C-0x000000018B43F26C
		public static bool NeedsUpdating<T>(P3dReader reader, NativeArray<T> array, RenderTexture texture, int downsampleSteps)
			where T : struct => default;
		public void Request(RenderTexture texture, int downsample, bool async) {} // 0x000000018B43EEBC-0x000000018B43F18C
		public void Release() {} // 0x000000018B43EE1C-0x000000018B43EEBC
		private void CompleteDirectly() {} // 0x000000018B43EB2C-0x000000018B43EE1C
	}

	public static class P3dSerialization // TypeDefIndex: 57111
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
		static P3dSerialization() {} // 0x000000018B44303C-0x000000018B4433A4
	
		// Methods
		public static void TryRegister(P3dPaintableTexture paintableTexture, P3dHash hash) {} // 0x000000018B442FC0-0x000000018B44303C
		public static void TryRegister(P3dModel model, P3dHash hash) {} // 0x000000018B442C44-0x000000018B442CCC
		public static void TryRegister(Texture texture, P3dHash hash) {} // 0x000000018B442F44-0x000000018B442FC0
		public static void TryRegister<T>(T obj, P3dHash hash, Dictionary<P3dHash, T> hashToObj, Dictionary<T, P3dHash> objToHash)
			where T : UnityEngine.Object {}
		public static int TryRegister(Material material) => default; // 0x000000018B442CCC-0x000000018B442F44
		private static int GetStableStringHash(string s) => default; // 0x000000018B442BF0-0x000000018B442C44
	}

	[Serializable]
	public struct P3dSlot // TypeDefIndex: 57112
	{
		// Fields
		public int Index; // 0x00
		public string Name; // 0x08
	
		// Constructors
		public P3dSlot(int newIndex, string newName) {
			Index = default;
			Name = default;
		} // 0x0000000189317CA8-0x0000000189317CB8
	
		// Methods
		public Texture FindTexture(GameObject gameObject) => default; // 0x000000018B443404-0x000000018B443534
		public bool IsTransformed(GameObject gameObject) => default; // 0x000000018B443560-0x000000018B443710
		public override bool Equals(object obj) => default; // 0x000000018B4433A4-0x000000018B443404
		public override int GetHashCode() => default; // 0x000000018B443534-0x000000018B443560
		public static bool operator ==(P3dSlot a, P3dSlot b) => default; // 0x000000018B443710-0x000000018B44372C
		public static bool operator !=(P3dSlot a, P3dSlot b) => default; // 0x000000018B44372C-0x000000018B443748
	}

	public static class P3dStateManager // TypeDefIndex: 57113
	{
		// Properties
		public static bool CanUndo { get; } // 0x000000018B443D7C-0x000000018B443EC0 
		public static bool CanRedo { get; } // 0x000000018B443C38-0x000000018B443D7C 
	
		// Methods
		public static void StoreAllStates() {} // 0x000000018B4439C0-0x000000018B443AFC
		public static void ClearAllStates() {} // 0x000000018B443748-0x000000018B443884
		public static void UndoAll() {} // 0x000000018B443AFC-0x000000018B443C38
		public static void RedoAll() {} // 0x000000018B443884-0x000000018B4439C0
	}

	public class P3dTextureHash : MonoBehaviour // TypeDefIndex: 57114
	{
		// Fields
		private Texture texture; // 0x18
		private P3dHash hash; // 0x20
	
		// Properties
		public Texture Texture { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public P3dHash Hash { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x000000018B443F64-0x000000018B44406C
	
		// Constructors
		public P3dTextureHash() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018B443F10-0x000000018B443F64
		protected virtual void OnDestroy() {} // 0x000000018B443EC0-0x000000018B443F10
	}

	public class P3dPaintDecal : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 57115
	{
		// Fields
		private LayerMask layers; // 0x18
		private P3dModel targetModel; // 0x20
		private P3dGroup group; // 0x28
		private P3dPaintableTexture targetTexture; // 0x30
		private P3dBlendMode blendMode; // 0x38
		private Texture texture; // 0x70
		private Texture shape; // 0x78
		private P3dChannel shapeChannel; // 0x80
		private UnityEngine.Color color; // 0x84
		private float opacity; // 0x94
		private float angle; // 0x98
		private Vector3 scale; // 0x9C
		private float radius; // 0xA8
		private float hardness; // 0xAC
		private float wrapping; // 0xB0
		private float normalFront; // 0xB4
		private float normalBack; // 0xB8
		private float normalFade; // 0xBC
		private Texture tileTexture; // 0xC0
		private Transform tileTransform; // 0xC8
		private float tileOpacity; // 0xD0
		private float tileTransition; // 0xD4
		private P3dModifierList modifiers; // 0xD8
	
		// Properties
		public LayerMask Layers { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public P3dModel TargetModel { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public P3dGroup Group { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public P3dPaintableTexture TargetTexture { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000185FD2680-0x0000000185FD26B0 0x000000018B440C2C-0x000000018B440C58
		public Texture Texture { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public Texture Shape { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
		public P3dChannel ShapeChannel { get => default; set {} } // 0x000000018140C930-0x000000018140C940 0x000000018140C940-0x000000018140C950
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FD26B0-0x0000000185FD26C0 0x0000000185FD26C0-0x0000000185FD26D0
		public float Opacity { get => default; set {} } // 0x0000000185FBA420-0x0000000185FBA430 0x0000000185FBA6A0-0x0000000185FBA6B0
		public float Angle { get => default; set {} } // 0x0000000181B74C40-0x0000000181B74C50 0x0000000185FB9580-0x0000000185FB9590
		public Vector3 Scale { get => default; set {} } // 0x0000000185FBC690-0x0000000185FBC6B0 0x0000000185FC9D50-0x0000000185FC9D70
		public float Radius { get => default; set {} } // 0x0000000185FB9D40-0x0000000185FB9D50 0x0000000185FCEB60-0x0000000185FCEB70
		public float Hardness { get => default; set {} } // 0x0000000185FB9BB0-0x0000000185FB9BC0 0x0000000185FCEB70-0x0000000185FCEB80
		public float Wrapping { get => default; set {} } // 0x0000000185FB9B10-0x0000000185FB9B20 0x0000000185FBE110-0x0000000185FBE120
		public float NormalFront { get => default; set {} } // 0x0000000185FB9BA0-0x0000000185FB9BB0 0x0000000185FBE100-0x0000000185FBE110
		public float NormalBack { get => default; set {} } // 0x0000000185FBAC60-0x0000000185FBAC70 0x0000000185FB1D90-0x0000000185FB1DA0
		public float NormalFade { get => default; set {} } // 0x0000000185FB9B20-0x0000000185FB9B30 0x0000000185FD26D0-0x0000000185FD26E0
		public Texture TileTexture { get => default; set {} } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		public Transform TileTransform { get => default; set {} } // 0x0000000185FB0300-0x0000000185FB0310 0x0000000187A47C30-0x0000000187A47C44
		public float TileOpacity { get => default; set {} } // 0x0000000185FB8D40-0x0000000185FB8D50 0x0000000185FB8D70-0x0000000185FB8D80
		public float TileTransition { get => default; set {} } // 0x0000000185FB8D30-0x0000000185FB8D40 0x0000000185FB8D60-0x0000000185FB8D70
		public P3dModifierList Modifiers { get => default; } // 0x000000018B440BC4-0x000000018B440C2C 
	
		// Constructors
		public P3dPaintDecal() {} // 0x000000018B440A9C-0x000000018B440BC4
	
		// Methods
		public void FlipHorizontal() {} // 0x0000000185FD2620-0x0000000185FD2640
		public void FlipVertical() {} // 0x0000000185FD2640-0x0000000185FD2660
		public void IncrementOpacity(float delta) {} // 0x000000018B440A28-0x000000018B440A4C
		public void IncrementAngle(float degrees) {} // 0x000000018B4409E8-0x000000018B440A28
		public void MultiplyScale(float multiplier) {} // 0x000000018B440A4C-0x000000018B440A9C
		public void MultiplyHardness(float multiplier) {} // 0x0000000185FD2660-0x0000000185FD2680
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x000000018B440054-0x000000018B4402BC
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x000000018B43FDEC-0x000000018B440054
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018B4405B8-0x000000018B440858
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018B4402BC-0x000000018B4405B8
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018B43FA6C-0x000000018B43FDEC
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation) => default; // 0x000000018B43F5AC-0x000000018B43FA6C
		private void HandleMaskCommon(Vector3 worldPosition) {} // 0x000000018B440858-0x000000018B4409E8
	}

	public class P3dPaintFill : MonoBehaviour, IHitCoord // TypeDefIndex: 57116
	{
		// Fields
		private P3dGroup group; // 0x18
		private P3dBlendMode blendMode; // 0x20
		private Texture texture; // 0x58
		private UnityEngine.Color color; // 0x60
		private float opacity; // 0x70
		private float minimum; // 0x74
		private P3dModifierList modifiers; // 0x78
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000185FBA6D0-0x0000000185FBA700 0x000000018B441098-0x000000018B4410C4
		public Texture Texture { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FCCD00-0x0000000185FCCD10 0x0000000185FCCDA0-0x0000000185FCCDB0
		public float Opacity { get => default; set {} } // 0x0000000185FB89C0-0x0000000185FB89D0 0x0000000185FBD310-0x0000000185FBD320
		public float Minimum { get => default; set {} } // 0x0000000185FB89F0-0x0000000185FB8A00 0x0000000185FBA030-0x0000000185FBA040
		public P3dModifierList Modifiers { get => default; } // 0x000000018B44103C-0x000000018B441098 
	
		// Constructors
		public P3dPaintFill() {} // 0x000000018B440F80-0x000000018B44103C
	
		// Methods
		public void IncrementOpacity(float delta) {} // 0x000000018B440F64-0x000000018B440F80
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018B440C58-0x000000018B440F64
	}

	public class P3dPaintReplace : MonoBehaviour, IHitCoord // TypeDefIndex: 57117
	{
		// Fields
		private P3dGroup group; // 0x18
		private Texture texture; // 0x20
		private UnityEngine.Color color; // 0x28
		private P3dModifierList modifiers; // 0x38
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public Texture Texture { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FBB610-0x0000000185FBB620 0x0000000185FBB620-0x0000000185FBB630
		public P3dModifierList Modifiers { get => default; } // 0x000000018B4415F8-0x000000018B441654 
	
		// Constructors
		public P3dPaintReplace() {} // 0x000000018B4415D0-0x000000018B4415F8
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018B441330-0x000000018B4415D0
	}

	public class P3dPaintReplaceChannels : MonoBehaviour, IHitCoord // TypeDefIndex: 57118
	{
		// Fields
		private P3dGroup group; // 0x18
		private Texture textureR; // 0x20
		private Texture textureG; // 0x28
		private Texture textureB; // 0x30
		private Texture textureA; // 0x38
		private Vector4 channelR; // 0x40
		private Vector4 channelG; // 0x50
		private Vector4 channelB; // 0x60
		private Vector4 channelA; // 0x70
	
		// Properties
		public P3dGroup Group { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public Texture TextureR { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Texture TextureG { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public Texture TextureB { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public Texture TextureA { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public Vector4 ChannelR { get => default; set {} } // 0x0000000185FBBFF0-0x0000000185FBC000 0x0000000185FBEB30-0x0000000185FBEB40
		public Vector4 ChannelG { get => default; set {} } // 0x0000000185FB6BD0-0x0000000185FB6BE0 0x0000000185FBEB30-0x0000000185FBEB40
		public Vector4 ChannelB { get => default; set {} } // 0x0000000185FCCD00-0x0000000185FCCD10 0x0000000185FBEB30-0x0000000185FBEB40
		public Vector4 ChannelA { get => default; set {} } // 0x0000000185FBB870-0x0000000185FBB880 0x0000000185FBEB30-0x0000000185FBEB40
	
		// Constructors
		public P3dPaintReplaceChannels() {} // 0x000000018B441310-0x000000018B441330
	
		// Methods
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018B4410C4-0x000000018B441310
	}

	public class P3dPaintSphere : MonoBehaviour, IHitPoint, IHitLine, IHitTriangle, IHitQuad, IHitCoord // TypeDefIndex: 57119
	{
		// Fields
		private LayerMask layers; // 0x18
		private P3dGroup group; // 0x1C
		private P3dModel targetModel; // 0x20
		private P3dPaintableTexture targetTexture; // 0x28
		private P3dBlendMode blendMode; // 0x30
		private UnityEngine.Color color; // 0x68
		private float opacity; // 0x78
		private float angle; // 0x7C
		private Vector3 scale; // 0x80
		private float radius; // 0x8C
		private float hardness; // 0x90
		private Texture tileTexture; // 0x98
		private Transform tileTransform; // 0xA0
		private float tileOpacity; // 0xA8
		private float tileTransition; // 0xAC
		private P3dModifierList modifiers; // 0xB0
	
		// Properties
		public LayerMask Layers { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public P3dGroup Group { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public P3dModel TargetModel { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public P3dPaintableTexture TargetTexture { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public P3dBlendMode BlendMode { get => default; set {} } // 0x0000000185FD2700-0x0000000185FD2730 0x000000018B442BC4-0x000000018B442BF0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FBECA0-0x0000000185FBECB0 0x0000000185FD2730-0x0000000185FD2740
		public float Opacity { get => default; set {} } // 0x0000000185FB89E0-0x0000000185FB89F0 0x0000000185FBA050-0x0000000185FBA060
		public float Angle { get => default; set {} } // 0x0000000185FB2E90-0x0000000185FB2EA0 0x0000000185FBD3A0-0x0000000185FBD3B0
		public Vector3 Scale { get => default; set {} } // 0x0000000185FBCBC0-0x0000000185FBCBE0 0x0000000185FBCC00-0x0000000185FBCC20
		public float Radius { get => default; set {} } // 0x0000000185FB9D60-0x0000000185FB9D70 0x0000000185FD2740-0x0000000185FD2750
		public float Hardness { get => default; set {} } // 0x0000000185FB9D70-0x0000000185FB9D80 0x0000000185FBB8B0-0x0000000185FBB8C0
		public Texture TileTexture { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public Transform TileTransform { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public float TileOpacity { get => default; set {} } // 0x0000000185FB9D40-0x0000000185FB9D50 0x0000000185FCEB60-0x0000000185FCEB70
		public float TileTransition { get => default; set {} } // 0x0000000185FB9BB0-0x0000000185FB9BC0 0x0000000185FCEB70-0x0000000185FCEB80
		public P3dModifierList Modifiers { get => default; } // 0x000000018B442B5C-0x000000018B442BC4 
	
		// Constructors
		public P3dPaintSphere() {} // 0x000000018B442A58-0x000000018B442B5C
	
		// Methods
		public void IncrementOpacity(float delta) {} // 0x000000018B4429EC-0x000000018B442A08
		public void IncrementAngle(float degrees) {} // 0x000000018B4429B0-0x000000018B4429EC
		public void MultiplyRadius(float multiplier) {} // 0x0000000185FD26E0-0x0000000185FD2700
		public void MultiplyScale(float multiplier) {} // 0x000000018B442A08-0x000000018B442A58
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation) {} // 0x000000018B44201C-0x000000018B442284
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation, bool clip) {} // 0x000000018B441DB4-0x000000018B44201C
		public void HandleHitTriangle(bool preview, int priority, float pressure, int seed, Vector3 positionA, Vector3 positionB, Vector3 positionC, Quaternion rotation) {} // 0x000000018B442580-0x000000018B442820
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation, bool clip) {} // 0x000000018B442284-0x000000018B442580
		public void HandleHitCoord(bool preview, int priority, float pressure, int seed, P3dHit hit, Quaternion rotation) {} // 0x000000018B441A34-0x000000018B441DB4
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation) => default; // 0x000000018B441654-0x000000018B441A34
		private void HandleMaskCommon(Vector3 worldPosition) {} // 0x000000018B442820-0x000000018B4429B0
	}
}
