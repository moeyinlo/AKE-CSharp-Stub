/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 58: Unity.Animation.Rigging.dll - Assembly: Unity.Animation.Rigging, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58798-58933

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58799
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 58800
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Animations.Rigging
{
	public struct CacheIndex // TypeDefIndex: 58801
	{
		// Fields
		internal int idx; // 0x00
	}

	public struct AnimationJobCache : IDisposable // TypeDefIndex: 58802
	{
		// Fields
		private NativeArray<float> m_Data; // 0x00
	
		// Constructors
		internal AnimationJobCache(float[] data) {
			m_Data = default;
		} // 0x000000018BC65B90-0x000000018BC65BF4
	
		// Methods
		public void Dispose() {} // 0x000000018BC65B54-0x000000018BC65B90
		public float GetRaw(CacheIndex index, int offset = 0 /* Metadata: 0x0207FF11 */) => default; // 0x0000000185FD6F80-0x0000000185FD6F90
		public void SetRaw(float val, CacheIndex index, int offset = 0 /* Metadata: 0x0207FF12 */) {} // 0x0000000185FD6F90-0x0000000185FD6FA0
		public T Get<T>(CacheIndex index, int offset = 0 /* Metadata: 0x0207FF13 */)
			where T : struct => default;
		public void Set<T>(T val, CacheIndex index, int offset = 0 /* Metadata: 0x0207FF14 */)
			where T : struct {}
		public void SetArray<T>(T[] v, CacheIndex index, int offset = 0 /* Metadata: 0x0207FF15 */)
			where T : struct {}
	}

	public class AnimationJobCacheBuilder // TypeDefIndex: 58803
	{
		// Fields
		private List<float> m_Data; // 0x10
	
		// Constructors
		public AnimationJobCacheBuilder() {} // 0x000000018BC65ADC-0x000000018BC65B54
	
		// Methods
		public CacheIndex Add(float v) => default; // 0x000000018BC65854-0x000000018BC658C4
		public CacheIndex Add(Vector2 v) => default; // 0x000000018BC658C4-0x000000018BC6594C
		public CacheIndex Add(Vector3 v) => default; // 0x000000018BC656D4-0x000000018BC6577C
		public CacheIndex Add(Vector4 v) => default; // 0x000000018BC65614-0x000000018BC656D4
		public CacheIndex Add(Quaternion v) => default; // 0x000000018BC65834-0x000000018BC65854
		public CacheIndex Add(AffineTransform tx) => default; // 0x000000018BC6577C-0x000000018BC65834
		public CacheIndex AllocateChunk(int size) => default; // 0x000000018BC6594C-0x000000018BC659E4
		public void SetValue(CacheIndex index, int offset, float value) {} // 0x000000018BC65A50-0x000000018BC65ADC
		public AnimationJobCache Build() => default; // 0x000000018BC659E4-0x000000018BC65A50
	}

	public struct BlendConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58804
	{
		// Fields
		private const int k_BlendTranslationMask = 1; // Metadata: 0x0207FF16
		private const int k_BlendRotationMask = 2; // Metadata: 0x0207FF17
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle sourceA; // 0x0C
		public ReadOnlyTransformHandle sourceB; // 0x24
		public AffineTransform sourceAOffset; // 0x3C
		public AffineTransform sourceBOffset; // 0x58
		public BoolProperty blendPosition; // 0x74
		public BoolProperty blendRotation; // 0x84
		public FloatProperty positionWeight; // 0x94
		public FloatProperty rotationWeight; // 0xA4
		private FloatProperty _jobWeight_k__BackingField; // 0xB4
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD6FA0-0x0000000185FD6FB0 0x0000000185FD6FB0-0x0000000185FD6FC0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC67374-0x000000018BC678F8
	}

	public interface IBlendConstraintData // TypeDefIndex: 58805
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObjectA { get; }
		Transform sourceObjectB { get; }
		bool maintainPositionOffsets { get; }
		bool maintainRotationOffsets { get; }
		string blendPositionBoolProperty { get; }
		string blendRotationBoolProperty { get; }
		string positionWeightFloatProperty { get; }
		string rotationWeightFloatProperty { get; }
	}

	public class BlendConstraintJobBinder<T> : AnimationJobBinder<BlendConstraintJob, T> // TypeDefIndex: 58806
		where T : struct, IAnimationJobData, IBlendConstraintData
	{
		// Constructors
		public BlendConstraintJobBinder() {}
	
		// Methods
		public override BlendConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(BlendConstraintJob job) {}
	}

	public struct ChainIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58807
	{
		// Fields
		public NativeArray<ReadWriteTransformHandle> chain; // 0x00
		public ReadOnlyTransformHandle target; // 0x10
		public AffineTransform targetOffset; // 0x28
		public NativeArray<float> linkLengths; // 0x48
		public NativeArray<Vector3> linkPositions; // 0x58
		public FloatProperty chainRotationWeight; // 0x68
		public FloatProperty tipRotationWeight; // 0x78
		public CacheIndex toleranceIdx; // 0x88
		public CacheIndex maxIterationsIdx; // 0x8C
		public AnimationJobCache cache; // 0x90
		public float maxReach; // 0xA0
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD6FC0-0x0000000185FD6FD0 0x0000000185FD6FD0-0x0000000185FD6FE0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC67D60-0x000000018BC68474
	}

	public interface IChainIKConstraintData // TypeDefIndex: 58808
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform target { get; }
		int maxIterations { get; }
		float tolerance { get; }
		bool maintainTargetPositionOffset { get; }
		bool maintainTargetRotationOffset { get; }
		string chainRotationWeightFloatProperty { get; }
		string tipRotationWeightFloatProperty { get; }
	}

	public class ChainIKConstraintJobBinder<T> : AnimationJobBinder<ChainIKConstraintJob, T> // TypeDefIndex: 58809
		where T : struct, IAnimationJobData, IChainIKConstraintData
	{
		// Constructors
		public ChainIKConstraintJobBinder() {}
	
		// Methods
		public override ChainIKConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(ChainIKConstraintJob job) {}
		public override void Update(ChainIKConstraintJob job, ref ref T data) {}
	}

	public struct DampedTransformJob : IWeightedAnimationJob // TypeDefIndex: 58810
	{
		// Fields
		private const float k_FixedDt = 0.01667f; // Metadata: 0x0207FF18
		private const float k_DampFactor = 40f; // Metadata: 0x0207FF1C
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform localBindTx; // 0x24
		public Vector3 aimBindAxis; // 0x40
		public AffineTransform prevDrivenTx; // 0x4C
		public FloatProperty dampPosition; // 0x68
		public FloatProperty dampRotation; // 0x78
		private FloatProperty _jobWeight_k__BackingField; // 0x88
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FBDE50-0x0000000185FBDE60 0x0000000185FD6FE0-0x0000000185FD6FF0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC68BDC-0x000000018BC69384
	}

	public interface IDampedTransformData // TypeDefIndex: 58811
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		bool maintainAim { get; }
		string dampPositionFloatProperty { get; }
		string dampRotationFloatProperty { get; }
	}

	public class DampedTransformJobBinder<T> : AnimationJobBinder<DampedTransformJob, T> // TypeDefIndex: 58812
		where T : struct, IAnimationJobData, IDampedTransformData
	{
		// Constructors
		public DampedTransformJobBinder() {}
	
		// Methods
		public override DampedTransformJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(DampedTransformJob job) {}
	}

	public interface IAnimatableProperty<T> // TypeDefIndex: 58813
	{
		// Methods
		T Get(AnimationStream stream);
		void Set(AnimationStream stream, T value);
	}

	public struct BoolProperty : IAnimatableProperty<bool> // TypeDefIndex: 58814
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static BoolProperty Bind(Animator animator, Component component, string name) => default; // 0x000000018BC67A14-0x000000018BC67AA4
		public static BoolProperty BindCustom(Animator animator, string property) => default; // 0x000000018BC679DC-0x000000018BC67A14
		public bool Get(AnimationStream stream) => default; // 0x000000018BC67AA4-0x000000018BC67AE0
		public void Set(AnimationStream stream, bool v) {} // 0x000000018BC67AE0-0x000000018BC67B1C
	}

	public struct IntProperty : IAnimatableProperty<int> // TypeDefIndex: 58815
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static IntProperty Bind(Animator animator, Component component, string name) => default; // 0x000000018BC67A14-0x000000018BC67AA4
		public static IntProperty BindCustom(Animator animator, string property) => default; // 0x000000018BC696D4-0x000000018BC6970C
		public int Get(AnimationStream stream) => default; // 0x000000018BC6970C-0x000000018BC69748
		public void Set(AnimationStream stream, int v) {} // 0x000000018BC69748-0x000000018BC69784
	}

	public struct FloatProperty : IAnimatableProperty<float> // TypeDefIndex: 58816
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static FloatProperty Bind(Animator animator, Component component, string name) => default; // 0x000000018BC67A14-0x000000018BC67AA4
		public static FloatProperty BindCustom(Animator animator, string property) => default; // 0x000000018BC69624-0x000000018BC6965C
		public float Get(AnimationStream stream) => default; // 0x000000018BC6965C-0x000000018BC69698
		public void Set(AnimationStream stream, float v) {} // 0x000000018BC69698-0x000000018BC696D4
	}

	public struct Vector2Property : IAnimatableProperty<Vector2> // TypeDefIndex: 58817
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
	
		// Methods
		public static Vector2Property Bind(Animator animator, Component component, string name) => default; // 0x000000018BC760D8-0x000000018BC761F8
		public static Vector2Property BindCustom(Animator animator, string name) => default; // 0x000000018BC76010-0x000000018BC760D8
		public Vector2 Get(AnimationStream stream) => default; // 0x000000018BC761F8-0x000000018BC762A0
		public void Set(AnimationStream stream, Vector2 value) {} // 0x000000018BC762A0-0x000000018BC7634C
	}

	public struct Vector3Property : IAnimatableProperty<Vector3> // TypeDefIndex: 58818
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3Property Bind(Animator animator, Component component, string name) => default; // 0x000000018BC76CFC-0x000000018BC76E74
		public static Vector3Property BindCustom(Animator animator, string name) => default; // 0x000000018BC76BEC-0x000000018BC76CFC
		public Vector3 Get(AnimationStream stream) => default; // 0x000000018BC76E74-0x000000018BC76F74
		public void Set(AnimationStream stream, Vector3 value) {} // 0x000000018BC76F74-0x000000018BC77050
	}

	public struct Vector3IntProperty : IAnimatableProperty<Vector3Int> // TypeDefIndex: 58819
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3IntProperty Bind(Animator animator, Component component, string name) => default; // 0x000000018BC768AC-0x000000018BC76A24
		public static Vector3IntProperty BindCustom(Animator animator, string name) => default; // 0x000000018BC7679C-0x000000018BC768AC
		public Vector3Int Get(AnimationStream stream) => default; // 0x000000018BC76A24-0x000000018BC76B14
		public void Set(AnimationStream stream, Vector3Int value) {} // 0x000000018BC76B14-0x000000018BC76BEC
	}

	public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool> // TypeDefIndex: 58820
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3BoolProperty Bind(Animator animator, Component component, string name) => default; // 0x000000018BC7645C-0x000000018BC765D4
		public static Vector3BoolProperty BindCustom(Animator animator, string name) => default; // 0x000000018BC7634C-0x000000018BC7645C
		public Vector3Bool Get(AnimationStream stream) => default; // 0x000000018BC765D4-0x000000018BC766C4
		public void Set(AnimationStream stream, Vector3Bool value) {} // 0x000000018BC766C4-0x000000018BC7679C
	}

	public struct Vector4Property : IAnimatableProperty<Vector4> // TypeDefIndex: 58821
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
		public PropertyStreamHandle w; // 0x30
	
		// Methods
		public static Vector4Property Bind(Animator animator, Component component, string name) => default; // 0x000000018BC771A0-0x000000018BC7736C
		public static Vector4Property BindCustom(Animator animator, string name) => default; // 0x000000018BC77050-0x000000018BC771A0
		public Vector4 Get(AnimationStream stream) => default; // 0x000000018BC7736C-0x000000018BC774B8
		public void Set(AnimationStream stream, Vector4 value) {} // 0x000000018BC774B8-0x000000018BC775D4
	}

	public interface IAnimationJobBinder // TypeDefIndex: 58822
	{
		// Methods
		IAnimationJob Create(Animator animator, IAnimationJobData data, Component component = null);
		void Destroy(IAnimationJob job);
		void Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public abstract class AnimationJobBinder<TJob, TData> : IAnimationJobBinder // TypeDefIndex: 58823
		where TJob : struct, IAnimationJob
		where TData : struct, IAnimationJobData
	{
		// Constructors
		protected AnimationJobBinder() {}
	
		// Methods
		public abstract TJob Create(Animator animator, ref ref TData data, Component component);
		public abstract void Destroy(TJob job);
		public virtual void Update(TJob job, ref ref TData data) {}
		IAnimationJob IAnimationJobBinder.Create(Animator animator, IAnimationJobData data, Component component) => default;
		void IAnimationJobBinder.Destroy(IAnimationJob job) {}
		void IAnimationJobBinder.Update(IAnimationJob job, IAnimationJobData data) {}
		AnimationScriptPlayable IAnimationJobBinder.CreatePlayable(PlayableGraph graph, IAnimationJob job) => default;
	}

	public interface IAnimationJobData // TypeDefIndex: 58824
	{
		// Methods
		bool IsValid();
		void SetDefaultValues();
	}

	public interface IWeightedAnimationJob : IAnimationJob // TypeDefIndex: 58825
	{
		// Properties
		FloatProperty jobWeight { get; set; }
	}

	public struct MultiAimConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58827
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0207FF20
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 aimAxis; // 0x98
		public Vector3 upAxis; // 0xA4
		public WorldUpType worldUpType; // 0xB0
		public Vector3 worldUpAxis; // 0xB4
		public ReadOnlyTransformHandle worldUpObject; // 0xC0
		public Vector3 axesMask; // 0xD8
		public FloatProperty minLimit; // 0xE4
		public FloatProperty maxLimit; // 0xF4
		private FloatProperty _jobWeight_k__BackingField; // 0x104
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD70C0-0x0000000185FD70D0 0x0000000185FD70D0-0x0000000185FD70E0
	
		// Nested types
		public enum WorldUpType // TypeDefIndex: 58826
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC69EF8-0x000000018BC6AE48
		private Vector3 ComputeWorldUpVector(AnimationStream stream) => default; // 0x000000018BC69C78-0x000000018BC69EF8
	}

	public interface IMultiAimConstraintData // TypeDefIndex: 58828
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		Vector3 aimAxis { get; }
		Vector3 upAxis { get; }
		int worldUpType { get; }
		Vector3 worldUpAxis { get; }
		Transform worldUpObject { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
		string offsetVector3Property { get; }
		string minLimitFloatProperty { get; }
		string maxLimitFloatProperty { get; }
		string sourceObjectsProperty { get; }
	}

	public class MultiAimConstraintJobBinder<T> : AnimationJobBinder<MultiAimConstraintJob, T> // TypeDefIndex: 58829
		where T : struct, IAnimationJobData, IMultiAimConstraintData
	{
		// Constructors
		public MultiAimConstraintJobBinder() {}
	
		// Methods
		public override MultiAimConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiAimConstraintJob job) {}
	}

	public struct MultiParentConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58830
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0207FF29
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x28
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x38
		public NativeArray<AffineTransform> sourceOffsets; // 0x48
		public NativeArray<float> weightBuffer; // 0x58
		public Vector3 positionAxesMask; // 0x68
		public Vector3 rotationAxesMask; // 0x74
		private FloatProperty _jobWeight_k__BackingField; // 0x80
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FBC0B0-0x0000000185FBC0C0 0x0000000185FC9CB0-0x0000000185FC9CC0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6B27C-0x000000018BC6BD48
	}

	public interface IMultiParentConstraintData // TypeDefIndex: 58831
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainPositionOffset { get; }
		bool maintainRotationOffset { get; }
		bool constrainedPositionXAxis { get; }
		bool constrainedPositionYAxis { get; }
		bool constrainedPositionZAxis { get; }
		bool constrainedRotationXAxis { get; }
		bool constrainedRotationYAxis { get; }
		bool constrainedRotationZAxis { get; }
		string sourceObjectsProperty { get; }
	}

	public class MultiParentConstraintJobBinder<T> : AnimationJobBinder<MultiParentConstraintJob, T> // TypeDefIndex: 58832
		where T : struct, IAnimationJobData, IMultiParentConstraintData
	{
		// Constructors
		public MultiParentConstraintJobBinder() {}
	
		// Methods
		public override MultiParentConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiParentConstraintJob job) {}
	}

	public struct MultiPositionConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58833
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0207FF2D
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Vector3> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD6FC0-0x0000000185FD6FD0 0x0000000185FD6FD0-0x0000000185FD6FE0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6C14C-0x000000018BC6C848
	}

	public interface IMultiPositionConstraintData // TypeDefIndex: 58834
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		string offsetVector3Property { get; }
		string sourceObjectsProperty { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
	}

	public class MultiPositionConstraintJobBinder<T> : AnimationJobBinder<MultiPositionConstraintJob, T> // TypeDefIndex: 58835
		where T : struct, IAnimationJobData, IMultiPositionConstraintData
	{
		// Constructors
		public MultiPositionConstraintJobBinder() {}
	
		// Methods
		public override MultiPositionConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiPositionConstraintJob job) {}
	}

	public struct MultiReferentialConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58836
	{
		// Fields
		public IntProperty driver; // 0x00
		public NativeArray<ReadWriteTransformHandle> sources; // 0x10
		public NativeArray<AffineTransform> sourceBindTx; // 0x20
		public NativeArray<AffineTransform> offsetTx; // 0x30
		private int m_PrevDriverIdx; // 0x40
		private FloatProperty _jobWeight_k__BackingField; // 0x44
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD6DB0-0x0000000185FD6DC0 0x0000000185FD6DC0-0x0000000185FD6DD0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6CDD0-0x000000018BC6D288
		internal void UpdateOffsets(int driver) {} // 0x000000018BC6D288-0x000000018BC6D420
	}

	public interface IMultiReferentialConstraintData // TypeDefIndex: 58837
	{
		// Properties
		int driverValue { get; }
		string driverIntProperty { get; }
		Transform[] sourceObjects { get; }
	}

	public class MultiReferentialConstraintJobBinder<T> : AnimationJobBinder<MultiReferentialConstraintJob, T> // TypeDefIndex: 58838
		where T : struct, IAnimationJobData, IMultiReferentialConstraintData
	{
		// Constructors
		public MultiReferentialConstraintJobBinder() {}
	
		// Methods
		public override MultiReferentialConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiReferentialConstraintJob job) {}
	}

	public struct MultiRotationConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58839
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x0207FF31
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD6FC0-0x0000000185FD6FD0 0x0000000185FD6FD0-0x0000000185FD6FE0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6D72C-0x000000018BC6DE1C
	}

	public interface IMultiRotationConstraintData // TypeDefIndex: 58840
	{
		// Properties
		Transform constrainedObject { get; }
		WeightedTransformArray sourceObjects { get; }
		bool maintainOffset { get; }
		string offsetVector3Property { get; }
		string sourceObjectsProperty { get; }
		bool constrainedXAxis { get; }
		bool constrainedYAxis { get; }
		bool constrainedZAxis { get; }
	}

	public class MultiRotationConstraintJobBinder<T> : AnimationJobBinder<MultiRotationConstraintJob, T> // TypeDefIndex: 58841
		where T : struct, IAnimationJobData, IMultiRotationConstraintData
	{
		// Constructors
		public MultiRotationConstraintJobBinder() {}
	
		// Methods
		public override MultiRotationConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiRotationConstraintJob job) {}
	}

	public struct OverrideTransformJob : IWeightedAnimationJob // TypeDefIndex: 58843
	{
		// Fields
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform sourceInvLocalBindTx; // 0x24
		public Quaternion sourceToWorldRot; // 0x40
		public Quaternion sourceToLocalRot; // 0x50
		public Quaternion sourceToPivotRot; // 0x60
		public CacheIndex spaceIdx; // 0x70
		public CacheIndex sourceToCurrSpaceRotIdx; // 0x74
		public Vector3Property position; // 0x78
		public Vector3Property rotation; // 0xA8
		public FloatProperty positionWeight; // 0xD8
		public FloatProperty rotationWeight; // 0xE8
		public AnimationJobCache cache; // 0xF8
		private FloatProperty _jobWeight_k__BackingField; // 0x108
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FD60A0-0x0000000185FD60B0 0x0000000185FD6100-0x0000000185FD6110
	
		// Nested types
		public enum Space // TypeDefIndex: 58842
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6E4E8-0x000000018BC6ED44
		internal void UpdateSpace(int space) {} // 0x000000018BC6ED44-0x000000018BC6EDE4
	}

	public interface IOverrideTransformData // TypeDefIndex: 58844
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		int space { get; }
		string positionWeightFloatProperty { get; }
		string rotationWeightFloatProperty { get; }
		string positionVector3Property { get; }
		string rotationVector3Property { get; }
	}

	public class OverrideTransformJobBinder<T> : AnimationJobBinder<OverrideTransformJob, T> // TypeDefIndex: 58845
		where T : struct, IAnimationJobData, IOverrideTransformData
	{
		// Constructors
		public OverrideTransformJobBinder() {}
	
		// Methods
		public override OverrideTransformJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(OverrideTransformJob job) {}
		public override void Update(OverrideTransformJob job, ref ref T data) {}
	}

	internal struct RigSyncSceneToStreamJob : IAnimationJob // TypeDefIndex: 58848
	{
		// Fields
		public TransformSyncer transformSyncer; // 0x00
		public PropertySyncer propertySyncer; // 0x20
		public PropertySyncer rigWeightSyncer; // 0x50
		public PropertySyncer constraintWeightSyncer; // 0x80
		public NativeArray<float> rigStates; // 0xB0
		public NativeArray<int> rigConstraintEndIdx; // 0xC0
		public NativeArray<PropertyStreamHandle> modulatedConstraintWeights; // 0xD0
	
		// Nested types
		public struct TransformSyncer : IDisposable // TypeDefIndex: 58846
		{
			// Fields
			public NativeArray<TransformSceneHandle> sceneHandles; // 0x00
			public NativeArray<TransformStreamHandle> streamHandles; // 0x10
	
			// Methods
			public static TransformSyncer Create(int size) => default; // 0x0000000185492010-0x0000000185492020
			public void Dispose() {} // 0x000000018BC71DB4-0x000000018BC71F00
			public void BindAt(int index, Animator animator, Transform transform) {} // 0x000000018BC74808-0x000000018BC748B8
			public void Sync(ref AnimationStream stream) {} // 0x000000018BC748B8-0x000000018BC74934
		}
	
		internal struct PropertySyncer : IDisposable // TypeDefIndex: 58847
		{
			// Fields
			public NativeArray<PropertySceneHandle> sceneHandles; // 0x00
			public NativeArray<PropertyStreamHandle> streamHandles; // 0x10
			public NativeArray<float> buffer; // 0x20
	
			// Methods
			public static PropertySyncer Create(int size) => default; // 0x000000018BC7478C-0x000000018BC74808
			public void Dispose() {} // 0x000000018BC74934-0x000000018BC74B00
			public void BindAt(int index, Animator animator, Component component, string property) {} // 0x000000018BC6EF80-0x000000018BC6F070
			public void Sync(ref AnimationStream stream) {} // 0x000000018BC6F070-0x000000018BC6F11C
			public NativeArray<float> StreamValues(ref AnimationStream stream) => default; // 0x000000018BC6EEB4-0x000000018BC6EF80
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018BC6F198-0x000000018BC6F260
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC6F11C-0x000000018BC6F198
	}

	internal struct SyncableProperties // TypeDefIndex: 58849
	{
		// Fields
		public RigProperties rig; // 0x00
		public ConstraintProperties[] constraints; // 0x08
	}

	internal interface IRigSyncSceneToStreamData // TypeDefIndex: 58850
	{
		// Properties
		Transform[] syncableTransforms { get; }
		SyncableProperties[] syncableProperties { get; }
		bool[] rigStates { get; }
	}

	internal class RigSyncSceneToStreamJobBinder<T> : AnimationJobBinder<RigSyncSceneToStreamJob, T> // TypeDefIndex: 58851
		where T : struct, IAnimationJobData, IRigSyncSceneToStreamData
	{
		// Fields
		internal static string[] s_PropertyElementNames;
	
		// Constructors
		public RigSyncSceneToStreamJobBinder() {}
		static RigSyncSceneToStreamJobBinder() {}
	
		// Methods
		public override RigSyncSceneToStreamJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(RigSyncSceneToStreamJob job) {}
		public override void Update(RigSyncSceneToStreamJob job, ref ref T data) {}
	}

	public struct ReadWriteTransformHandle // TypeDefIndex: 58852
	{
		// Fields
		private TransformStreamHandle m_Handle; // 0x00
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x000000018BC6FC80-0x000000018BC6FCD8
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x000000018BC6FCD8-0x000000018BC6FD28
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x000000018BC6FD28-0x000000018BC6FD80
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BC6FD80-0x000000018BC6FDD0
		public void SetLocalPosition(AnimationStream stream, Vector3 position) {} // 0x000000018BC6FFA4-0x000000018BC6FFF8
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation) {} // 0x000000018BC6FFF8-0x000000018BC70040
		public void SetLocalScale(AnimationStream stream, Vector3 scale) {} // 0x000000018BC70040-0x000000018BC70094
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false /* Metadata: 0x0207FF38 */) {} // 0x000000018BC70094-0x000000018BC70120
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x000000018BC6FDD0-0x000000018BC6FE28
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x000000018BC6FE28-0x000000018BC6FE78
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BC6FC3C-0x000000018BC6FC80
		public void SetPosition(AnimationStream stream, Vector3 position) {} // 0x000000018BC70120-0x000000018BC70174
		public void SetRotation(AnimationStream stream, Quaternion rotation) {} // 0x000000018BC70174-0x000000018BC701BC
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false /* Metadata: 0x0207FF39 */) {} // 0x000000018BC6FF2C-0x000000018BC6FFA4
		public bool IsResolved(AnimationStream stream) => default; // 0x000000018BC6FE78-0x000000018BC6FEB4
		public bool IsValid(AnimationStream stream) => default; // 0x000000018BC6FEB4-0x000000018BC6FEF0
		public void Resolve(AnimationStream stream) {} // 0x000000018BC6FEF0-0x000000018BC6FF2C
		public static ReadWriteTransformHandle Bind(Animator animator, Transform transform) => default; // 0x000000018BC6FAA8-0x000000018BC6FC3C
	}

	public struct ReadOnlyTransformHandle // TypeDefIndex: 58853
	{
		// Fields
		private TransformStreamHandle m_StreamHandle; // 0x00
		private TransformSceneHandle m_SceneHandle; // 0x0C
		private byte m_InStream; // 0x14
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x000000018BC6F730-0x000000018BC6F7A8
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x000000018BC6F7A8-0x000000018BC6F818
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x000000018BC6F818-0x000000018BC6F890
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x000000018BC6F890-0x000000018BC6F8EC
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x000000018BC6F8EC-0x000000018BC6F964
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x000000018BC6F964-0x000000018BC6F9D4
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BC6F6E4-0x000000018BC6F730
		public bool IsResolved(AnimationStream stream) => default; // 0x000000018BC6F9D4-0x000000018BC6FA18
		public bool IsValid(AnimationStream stream) => default; // 0x000000018BC6FA18-0x000000018BC6FA64
		public void Resolve(AnimationStream stream) {} // 0x000000018BC6FA64-0x000000018BC6FAA8
		public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform) => default; // 0x000000018BC6F598-0x000000018BC6F6E4
	}

	public struct TwistChainConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58854
	{
		// Fields
		public ReadWriteTransformHandle rootTarget; // 0x00
		public ReadWriteTransformHandle tipTarget; // 0x0C
		public NativeArray<ReadWriteTransformHandle> chain; // 0x18
		public NativeArray<float> steps; // 0x28
		public NativeArray<float> weights; // 0x38
		public NativeArray<Quaternion> rotations; // 0x48
		private FloatProperty _jobWeight_k__BackingField; // 0x58
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FB1D60-0x0000000185FB1D70 0x0000000185FD25E0-0x0000000185FD25F0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC74C54-0x000000018BC7514C
	}

	public interface ITwistChainConstraintData // TypeDefIndex: 58855
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform rootTarget { get; }
		Transform tipTarget { get; }
		AnimationCurve curve { get; }
	}

	public class TwistChainConstraintJobBinder<T> : AnimationJobBinder<TwistChainConstraintJob, T> // TypeDefIndex: 58856
		where T : struct, IAnimationJobData, ITwistChainConstraintData
	{
		// Constructors
		public TwistChainConstraintJobBinder() {}
	
		// Methods
		public override TwistChainConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwistChainConstraintJob job) {}
	}

	public struct TwistCorrectionJob : IWeightedAnimationJob // TypeDefIndex: 58857
	{
		// Fields
		public ReadOnlyTransformHandle source; // 0x00
		public Quaternion sourceInverseBindRotation; // 0x18
		public Vector3 axisMask; // 0x28
		public NativeArray<ReadWriteTransformHandle> twistTransforms; // 0x38
		public NativeArray<PropertyStreamHandle> twistWeights; // 0x48
		public NativeArray<Quaternion> twistBindRotations; // 0x58
		public NativeArray<float> weightBuffer; // 0x68
		private FloatProperty _jobWeight_k__BackingField; // 0x78
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FB9E60-0x0000000185FB9E70 0x0000000185FCD380-0x0000000185FCD390
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC753A0-0x000000018BC7575C
		private static Quaternion TwistRotation(Vector3 axis, Quaternion rot) => default; // 0x0000000185FD7110-0x0000000185FD7150
	}

	public interface ITwistCorrectionData // TypeDefIndex: 58858
	{
		// Properties
		Transform source { get; }
		WeightedTransformArray twistNodes { get; }
		Vector3 twistAxis { get; }
		string twistNodesProperty { get; }
	}

	public class TwistCorrectionJobBinder<T> : AnimationJobBinder<TwistCorrectionJob, T> // TypeDefIndex: 58859
		where T : struct, IAnimationJobData, ITwistCorrectionData
	{
		// Constructors
		public TwistCorrectionJobBinder() {}
	
		// Methods
		public override TwistCorrectionJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwistCorrectionJob job) {}
	}

	public struct TwoBoneIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 58860
	{
		// Fields
		public ReadWriteTransformHandle root; // 0x00
		public ReadWriteTransformHandle mid; // 0x0C
		public ReadWriteTransformHandle tip; // 0x18
		public ReadOnlyTransformHandle hint; // 0x24
		public ReadOnlyTransformHandle target; // 0x3C
		public AffineTransform targetOffset; // 0x54
		public FloatProperty targetPositionWeight; // 0x70
		public FloatProperty targetRotationWeight; // 0x80
		public FloatProperty hintWeight; // 0x90
		private FloatProperty _jobWeight_k__BackingField; // 0xA0
	
		// Properties
		public FloatProperty jobWeight { get; set; } // 0x0000000185FCCCE0-0x0000000185FCCCF0 0x0000000185FCCD70-0x0000000185FCCD80
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018BC75B00-0x000000018BC75EA0
	}

	public interface ITwoBoneIKConstraintData // TypeDefIndex: 58861
	{
		// Properties
		Transform root { get; }
		Transform mid { get; }
		Transform tip { get; }
		Transform target { get; }
		Transform hint { get; }
		bool maintainTargetPositionOffset { get; }
		bool maintainTargetRotationOffset { get; }
		string targetPositionWeightFloatProperty { get; }
		string targetRotationWeightFloatProperty { get; }
		string hintWeightFloatProperty { get; }
	}

	public class TwoBoneIKConstraintJobBinder<T> : AnimationJobBinder<TwoBoneIKConstraintJob, T> // TypeDefIndex: 58862
		where T : struct, IAnimationJobData, ITwoBoneIKConstraintData
	{
		// Constructors
		public TwoBoneIKConstraintJobBinder() {}
	
		// Methods
		public override TwoBoneIKConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwoBoneIKConstraintJob job) {}
	}

	public class WeightedTransformArrayBinder // TypeDefIndex: 58863
	{
		// Constructors
		public WeightedTransformArrayBinder() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle> transforms) {
			transforms = default;
		} // 0x000000018BC775D4-0x000000018BC776E8
		public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle> transforms) {
			transforms = default;
		} // 0x000000018BC776E8-0x000000018BC777F8
		public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle> weights) {
			weights = default;
		} // 0x000000018BC777F8-0x000000018BC77988
	}

	[Serializable]
	public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData // TypeDefIndex: 58864
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private Transform m_SourceA; // 0x08
		private Transform m_SourceB; // 0x10
		private bool m_BlendPosition; // 0x18
		private bool m_BlendRotation; // 0x19
		private float m_PositionWeight; // 0x1C
		private float m_RotationWeight; // 0x20
		private bool m_MaintainPositionOffsets; // 0x24
		private bool m_MaintainRotationOffsets; // 0x25
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform sourceObjectA { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Transform sourceObjectB { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool blendPosition { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public bool blendRotation { get => default; set {} } // 0x0000000181A73E90-0x0000000181A73EA0 0x0000000181A73EB0-0x0000000181A73EC0
		public float positionWeight { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000186470D94-0x0000000186470DAC
		public float rotationWeight { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018AAE677C-0x000000018AAE6794
		public bool maintainPositionOffsets { get => default; set {} } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
		public bool maintainRotationOffsets { get => default; set {} } // 0x0000000185FB0860-0x0000000185FB0870 0x0000000185FB0880-0x0000000185FB0890
		string IBlendConstraintData.blendPositionBoolProperty { get => default; } // 0x000000018BC672A4-0x000000018BC672D8 
		string IBlendConstraintData.blendRotationBoolProperty { get => default; } // 0x000000018BC672D8-0x000000018BC6730C 
		string IBlendConstraintData.positionWeightFloatProperty { get => default; } // 0x000000018BC6730C-0x000000018BC67340 
		string IBlendConstraintData.rotationWeightFloatProperty { get => default; } // 0x000000018BC67340-0x000000018BC67374 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC671C0-0x000000018BC67258
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC67258-0x000000018BC672A4
	}

	public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder<BlendConstraintData>> // TypeDefIndex: 58865
	{
		// Constructors
		public BlendConstraint() {} // 0x000000018BC6795C-0x000000018BC679B0
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC678F8-0x000000018BC6795C
	}

	[Serializable]
	public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData // TypeDefIndex: 58866
	{
		// Fields
		internal const int k_MinIterations = 1; // Metadata: 0x0207FF3A
		internal const int k_MaxIterations = 50; // Metadata: 0x0207FF3B
		internal const float k_MinTolerance = 0f; // Metadata: 0x0207FF3C
		internal const float k_MaxTolerance = 0.01f; // Metadata: 0x0207FF40
		private Transform m_Root; // 0x00
		private Transform m_Tip; // 0x08
		private Transform m_Target; // 0x10
		private float m_ChainRotationWeight; // 0x18
		private float m_TipRotationWeight; // 0x1C
		private int m_MaxIterations; // 0x20
		private float m_Tolerance; // 0x24
		private bool m_MaintainTargetPositionOffset; // 0x28
		private bool m_MaintainTargetRotationOffset; // 0x29
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform tip { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Transform target { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public float chainRotationWeight { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000189CBA374-0x0000000189CBA38C
		public float tipRotationWeight { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000186470D94-0x0000000186470DAC
		public int maxIterations { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x000000018BC67D1C-0x000000018BC67D3C
		public float tolerance { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x000000018BC67D3C-0x000000018BC67D60
		public bool maintainTargetPositionOffset { get => default; set {} } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public bool maintainTargetRotationOffset { get => default; set {} } // 0x00000001813B34D0-0x00000001813B34E0 0x00000001813B4850-0x00000001813B4860
		string IChainIKConstraintData.chainRotationWeightFloatProperty { get => default; } // 0x000000018BC67CB4-0x000000018BC67CE8 
		string IChainIKConstraintData.tipRotationWeightFloatProperty { get => default; } // 0x000000018BC67CE8-0x000000018BC67D1C 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC67B1C-0x000000018BC67C60
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC67C60-0x000000018BC67CB4
	}

	public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder<ChainIKConstraintData>> // TypeDefIndex: 58867
	{
		// Constructors
		public ChainIKConstraint() {} // 0x000000018BC68528-0x000000018BC6857C
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC68474-0x000000018BC68528
	}

	[Serializable]
	public struct DampedTransformData : IAnimationJobData, IDampedTransformData // TypeDefIndex: 58868
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private Transform m_Source; // 0x08
		private float m_DampPosition; // 0x10
		private float m_DampRotation; // 0x14
		private bool m_MaintainAim; // 0x18
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform sourceObject { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public float dampPosition { get => default; set {} } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x000000018BC68BAC-0x000000018BC68BC4
		public float dampRotation { get => default; set {} } // 0x0000000185FB2D80-0x0000000185FB2D90 0x000000018BC68BC4-0x000000018BC68BDC
		public bool maintainAim { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		string IDampedTransformData.dampPositionFloatProperty { get => default; } // 0x000000018BC68B44-0x000000018BC68B78 
		string IDampedTransformData.dampRotationFloatProperty { get => default; } // 0x000000018BC68B78-0x000000018BC68BAC 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC68A90-0x000000018BC68B08
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC68B08-0x000000018BC68B44
	}

	public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder<DampedTransformData>> // TypeDefIndex: 58869
	{
		// Constructors
		public DampedTransform() {} // 0x000000018BC693E8-0x000000018BC6943C
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC69384-0x000000018BC693E8
	}

	[Serializable]
	public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData // TypeDefIndex: 58872
	{
		// Fields
		internal const float k_MinAngularLimit = -180f; // Metadata: 0x0207FF44
		internal const float k_MaxAngularLimit = 180f; // Metadata: 0x0207FF48
		private Transform m_ConstrainedObject; // 0x00
		private WeightedTransformArray m_SourceObjects; // 0x08
		private Vector3 m_Offset; // 0x90
		private float m_MinLimit; // 0x9C
		private float m_MaxLimit; // 0xA0
		private Axis m_AimAxis; // 0xA4
		private Axis m_UpAxis; // 0xA8
		private WorldUpType m_WorldUpType; // 0xAC
		private Transform m_WorldUpObject; // 0xB0
		private Axis m_WorldUpAxis; // 0xB8
		private bool m_MaintainOffset; // 0xBC
		private Vector3Bool m_ConstrainedAxes; // 0xBD
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000185FD7030-0x0000000185FD7090 0x000000018BC69C14-0x000000018BC69C78
		public bool maintainOffset { get => default; set {} } // 0x0000000185FD6F30-0x0000000185FD6F40 0x0000000185FD6F40-0x0000000185FD6F50
		public Vector3 offset { get => default; set {} } // 0x0000000185FBCED0-0x0000000185FBCEF0 0x0000000185FBF7F0-0x0000000185FBF810
		public Vector2 limits { get => default; set {} } // 0x0000000185FD4540-0x0000000185FD4560 0x000000018BC69BB4-0x000000018BC69C14
		public Axis aimAxis { get => default; set {} } // 0x0000000185FB2CE0-0x0000000185FB2CF0 0x0000000185FB2D20-0x0000000185FB2D30
		public Axis upAxis { get => default; set {} } // 0x0000000185FB2CD0-0x0000000185FB2CE0 0x0000000185FB2D10-0x0000000185FB2D20
		public WorldUpType worldUpType { get => default; set {} } // 0x0000000185FB2CF0-0x0000000185FB2D00 0x0000000185FB2D30-0x0000000185FB2D40
		public Axis worldUpAxis { get => default; set {} } // 0x0000000185FB9570-0x0000000185FB9580 0x0000000185FB9590-0x0000000185FB95A0
		public Transform worldUpObject { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x0000000184784C70-0x0000000184784C90
		public bool constrainedXAxis { get => default; set {} } // 0x0000000185FD7000-0x0000000185FD7010 0x0000000185FD7090-0x0000000185FD70A0
		public bool constrainedYAxis { get => default; set {} } // 0x0000000185FD7010-0x0000000185FD7020 0x0000000185FD70A0-0x0000000185FD70B0
		public bool constrainedZAxis { get => default; set {} } // 0x0000000185FD7020-0x0000000185FD7030 0x0000000185FD70B0-0x0000000185FD70C0
		Vector3 IMultiAimConstraintData.aimAxis { get => default; } // 0x000000018BC69A48-0x000000018BC69A7C 
		Vector3 IMultiAimConstraintData.upAxis { get => default; } // 0x000000018BC69B4C-0x000000018BC69B80 
		int IMultiAimConstraintData.worldUpType { get => default; } // 0x0000000185FB2CF0-0x0000000185FB2D00 
		Vector3 IMultiAimConstraintData.worldUpAxis { get => default; } // 0x000000018BC69B80-0x000000018BC69BB4 
		string IMultiAimConstraintData.offsetVector3Property { get => default; } // 0x000000018BC69AE4-0x000000018BC69B18 
		string IMultiAimConstraintData.minLimitFloatProperty { get => default; } // 0x000000018BC69AB0-0x000000018BC69AE4 
		string IMultiAimConstraintData.maxLimitFloatProperty { get => default; } // 0x000000018BC69A7C-0x000000018BC69AB0 
		string IMultiAimConstraintData.sourceObjectsProperty { get => default; } // 0x000000018BC69B18-0x000000018BC69B4C 
	
		// Nested types
		public enum Axis // TypeDefIndex: 58870
		{
			X = 0,
			X_NEG = 1,
			Y = 2,
			Y_NEG = 3,
			Z = 4,
			Z_NEG = 5
		}
	
		public enum WorldUpType // TypeDefIndex: 58871
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC697F0-0x000000018BC69974
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC69974-0x000000018BC69A48
		private static Vector3 Convert(Axis axis) => default; // 0x000000018BC69784-0x000000018BC697F0
	}

	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>> // TypeDefIndex: 58873
	{
		// Constructors
		public MultiAimConstraint() {} // 0x000000018BC6AFEC-0x000000018BC6B040
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6AE48-0x000000018BC6AFEC
	}

	[Serializable]
	public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData // TypeDefIndex: 58874
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private WeightedTransformArray m_SourceObjects; // 0x08
		private Vector3Bool m_ConstrainedPositionAxes; // 0x90
		private Vector3Bool m_ConstrainedRotationAxes; // 0x93
		private bool m_MaintainPositionOffset; // 0x96
		private bool m_MaintainRotationOffset; // 0x97
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000185FD7030-0x0000000185FD7090 0x000000018BC69C14-0x000000018BC69C78
		public bool maintainPositionOffset { get => default; set {} } // 0x0000000185FB3360-0x0000000185FB3370 0x0000000185FCD260-0x0000000185FCD270
		public bool maintainRotationOffset { get => default; set {} } // 0x0000000185FD70E0-0x0000000185FD70F0 0x0000000185FD7100-0x0000000185FD7110
		public bool constrainedPositionXAxis { get => default; set {} } // 0x0000000185FB2250-0x0000000185FB2260 0x0000000185FB2260-0x0000000185FB2270
		public bool constrainedPositionYAxis { get => default; set {} } // 0x0000000185FB2070-0x0000000185FB2080 0x0000000185FB2090-0x0000000185FB20A0
		public bool constrainedPositionZAxis { get => default; set {} } // 0x0000000185FB2080-0x0000000185FB2090 0x0000000185FB20A0-0x0000000185FB20B0
		public bool constrainedRotationXAxis { get => default; set {} } // 0x0000000185FD6080-0x0000000185FD6090 0x0000000185FD6850-0x0000000185FD6860
		public bool constrainedRotationYAxis { get => default; set {} } // 0x0000000185FCD9D0-0x0000000185FCD9E0 0x0000000185FCD9E0-0x0000000185FCD9F0
		public bool constrainedRotationZAxis { get => default; set {} } // 0x0000000185FB3370-0x0000000185FB3380 0x0000000185FD70F0-0x0000000185FD7100
		string IMultiParentConstraintData.sourceObjectsProperty { get => default; } // 0x000000018BC6B248-0x000000018BC6B27C 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC6B040-0x000000018BC6B1C4
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC6B1C4-0x000000018BC6B248
	}

	public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder<MultiParentConstraintData>> // TypeDefIndex: 58875
	{
		// Constructors
		public MultiParentConstraint() {} // 0x000000018BC6BE84-0x000000018BC6BED8
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6BD48-0x000000018BC6BE84
	}

	[Serializable]
	public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData // TypeDefIndex: 58876
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private WeightedTransformArray m_SourceObjects; // 0x08
		private Vector3 m_Offset; // 0x90
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000185FD7030-0x0000000185FD7090 0x000000018BC69C14-0x000000018BC69C78
		public bool maintainOffset { get => default; set {} } // 0x0000000185FCECD0-0x0000000185FCECE0 0x0000000185FCED20-0x0000000185FCED30
		public Vector3 offset { get => default; set {} } // 0x0000000185FBCED0-0x0000000185FBCEF0 0x0000000185FBF7F0-0x0000000185FBF810
		public bool constrainedXAxis { get => default; set {} } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		public bool constrainedYAxis { get => default; set {} } // 0x0000000185FCECC0-0x0000000185FCECD0 0x0000000185FCED10-0x0000000185FCED20
		public bool constrainedZAxis { get => default; set {} } // 0x0000000185FCECE0-0x0000000185FCECF0 0x0000000185FCED30-0x0000000185FCED40
		string IMultiPositionConstraintData.offsetVector3Property { get => default; } // 0x000000018BC6C0E4-0x000000018BC6C118 
		string IMultiPositionConstraintData.sourceObjectsProperty { get => default; } // 0x000000018BC6C118-0x000000018BC6C14C 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC6BED8-0x000000018BC6C05C
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC6C05C-0x000000018BC6C0E4
	}

	public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder<MultiPositionConstraintData>> // TypeDefIndex: 58877
	{
		// Constructors
		public MultiPositionConstraint() {} // 0x000000018BC6C984-0x000000018BC6C9D8
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6C848-0x000000018BC6C984
	}

	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData // TypeDefIndex: 58878
	{
		// Fields
		private int m_Driver; // 0x00
		private List<Transform> m_SourceObjects; // 0x08
	
		// Properties
		public int driver { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x000000018BC6CD04-0x000000018BC6CD60
		public List<Transform> sourceObjects { get => default; set {} } // 0x000000018BC6CC80-0x000000018BC6CD04 0x000000018BC6CD60-0x000000018BC6CDD0
		Transform[] IMultiReferentialConstraintData.sourceObjects { get => default; } // 0x000000018BC6CBE8-0x000000018BC6CC30 
		int IMultiReferentialConstraintData.driverValue { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		string IMultiReferentialConstraintData.driverIntProperty { get => default; } // 0x000000018BC6CBB4-0x000000018BC6CBE8 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC6C9D8-0x000000018BC6CB3C
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC6CB3C-0x000000018BC6CBB4
		public void UpdateDriver() {} // 0x000000018BC6CC30-0x000000018BC6CC80
	}

	public class MultiReferentialConstraint : RigConstraint<MultiReferentialConstraintJob, MultiReferentialConstraintData, MultiReferentialConstraintJobBinder<MultiReferentialConstraintData>> // TypeDefIndex: 58879
	{
		// Constructors
		public MultiReferentialConstraint() {} // 0x000000018BC6D464-0x000000018BC6D4B8
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6D420-0x000000018BC6D464
	}

	[Serializable]
	public struct MultiRotationConstraintData : IAnimationJobData, IMultiRotationConstraintData // TypeDefIndex: 58880
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private WeightedTransformArray m_SourceObjects; // 0x08
		private Vector3 m_Offset; // 0x90
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000185FD7030-0x0000000185FD7090 0x000000018BC69C14-0x000000018BC69C78
		public bool maintainOffset { get => default; set {} } // 0x0000000185FCECD0-0x0000000185FCECE0 0x0000000185FCED20-0x0000000185FCED30
		public Vector3 offset { get => default; set {} } // 0x0000000185FBCED0-0x0000000185FBCEF0 0x0000000185FBF7F0-0x0000000185FBF810
		public bool constrainedXAxis { get => default; set {} } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		public bool constrainedYAxis { get => default; set {} } // 0x0000000185FCECC0-0x0000000185FCECD0 0x0000000185FCED10-0x0000000185FCED20
		public bool constrainedZAxis { get => default; set {} } // 0x0000000185FCECE0-0x0000000185FCECF0 0x0000000185FCED30-0x0000000185FCED40
		string IMultiRotationConstraintData.offsetVector3Property { get => default; } // 0x000000018BC6D6C4-0x000000018BC6D6F8 
		string IMultiRotationConstraintData.sourceObjectsProperty { get => default; } // 0x000000018BC6D6F8-0x000000018BC6D72C 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC6D4B8-0x000000018BC6D63C
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC6D63C-0x000000018BC6D6C4
	}

	public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder<MultiRotationConstraintData>> // TypeDefIndex: 58881
	{
		// Constructors
		public MultiRotationConstraint() {} // 0x000000018BC6DF58-0x000000018BC6DFAC
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6DE1C-0x000000018BC6DF58
	}

	[Serializable]
	public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData // TypeDefIndex: 58883
	{
		// Fields
		private Transform m_ConstrainedObject; // 0x00
		private Transform m_OverrideSource; // 0x08
		private Vector3 m_OverridePosition; // 0x10
		private Vector3 m_OverrideRotation; // 0x1C
		private float m_PositionWeight; // 0x28
		private float m_RotationWeight; // 0x2C
		private Space m_Space; // 0x30
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform sourceObject { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Space space { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public Vector3 position { get => default; set {} } // 0x00000001834AE2B0-0x00000001834AE2D0 0x0000000185FB6850-0x0000000185FB6860
		public Vector3 rotation { get => default; set {} } // 0x0000000185FBE120-0x0000000185FBE140 0x0000000185FBE140-0x0000000185FBE150
		public float positionWeight { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x000000018BC6E4B8-0x000000018BC6E4D0
		public float rotationWeight { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x000000018BC6E4D0-0x000000018BC6E4E8
		int IOverrideTransformData.space { get => default; } // 0x00000001813CFF60-0x00000001813CFF70 
		string IOverrideTransformData.positionWeightFloatProperty { get => default; } // 0x000000018BC6E41C-0x000000018BC6E450 
		string IOverrideTransformData.rotationWeightFloatProperty { get => default; } // 0x000000018BC6E484-0x000000018BC6E4B8 
		string IOverrideTransformData.positionVector3Property { get => default; } // 0x000000018BC6E3E8-0x000000018BC6E41C 
		string IOverrideTransformData.rotationVector3Property { get => default; } // 0x000000018BC6E450-0x000000018BC6E484 
	
		// Nested types
		[Serializable]
		public enum Space // TypeDefIndex: 58882
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC6E328-0x000000018BC6E378
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC6E378-0x000000018BC6E3E8
	}

	public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder<OverrideTransformData>> // TypeDefIndex: 58884
	{
		// Constructors
		public OverrideTransform() {} // 0x000000018BC6EE48-0x000000018BC6EE9C
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC6EDE4-0x000000018BC6EE48
	}

	[Serializable]
	public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData // TypeDefIndex: 58885
	{
		// Fields
		private Transform m_Root; // 0x00
		private Transform m_Tip; // 0x08
		private Transform m_RootTarget; // 0x10
		private Transform m_TipTarget; // 0x18
		private AnimationCurve m_Curve; // 0x20
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform tip { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Transform rootTarget { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Transform tipTarget { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public AnimationCurve curve { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC74B00-0x000000018BC74BE8
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC74BE8-0x000000018BC74C54
	}

	public class TwistChainConstraint : RigConstraint<TwistChainConstraintJob, TwistChainConstraintData, TwistChainConstraintJobBinder<TwistChainConstraintData>> // TypeDefIndex: 58886
	{
		// Constructors
		public TwistChainConstraint() {} // 0x000000018BC7514C-0x000000018BC751A0
	}

	[Serializable]
	public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData // TypeDefIndex: 58888
	{
		// Fields
		private Transform m_Source; // 0x00
		private Axis m_TwistAxis; // 0x08
		private WeightedTransformArray m_TwistNodes; // 0x10
	
		// Properties
		public Transform sourceObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public WeightedTransformArray twistNodes { get => default; set {} } // 0x00000001834A5DF0-0x00000001834A5E50 0x000000018BC7533C-0x000000018BC753A0
		public Axis twistAxis { get => default; set {} } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		Transform ITwistCorrectionData.source { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		Vector3 ITwistCorrectionData.twistAxis { get => default; } // 0x000000018BC752D8-0x000000018BC75308 
		string ITwistCorrectionData.twistNodesProperty { get => default; } // 0x000000018BC75308-0x000000018BC7533C 
	
		// Nested types
		public enum Axis // TypeDefIndex: 58887
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Methods
		private static Vector3 Convert(Axis axis) => default; // 0x000000018B71BC7C-0x000000018B71BCBC
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC751A0-0x000000018BC75278
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC75278-0x000000018BC752D8
	}

	public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder<TwistCorrectionData>> // TypeDefIndex: 58889
	{
		// Constructors
		public TwistCorrection() {} // 0x000000018BC758A0-0x000000018BC758F4
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC7575C-0x000000018BC758A0
	}

	[Serializable]
	public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData // TypeDefIndex: 58890
	{
		// Fields
		private Transform m_Root; // 0x00
		private Transform m_Mid; // 0x08
		private Transform m_Tip; // 0x10
		private Transform m_Target; // 0x18
		private Transform m_Hint; // 0x20
		private float m_TargetPositionWeight; // 0x28
		private float m_TargetRotationWeight; // 0x2C
		private float m_HintWeight; // 0x30
		private bool m_MaintainTargetPositionOffset; // 0x34
		private bool m_MaintainTargetRotationOffset; // 0x35
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform mid { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Transform tip { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Transform target { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Transform hint { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public float targetPositionWeight { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x000000018BC6E4B8-0x000000018BC6E4D0
		public float targetRotationWeight { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x000000018BC6E4D0-0x000000018BC6E4E8
		public float hintWeight { get => default; set {} } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x000000018BC75AE8-0x000000018BC75B00
		public bool maintainTargetPositionOffset { get => default; set {} } // 0x0000000185FB0B90-0x0000000185FB0BA0 0x0000000185FB0BB0-0x0000000185FB0BC0
		public bool maintainTargetRotationOffset { get => default; set {} } // 0x0000000185FB0B80-0x0000000185FB0B90 0x0000000185FB0BA0-0x0000000185FB0BB0
		string ITwoBoneIKConstraintData.targetPositionWeightFloatProperty { get => default; } // 0x000000018BC75A80-0x000000018BC75AB4 
		string ITwoBoneIKConstraintData.targetRotationWeightFloatProperty { get => default; } // 0x000000018BC75AB4-0x000000018BC75AE8 
		string ITwoBoneIKConstraintData.hintWeightFloatProperty { get => default; } // 0x000000018BC75A4C-0x000000018BC75A80 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x000000018BC758F4-0x000000018BC759E8
		void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC759E8-0x000000018BC75A4C
	}

	public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder<TwoBoneIKConstraintData>> // TypeDefIndex: 58891
	{
		// Constructors
		public TwoBoneIKConstraint() {} // 0x000000018BC75F18-0x000000018BC75F6C
	
		// Methods
		protected override void OnValidate() {} // 0x000000018BC75EA0-0x000000018BC75F18
	}

	public interface IRigConstraint // TypeDefIndex: 58892
	{
		// Properties
		IAnimationJobData data { get; }
		IAnimationJobBinder binder { get; }
		Component component { get; }
		float weight { get; set; }
	
		// Methods
		bool IsValid();
		IAnimationJob CreateJob(Animator animator);
		void UpdateJob(IAnimationJob job);
		void DestroyJob(IAnimationJob job);
	}

	public interface IRigLayer // TypeDefIndex: 58893
	{
		// Properties
		Rig rig { get; }
		IRigConstraint[] constraints { get; }
		IAnimationJob[] jobs { get; }
		bool active { get; }
		string name { get; }
	
		// Methods
		bool Initialize(Animator animator);
		void Update();
		void Reset();
		bool IsValid();
	}

	public class OverrideRigConstraint<TConstraint, TJob, TData, TBinder> : IRigConstraint // TypeDefIndex: 58894
		where TConstraint : MonoBehaviour, IRigConstraint
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		protected TConstraint m_Constraint;
		private static readonly TBinder s_Binder;
	
		// Properties
		IAnimationJobBinder IRigConstraint.binder { get => default; }
		IAnimationJobData IRigConstraint.data { get => default; }
		Component IRigConstraint.component { get => default; }
		public float weight { get => default; set {} }
	
		// Constructors
		public OverrideRigConstraint() {} // Dummy constructor
		public OverrideRigConstraint(TConstraint baseConstraint) {}
		static OverrideRigConstraint() {}
	
		// Methods
		public IAnimationJob CreateJob(Animator animator) => default;
		public void DestroyJob(IAnimationJob job) {}
		public void UpdateJob(IAnimationJob job) {}
		public bool IsValid() => default;
	}

	[Serializable]
	public class OverrideRigLayer : IRigLayer // TypeDefIndex: 58895
	{
		// Fields
		private Rig m_Rig; // 0x10
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get => default; private set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool active { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public string name { get => default; } // 0x000000018BC6E298-0x000000018BC6E328 
		public IRigConstraint[] constraints { get => default; } // 0x000000018BC6E278-0x000000018BC6E288 
		public IAnimationJob[] jobs { get => default; } // 0x000000018BC6E288-0x000000018BC6E298 
		public bool isInitialized { get; private set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
	
		// Constructors
		public OverrideRigLayer() {} // Dummy constructor
		public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true /* Metadata: 0x0207FF5D */) {} // 0x000000018BC6E248-0x000000018BC6E278
	
		// Methods
		public bool Initialize(Animator animator) => default; // 0x000000018BC6DFAC-0x000000018BC6E0DC
		public void Update() {} // 0x000000018BC6E1DC-0x000000018BC6E248
		public void Reset() {} // 0x000000018BC6E138-0x000000018BC6E1DC
		public bool IsValid() => default; // 0x000000018BC6E0DC-0x000000018BC6E138
	}

	public class Rig : MonoBehaviour, IRigEffectorHolder // TypeDefIndex: 58896
	{
		// Fields
		private float m_Weight; // 0x18
		private List<RigEffectorData> m_Effectors; // 0x20
	
		// Properties
		public float weight { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000189CBA374-0x0000000189CBA38C
	
		// Constructors
		public Rig() {} // 0x000000018BC74248-0x000000018BC742D0
	}

	public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder // TypeDefIndex: 58899
	{
		// Fields
		private List<RigLayer> m_RigLayers; // 0x18
		private IRigLayer[] m_RuntimeRigLayers; // 0x20
		private SyncSceneToStreamLayer m_SyncSceneToStreamLayer; // 0x28
		private List<RigEffectorData> m_Effectors; // 0x30
		public static OnAddRigBuilderCallback onAddRigBuilder; // 0x00
		public static OnRemoveRigBuilderCallback onRemoveRigBuilder; // 0x08
		private PlayableGraph _graph_k__BackingField; // 0x38
	
		// Properties
		public List<RigLayer> layers { get => default; set {} } // 0x00000001833EEC70-0x00000001833EEC80 0x0000000185A264E0-0x0000000185A26510
		private SyncSceneToStreamLayer syncSceneToStreamLayer { get => default; set {} } // 0x00000001864BB614-0x00000001864BB734 0x00000001882A83C4-0x00000001882A84E8
		public PlayableGraph graph { get; private set; } // 0x00000001833EEC70-0x00000001833EEC80 0x0000000185A264E0-0x0000000185A26510
	
		// Nested types
		public delegate void OnAddRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 58897; 0x000000018BC71218-0x000000018BC71280
	
		public delegate void OnRemoveRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 58898; 0x000000018BC710F8-0x000000018BC71210
	
		// Constructors
		public RigBuilder() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void OnEnable() {} // 0x000000018BC71418-0x000000018BC714C4
		private void OnDisable() {} // 0x000000018BC70CC4-0x000000018BC70F80
		private void OnDestroy() {} // 0x000000018BC71638-0x000000018BC716BC
		private void Update() {} // 0x0000000184088E70-0x0000000184088E80
		public bool Build() => default; // 0x000000018BC716BC-0x000000018BC71718
		public void Clear() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public void StartPreview() {} // 0x0000000185FBB850-0x0000000185FBB860
		public void StopPreview() {} // 0x0000000185FBD980-0x0000000185FBD990
		public void UpdatePreviewGraph(PlayableGraph graph) {} // 0x000000018BC715B8-0x000000018BC71638
		public Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable) => default; // 0x00000001882A83C4-0x00000001882A84E8
	}

	internal static class RigBuilderUtils // TypeDefIndex: 58901
	{
		// Fields
		private static readonly ushort k_AnimationOutputPriority; // 0x00
	
		// Nested types
		public struct PlayableChain // TypeDefIndex: 58900
		{
			// Fields
			public string name; // 0x00
			public Playable[] playables; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x000000018BC70A64-0x000000018BC70C8C
		}
	
		// Constructors
		static RigBuilderUtils() {} // 0x000000018BC6EE9C-0x000000018BC6EEB4
	
		// Methods
		public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer) => default; // 0x000000018BC7050C-0x000000018BC70A64
		public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) => default; // 0x000000018BC701BC-0x000000018BC7050C
		public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) => default; // 0x000000018BC70C8C-0x000000018BC70CC4
	}

	public class RigConstraint<TJob, TData, TBinder> : MonoBehaviour, IRigConstraint // TypeDefIndex: 58902
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		protected float m_Weight;
		protected TData m_Data;
		private static readonly TBinder s_Binder;
	
		// Properties
		public ref TData data { get => default; }
		public float weight { get => default; set {} }
		IAnimationJobBinder IRigConstraint.binder { get => default; }
		IAnimationJobData IRigConstraint.data { get => default; }
		Component IRigConstraint.component { get => default; }
	
		// Constructors
		public RigConstraint() {}
		static RigConstraint() {}
	
		// Methods
		public void Reset() {}
		public bool IsValid() => default;
		protected virtual void OnValidate() {}
		public IAnimationJob CreateJob(Animator animator) => default;
		public void DestroyJob(IAnimationJob job) {}
		public void UpdateJob(IAnimationJob job) {}
	}

	[Serializable]
	public class RigLayer : IRigLayer // TypeDefIndex: 58903
	{
		// Fields
		private Rig m_Rig; // 0x10
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get => default; private set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool active { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public string name { get => default; } // 0x000000018BC719B8-0x000000018BC71A48 
		public IRigConstraint[] constraints { get => default; } // 0x000000018BC6E278-0x000000018BC6E288 
		public IAnimationJob[] jobs { get => default; } // 0x000000018BC6E288-0x000000018BC6E298 
		public bool isInitialized { get; private set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
	
		// Constructors
		public RigLayer() {} // Dummy constructor
		public RigLayer(Rig rig, bool active = true /* Metadata: 0x0207FF5E */) {} // 0x000000018B40BBB8-0x000000018B40BBE0
	
		// Methods
		public bool Initialize(Animator animator) => default; // 0x000000018BC71768-0x000000018BC71850
		public void Update() {} // 0x000000018BC71934-0x000000018BC719B8
		public void Reset() {} // 0x000000018BC718AC-0x000000018BC71934
		public bool IsValid() => default; // 0x000000018BC71850-0x000000018BC718AC
	}

	public class RigTransform : MonoBehaviour // TypeDefIndex: 58904
	{
		// Constructors
		public RigTransform() {} // 0x000000018646DB20-0x000000018646DB28
	}

	internal static class RigUtils // TypeDefIndex: 58907
	{
		// Fields
		internal static readonly Dictionary<System.Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor; // 0x00
		private static readonly IAnimationJobBinder _syncSceneToStreamBinder_k__BackingField; // 0x08
	
		// Properties
		public static IAnimationJobBinder syncSceneToStreamBinder { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData // TypeDefIndex: 58905
		{
			// Fields
			private Transform[] _syncableTransforms_k__BackingField; // 0x00
			private SyncableProperties[] _syncableProperties_k__BackingField; // 0x08
			private bool[] _rigStates_k__BackingField; // 0x10
			private readonly bool m_IsValid; // 0x18
	
			// Properties
			public Transform[] syncableTransforms { get; private set; } // 0x000000018BC7328C-0x000000018BC7363C 0x000000018BC7314C-0x000000018BC7328C
			public SyncableProperties[] syncableProperties { get; private set; } // 0x000000018BC7363C-0x000000018BC73C4C 0x000000018BC72C00-0x000000018BC7314C
			public bool[] rigStates { get; set; } // 0x000000018BC72170-0x000000018BC72C00 0x000000018BC71F00-0x000000018BC71FCC
	
			// Constructors
			public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount) : this() {
				<syncableTransforms>k__BackingField = default;
				<syncableProperties>k__BackingField = default;
				<rigStates>k__BackingField = default;
				m_IsValid = default;
			} // 0x000000018BC73C4C-0x000000018BC73D80
	
			// Methods
			private static int[] UniqueTransformIndices(Transform[] transforms) => default; // 0x000000018BC73D80-0x000000018BC73E6C
			bool IAnimationJobData.IsValid() => default; // 0x000000018BC72100-0x000000018BC72170
			void IAnimationJobData.SetDefaultValues() {} // 0x000000018BC71FCC-0x000000018BC72100
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 58906
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Reflection.FieldInfo, bool> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BC741F8-0x000000018BC74248
			public __c() {} // 0x000000018BC73E6C-0x000000018BC741F8
	
			// Methods
			internal bool _ExtractNestedPropertyType_b__6_0(System.Reflection.FieldInfo info) => default; // 0x000000018BC71C2C-0x000000018BC71DB4
		}
	
		// Constructors
		static RigUtils() {} // 0x000000018BC75F6C-0x000000018BC75FAC
	
		// Methods
		public static IRigConstraint[] GetConstraints(Rig rig) => default; // 0x000000018BC71AA4-0x000000018BC71BFC
		private static Transform[] GetSyncableRigTransforms(Animator animator) => default; // 0x00000001834AFB60-0x00000001834AFB70
		private static bool ExtractTransformType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms) => default; // 0x000000018646FE2C-0x000000018646FE34
		private static bool ExtractPropertyType(System.Reflection.FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0207FF5F */) => default; // 0x000000018357A260-0x000000018357A270
		private static bool ExtractWeightedTransforms(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties) => default; // 0x00000001877900A4-0x00000001877900B4
		private static bool ExtractNestedPropertyType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0207FF60 */) => default; // 0x000000018346D130-0x000000018346D140
		private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform> syncableTransforms, out List<SyncableProperties> syncableProperties) {
			syncableTransforms = default;
			syncableProperties = default;
		} // 0x0000000184096E30-0x0000000184096EF0
		public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints) => default; // 0x00000001813C0430-0x00000001813C0440
		public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs) {} // 0x000000018BC71BFC-0x000000018BC71C2C
		internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers) => default; // 0x000000018BC75FAC-0x000000018BC76010
	}

	internal class SyncSceneToStreamLayer // TypeDefIndex: 58908
	{
		// Fields
		private bool _isInitialized_k__BackingField; // 0x10
		public IAnimationJob job; // 0x18
		private IAnimationJobData m_Data; // 0x20
		private List<int> m_RigIndices; // 0x28
	
		// Properties
		public bool isInitialized { get; private set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public SyncSceneToStreamLayer() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool Initialize(Animator animator, IList<IRigLayer> layers) => default; // 0x000000018BC742D0-0x000000018BC744C4
		public void Update(IList<IRigLayer> layers) {} // 0x000000018BC74598-0x000000018BC7478C
		public void Reset() {} // 0x000000018BC744D8-0x000000018BC74598
		public bool IsValid() => default; // 0x000000018BC744C4-0x000000018BC744D8
	}

	public interface ITransformProvider // TypeDefIndex: 58909
	{
		// Properties
		Transform transform { get; set; }
	}

	public interface IWeightProvider // TypeDefIndex: 58910
	{
		// Properties
		float weight { get; set; }
	}

	[Serializable]
	public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform> // TypeDefIndex: 58911
	{
		// Fields
		public Transform transform; // 0x00
		public float weight; // 0x08
	
		// Properties
		Transform ITransformProvider.transform { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		float IWeightProvider.weight { get => default; set {} } // 0x0000000185FBA140-0x0000000185FBA150 0x000000018BC78FD8-0x000000018BC78FF0
	
		// Constructors
		public WeightedTransform(Transform transform, float weight) : this() {
			this.transform = default;
			this.weight = default;
		} // 0x000000018BC78FF0-0x000000018BC79014
	
		// Methods
		public static WeightedTransform Default(float weight) => default; // 0x000000018BC78F38-0x000000018BC78F60
		public bool Equals(WeightedTransform other) => default; // 0x000000018BC78F60-0x000000018BC78FD8
	}

	[Serializable]
	public struct WeightedTransformArray : IList<WeightedTransform>, IList // TypeDefIndex: 58913
	{
		// Fields
		public static readonly int k_MaxLength; // 0x00
		private int m_Length; // 0x00
		private WeightedTransform m_Item0; // 0x08
		private WeightedTransform m_Item1; // 0x18
		private WeightedTransform m_Item2; // 0x28
		private WeightedTransform m_Item3; // 0x38
		private WeightedTransform m_Item4; // 0x48
		private WeightedTransform m_Item5; // 0x58
		private WeightedTransform m_Item6; // 0x68
		private WeightedTransform m_Item7; // 0x78
	
		// Properties
		object IList.this[int index] { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x00000001840A27C0-0x00000001840A27D0
		public WeightedTransform this[int index] { get => default; set {} } // 0x00000001813AE580-0x00000001813AE590 0x000000018BC78DAC-0x000000018BC78DE8
		public int Count { get => default; } // 0x000000018BC694E8-0x000000018BC695B4 
		public bool IsReadOnly { get => default; } // 0x000000018BC6943C-0x000000018BC69490 
		public bool IsFixedSize { get => default; } // 0x0000000185FD6FF0-0x0000000185FD7000 
		bool ICollection.IsSynchronized { get => default; } // 0x0000000185492010-0x0000000185492020 
		object ICollection.SyncRoot { get => default; } // 0x000000018BC695B4-0x000000018BC69624 
	
		// Nested types
		[Serializable]
		private struct Enumerator : IEnumerator<WeightedTransform> // TypeDefIndex: 58912
		{
			// Fields
			private WeightedTransformArray m_Array; // 0x00
			private int m_Index; // 0x88
	
			// Properties
			public WeightedTransform Current { get => default; } // 0x000000018BC77988-0x000000018BC77ABC 
			object IEnumerator.Current { get => default; } // 0x0000000185FBD010-0x0000000185FBD020 
	
			// Constructors
			public Enumerator(ref WeightedTransformArray array) : this() {
				m_Array = default;
				m_Index = default;
			} // 0x000000018BC78DE8-0x000000018BC78E5C
	
			// Methods
			public bool MoveNext() => default; // 0x000000018BC77E84-0x000000018BC77F44
			public void Reset() {} // 0x000000018BC7897C-0x000000018BC78A3C
			void IDisposable.Dispose() {} // 0x000000018BC78A3C-0x000000018BC78AB8
		}
	
		// Constructors
		public WeightedTransformArray(int size) : this() {
			m_Length = default;
			m_Item0 = default;
			m_Item1 = default;
			m_Item2 = default;
			m_Item3 = default;
			m_Item4 = default;
			m_Item5 = default;
			m_Item6 = default;
			m_Item7 = default;
		} // 0x000000018BC78B30-0x000000018BC78BA8
		static WeightedTransformArray() {
			k_MaxLength = default;
		} // 0x000000018BC69490-0x000000018BC694E8
	
		// Methods
		public IEnumerator<WeightedTransform> GetEnumerator() => default; // 0x000000018BC780B4-0x000000018BC78150
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BC78AB8-0x000000018BC78B30
		int IList.Add(object value) => default; // 0x000000018BC77C20-0x000000018BC77CBC
		public void Add(WeightedTransform value) {} // 0x000000018BC78794-0x000000018BC7897C
		public void Clear() {} // 0x000000018BC77CBC-0x000000018BC77E84
		int IList.IndexOf(object value) => default; // 0x000000018BC78C30-0x000000018BC78CA8
		public int IndexOf(WeightedTransform value) => default; // 0x000000018BC7847C-0x000000018BC78568
		bool IList.Contains(object value) => default; // 0x000000018BC783E4-0x000000018BC7847C
		public bool Contains(WeightedTransform value) => default; // 0x000000018BC78BA8-0x000000018BC78C30
		void ICollection.CopyTo(Array array, int arrayIndex) {} // 0x000000018BC78150-0x000000018BC78320
		public void CopyTo(WeightedTransform[] array, int arrayIndex) {} // 0x000000018BC77BCC-0x000000018BC77C20
		void IList.Remove(object value) {} // 0x000000018BC77ABC-0x000000018BC77BCC
		public bool Remove(WeightedTransform value) => default; // 0x000000018BC77FF8-0x000000018BC780B4
		public void RemoveAt(int index) {} // 0x000000018BC78698-0x000000018BC78794
		void IList.Insert(int index, object value) {} // 0x000000018BC78608-0x000000018BC78698
		public void Insert(int index, WeightedTransform value) {} // 0x000000018BC77F9C-0x000000018BC77FF8
		private static int ClampSize(int size) => default; // 0x000000018BC78568-0x000000018BC78608
		private void CheckOutOfRangeIndex(int index) {} // 0x000000018BC77F44-0x000000018BC77F9C
		private WeightedTransform Get(int index) => default; // 0x000000018BC78320-0x000000018BC783E4
		private void Set(int index, WeightedTransform value) {} // 0x000000018BC78CA8-0x000000018BC78D24
		public void SetWeight(int index, float weight) {} // 0x000000018BC78D24-0x000000018BC78DAC
		public float GetWeight(int index) => default; // 0x000000018BC78E5C-0x000000018BC78ECC
		public void SetTransform(int index, Transform transform) {} // 0x000000018BC78ECC-0x000000018BC78F38
		public Transform GetTransform(int index) => default; // 0x00000001818226B0-0x00000001818226C0
		public static void OnValidate(ref WeightedTransformArray array, float min = 0f /* Metadata: 0x0207FF61 */, float max = 1f /* Metadata: 0x0207FF65 */) {} // 0x00000001814A81B0-0x00000001814A81C0
	}

	internal sealed class ExpandChildrenAttribute : PropertyAttribute // TypeDefIndex: 58914
	{
		// Constructors
		public ExpandChildrenAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SyncSceneToStreamAttribute : Attribute // TypeDefIndex: 58915
	{
		// Constructors
		public SyncSceneToStreamAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal enum PropertyType : byte // TypeDefIndex: 58916
	{
		Bool = 0,
		Int = 1,
		Float = 2
	}

	internal struct PropertyDescriptor // TypeDefIndex: 58917
	{
		// Fields
		public int size; // 0x00
		public PropertyType type; // 0x04
	}

	internal struct Property // TypeDefIndex: 58918
	{
		// Fields
		public string name; // 0x00
		public PropertyDescriptor descriptor; // 0x08
	}

	internal struct RigProperties // TypeDefIndex: 58919
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
	
		// Constructors
		static RigProperties() {
			s_Weight = default;
		} // 0x000000018BC71A48-0x000000018BC71AA4
	}

	internal struct ConstraintProperties // TypeDefIndex: 58920
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
		public Property[] properties; // 0x08
	
		// Constructors
		static ConstraintProperties() {
			s_Weight = default;
		} // 0x000000018BC6857C-0x000000018BC685D8
	}

	public static class PropertyUtils // TypeDefIndex: 58921
	{
		// Methods
		public static string ConstructConstraintDataPropertyName(string property) => default; // 0x000000018BC6F260-0x000000018BC6F268
		public static string ConstructCustomPropertyName(Component component, string property) => default; // 0x000000018BC6F268-0x000000018BC6F270
	}

	public sealed class WeightRangeAttribute : PropertyAttribute // TypeDefIndex: 58922
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public WeightRangeAttribute() {} // Dummy constructor
		public WeightRangeAttribute(float min, float max) {} // 0x0000000185FBF890-0x0000000185FBF8A0
	}

	public interface IRigEffectorHolder // TypeDefIndex: 58923
	{
	}

	[Serializable]
	public class RigEffectorData // TypeDefIndex: 58925
	{
		// Fields
		private Transform m_Transform; // 0x10
		private Style m_Style; // 0x18
		private bool m_Visible; // 0x50
	
		// Properties
		public Transform transform { get => default; } // 0x000000018346D130-0x000000018346D140 
		public Style style { get => default; } // 0x0000000185FC4040-0x0000000185FC4070 
		public bool visible { get => default; set {} } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 58924
		{
			// Fields
			public Mesh shape; // 0x00
			public UnityEngine.Color color; // 0x08
			public float size; // 0x18
			public Vector3 position; // 0x1C
			public Vector3 rotation; // 0x28
		}
	
		// Constructors
		public RigEffectorData() {} // 0x0000000185FD5DD0-0x0000000185FD5DE0
	
		// Methods
		public void Initialize(Transform transform, Style style) {} // 0x000000018BC71718-0x000000018BC71768
	}

	[Serializable]
	public struct AffineTransform // TypeDefIndex: 58926
	{
		// Fields
		public Vector3 translation; // 0x00
		public Quaternion rotation; // 0x0C
		private static readonly AffineTransform _identity_k__BackingField; // 0x00
	
		// Properties
		public static AffineTransform identity { get; } // 0x000000018BC654A0-0x000000018BC65500 
	
		// Constructors
		public AffineTransform(Vector3 t, Quaternion r) : this() {
			translation = default;
			rotation = default;
		} // 0x0000000185FBDA20-0x0000000185FBDA40
		static AffineTransform() {
			<identity>k__BackingField = default;
		} // 0x000000018BC65414-0x000000018BC654A0
	
		// Methods
		public void Set(Vector3 t, Quaternion r) {} // 0x0000000185FBDA20-0x0000000185FBDA40
		public Vector3 Transform(Vector3 p) => default; // 0x0000000187F81278-0x0000000187F81304
		public Vector3 InverseTransform(Vector3 p) => default; // 0x0000000187F81108-0x0000000187F811C8
		public AffineTransform Inverse() => default; // 0x0000000187F811C8-0x0000000187F81278
		public AffineTransform InverseMul(AffineTransform transform) => default; // 0x0000000187F80FE0-0x0000000187F81108
		public static Vector3 operator *(AffineTransform lhs, Vector3 rhs) => default; // 0x0000000187F81278-0x0000000187F81304
		public static AffineTransform operator *(AffineTransform lhs, AffineTransform rhs) => default; // 0x000000018BC65500-0x000000018BC65614
		public static AffineTransform operator *(Quaternion lhs, AffineTransform rhs) => default; // 0x0000000187F81504-0x0000000187F815A4
		public static AffineTransform operator *(AffineTransform lhs, Quaternion rhs) => default; // 0x0000000187F815A4-0x0000000187F815F8
	}

	public static class AnimationRuntimeUtils // TypeDefIndex: 58927
	{
		// Fields
		private const float k_SqrEpsilon = 1E-08f; // Metadata: 0x0207FF6C
	
		// Methods
		public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset) {} // 0x000000018BC663CC-0x000000018BC67120
		private static float TriangleAngle(float aLen, float aLen1, float aLen2) => default; // 0x000000018BC67170-0x000000018BC671C0
		public static bool SolveFABRIK(ref NativeArray<Vector3> linkPositions, ref NativeArray<float> linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations) => default; // 0x000000018BC65F20-0x000000018BC663CC
		public static float SqrDistance(Vector3 lhs, Vector3 rhs) => default; // 0x0000000187829F18-0x0000000187829F74
		public static float Square(float value) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t) => default; // 0x000000018BC65BF4-0x000000018BC65CF8
		public static float Select(float a, float b, float c) => default; // 0x000000018BC65F14-0x000000018BC65F20
		public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c) => default; // 0x000000018BC65EB8-0x000000018BC65F14
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) => default; // 0x000000018BC65DF8-0x000000018BC65EB8
		internal static float Sum(AnimationJobCache cache, CacheIndex index, int count) => default; // 0x000000018BC67148-0x000000018BC67170
		public static float Sum(NativeArray<float> floatBuffer) => default; // 0x000000018BC67120-0x000000018BC67148
		public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle) {} // 0x000000018BC65CF8-0x000000018BC65DF8
	}

	public class BoneRenderer : MonoBehaviour // TypeDefIndex: 58929
	{
		// Fields
		public BoneShape boneShape; // 0x18
		public bool drawBones; // 0x1C
		public bool drawTripods; // 0x1D
		public float boneSize; // 0x20
		public float tripodSize; // 0x24
		public UnityEngine.Color boneColor; // 0x28
		private Transform[] m_Transforms; // 0x38
	
		// Properties
		public Transform[] transforms { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
		// Nested types
		public enum BoneShape // TypeDefIndex: 58928
		{
			Line = 0,
			Pyramid = 1,
			Box = 2
		}
	
		// Constructors
		public BoneRenderer() {} // 0x000000018BC679B0-0x000000018BC679DC
	}

	public static class ConstraintsUtils // TypeDefIndex: 58931
	{
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 58930
		{
			// Fields
			public float totalLength; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018BC68744-0x000000018BC68894
	
			// Methods
			internal void _ExtractSteps_b__0(float length) {} // 0x000000018BC68894-0x000000018BC68960
		}
	
		// Methods
		public static Transform[] ExtractChain(Transform root, Transform tip) => default; // 0x000000018BC68960-0x000000018BC68A90
		public static float[] ExtractLengths(Transform[] chain) => default; // 0x000000018BC685D8-0x000000018BC68614
		public static float[] ExtractSteps(Transform[] chain) => default; // 0x000000018BC68614-0x000000018BC68744
		public static string ConstructConstraintDataPropertyName(string property) => default; // 0x0000000185492010-0x0000000185492020
		public static string ConstructCustomPropertyName(Component component, string property) => default; // 0x0000000185FD7150-0x0000000185FD7160
	}

	public static class QuaternionExt // TypeDefIndex: 58932
	{
		// Fields
		private const float k_FloatMin = 1E-10f; // Metadata: 0x0207FF73
		public static readonly Quaternion zero; // 0x00
	
		// Constructors
		static QuaternionExt() {} // 0x000000018BC6F55C-0x000000018BC6F598
	
		// Methods
		public static Quaternion FromToRotation(Vector3 from, Vector3 to) => default; // 0x000000018BC6F2F4-0x000000018BC6F4E8
		public static Quaternion Add(Quaternion rhs, Quaternion lhs) => default; // 0x000000018BC6F270-0x000000018BC6F2F4
		public static Quaternion Scale(Quaternion q, float scale) => default; // 0x00000001840DD310-0x00000001840DD330
		public static Quaternion NormalizeSafe(Quaternion q) => default; // 0x000000018BC6F4E8-0x000000018BC6F55C
	}

	[Serializable]
	public struct Vector3Bool // TypeDefIndex: 58933
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Constructors
		public Vector3Bool(bool val) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FD7160-0x0000000185FD7170
		public Vector3Bool(bool x, bool y, bool z) {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FCC280-0x0000000185FCC290
	}
}
