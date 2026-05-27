/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 30: Unity.RenderPipelines.Core.Runtime.dll - Assembly: Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53285-53695
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.HighDefinition.Runtime")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[ExecuteAlways]
public class SceneRenderPipeline : MonoBehaviour // TypeDefIndex: 53288
{
	// Fields
	public RenderPipelineAsset renderPipelineAsset; // 0x18

	// Constructors
	public SceneRenderPipeline() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void OnEnable() {} // 0x0000000189C98974-0x0000000189C98980
	private void OnValidate() {} // 0x0000000189C98974-0x0000000189C98980
}

namespace Beyond.Rendering
{
	public static class HGShaderQualitySettings // TypeDefIndex: 53290
	{
		// Fields
		public static ShaderQuality HgShaderLod; // 0x00
	
		// Nested types
		public enum ShaderQuality // TypeDefIndex: 53289
		{
			Low = 0,
			High = 1
		}
	
		// Constructors
		static HGShaderQualitySettings() {} // 0x0000000189C82120-0x0000000189C8215C
	}
}

namespace UnityEngine
{
	[AddComponentMenu("Rendering/Light Anchor")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LightAnchor : MonoBehaviour // TypeDefIndex: 53293
	{
		// Fields
		private const float k_ArcRadius = 5f; // Metadata: 0x01FD4497
		private const float k_AxisLength = 10f; // Metadata: 0x01FD449B
		internal const float k_MaxDistance = 10000f; // Metadata: 0x01FD449F
		[Min(0f)]
		[SerializeField]
		private float m_Distance; // 0x18
		[SerializeField]
		private UpDirection m_FrameSpace; // 0x1C
		[SerializeField]
		private Transform m_AnchorPositionOverride; // 0x20
		[SerializeField]
		private Vector3 m_AnchorPositionOffset; // 0x28
		[SerializeField]
		private float m_Yaw; // 0x34
		[SerializeField]
		private float m_Pitch; // 0x38
		[SerializeField]
		private float m_Roll; // 0x3C
	
		// Properties
		public float yaw { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000189C8364C-0x0000000189C8369C
		public float pitch { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000189C835AC-0x0000000189C835FC
		public float roll { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000189C835FC-0x0000000189C8364C
		public float distance { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189C83588-0x0000000189C835AC
		public UpDirection frameSpace { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public Vector3 anchorPosition { get => default; } // 0x0000000189C8340C-0x0000000189C83588 
		public Transform anchorPositionOverride { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Vector3 anchorPositionOffset { get => default; set {} } // 0x0000000183D50E80-0x0000000183D50EA0 0x0000000183D50F50-0x0000000183D50F60
	
		// Nested types
		public enum UpDirection // TypeDefIndex: 53291
		{
			World = 0,
			Local = 1
		}
	
		private struct Axes // TypeDefIndex: 53292
		{
			// Fields
			public Vector3 up; // 0x00
			public Vector3 right; // 0x0C
			public Vector3 forward; // 0x18
		}
	
		// Constructors
		public LightAnchor() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static float NormalizeAngleDegree(float angle) => default; // 0x0000000189C82A24-0x0000000189C82A6C
		public void SynchronizeOnTransform(Camera camera) {} // 0x0000000189C82BB4-0x0000000189C82FB0
		public void UpdateTransform(Camera camera, Vector3 anchor) {} // 0x0000000189C82FB0-0x0000000189C8308C
		private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) => default; // 0x0000000189C822E8-0x0000000189C82A24
		private void Update() {} // 0x0000000189C83310-0x0000000189C8340C
		private void OnDrawGizmosSelected() {} // 0x0000000189C82A6C-0x0000000189C82BB4
		private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) {} // 0x0000000189C8308C-0x0000000189C83310
	}
}
