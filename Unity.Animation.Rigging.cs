/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

// Image 58: Unity.Animation.Rigging.dll - Assembly: Unity.Animation.Rigging, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57793-57928
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.Editor")]
[assembly: InternalsVisibleTo("Unity.Animation.Rigging.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace UnityEngine.Animations.Rigging
{
	public struct CacheIndex // TypeDefIndex: 57796
	{
		// Fields
		internal int idx; // 0x00
	}

	public struct AnimationJobCache : IDisposable // TypeDefIndex: 57797
	{
		// Fields
		private NativeArray<float> m_Data; // 0x00
	
		// Constructors
		internal AnimationJobCache(float[] data) {
			m_Data = default;
		} // 0x0000000189B4C31C-0x0000000189B4C380
	
		// Methods
		public void Dispose() {} // 0x0000000189B4C2E0-0x0000000189B4C31C
		public float GetRaw(CacheIndex index, int offset = 0 /* Metadata: 0x01FDA652 */) => default; // 0x0000000183D76310-0x0000000183D76320
		public void SetRaw(float val, CacheIndex index, int offset = 0 /* Metadata: 0x01FDA653 */) {} // 0x0000000183D76320-0x0000000183D76330
		public T Get<T>(CacheIndex index, int offset = 0 /* Metadata: 0x01FDA654 */)
			where T : struct => default;
		public void Set<T>(T val, CacheIndex index, int offset = 0 /* Metadata: 0x01FDA655 */)
			where T : struct {}
		public void SetArray<T>(T[] v, CacheIndex index, int offset = 0 /* Metadata: 0x01FDA656 */)
			where T : struct {}
	}

	public class AnimationJobCacheBuilder // TypeDefIndex: 57798
	{
		// Fields
		private List<float> m_Data; // 0x10
	
		// Constructors
		public AnimationJobCacheBuilder() {} // 0x0000000189B4C268-0x0000000189B4C2E0
	
		// Methods
		public CacheIndex Add(float v) => default; // 0x0000000189B4BFE0-0x0000000189B4C050
		public CacheIndex Add(Vector2 v) => default; // 0x0000000189B4C050-0x0000000189B4C0D8
		public CacheIndex Add(Vector3 v) => default; // 0x0000000189B4BE60-0x0000000189B4BF08
		public CacheIndex Add(Vector4 v) => default; // 0x0000000189B4BDA0-0x0000000189B4BE60
		public CacheIndex Add(Quaternion v) => default; // 0x0000000189B4BFC0-0x0000000189B4BFE0
		public CacheIndex Add(AffineTransform tx) => default; // 0x0000000189B4BF08-0x0000000189B4BFC0
		public CacheIndex AllocateChunk(int size) => default; // 0x0000000189B4C0D8-0x0000000189B4C170
		public void SetValue(CacheIndex index, int offset, float value) {} // 0x0000000189B4C1DC-0x0000000189B4C268
		public AnimationJobCache Build() => default; // 0x0000000189B4C170-0x0000000189B4C1DC
	}

	[BurstCompile]
	public struct BlendConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57799
	{
		// Fields
		private const int k_BlendTranslationMask = 1; // Metadata: 0x01FDA657
		private const int k_BlendRotationMask = 2; // Metadata: 0x01FDA658
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle sourceA; // 0x0C
		public ReadOnlyTransformHandle sourceB; // 0x24
		public AffineTransform sourceAOffset; // 0x3C
		public AffineTransform sourceBOffset; // 0x58
		public BoolProperty blendPosition; // 0x74
		public BoolProperty blendRotation; // 0x84
		public FloatProperty positionWeight; // 0x94
		public FloatProperty rotationWeight; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76330-0x0000000183D76340 0x0000000183D76340-0x0000000183D76350
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B4DB00-0x0000000189B4E084
	}

	public interface IBlendConstraintData // TypeDefIndex: 57800
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

	public class BlendConstraintJobBinder<T> : AnimationJobBinder<BlendConstraintJob, T> // TypeDefIndex: 57801
		where T : struct, IAnimationJobData, IBlendConstraintData
	{
		// Constructors
		public BlendConstraintJobBinder() {}
	
		// Methods
		public override BlendConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(BlendConstraintJob job) {}
	}

	[BurstCompile]
	public struct ChainIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57802
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
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76350-0x0000000183D76360 0x0000000183D76360-0x0000000183D76370
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B4E4EC-0x0000000189B4EC00
	}

	public interface IChainIKConstraintData // TypeDefIndex: 57803
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

	public class ChainIKConstraintJobBinder<T> : AnimationJobBinder<ChainIKConstraintJob, T> // TypeDefIndex: 57804
		where T : struct, IAnimationJobData, IChainIKConstraintData
	{
		// Constructors
		public ChainIKConstraintJobBinder() {}
	
		// Methods
		public override ChainIKConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(ChainIKConstraintJob job) {}
		public override void Update(ChainIKConstraintJob job, ref ref T data) {}
	}

	[BurstCompile]
	public struct DampedTransformJob : IWeightedAnimationJob // TypeDefIndex: 57805
	{
		// Fields
		private const float k_FixedDt = 0.01667f; // Metadata: 0x01FDA659
		private const float k_DampFactor = 40f; // Metadata: 0x01FDA65D
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform localBindTx; // 0x24
		public Vector3 aimBindAxis; // 0x40
		public AffineTransform prevDrivenTx; // 0x4C
		public FloatProperty dampPosition; // 0x68
		public FloatProperty dampRotation; // 0x78
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D5C7E0-0x0000000183D5C7F0 0x0000000183D76370-0x0000000183D76380
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B4F368-0x0000000189B4FB10
	}

	public interface IDampedTransformData // TypeDefIndex: 57806
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		bool maintainAim { get; }
		string dampPositionFloatProperty { get; }
		string dampRotationFloatProperty { get; }
	}

	public class DampedTransformJobBinder<T> : AnimationJobBinder<DampedTransformJob, T> // TypeDefIndex: 57807
		where T : struct, IAnimationJobData, IDampedTransformData
	{
		// Constructors
		public DampedTransformJobBinder() {}
	
		// Methods
		public override DampedTransformJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(DampedTransformJob job) {}
	}

	public interface IAnimatableProperty<T> // TypeDefIndex: 57808
	{
		// Methods
		T Get(AnimationStream stream);
		void Set(AnimationStream stream, T value);
	}

	public struct BoolProperty : IAnimatableProperty<bool> // TypeDefIndex: 57809
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static BoolProperty Bind(Animator animator, Component component, string name) => default; // 0x0000000189B4E1A0-0x0000000189B4E230
		public static BoolProperty BindCustom(Animator animator, string property) => default; // 0x0000000189B4E168-0x0000000189B4E1A0
		public bool Get(AnimationStream stream) => default; // 0x0000000189B4E230-0x0000000189B4E26C
		public void Set(AnimationStream stream, bool v) {} // 0x0000000189B4E26C-0x0000000189B4E2A8
	}

	public struct IntProperty : IAnimatableProperty<int> // TypeDefIndex: 57810
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static IntProperty Bind(Animator animator, Component component, string name) => default; // 0x0000000189B4E1A0-0x0000000189B4E230
		public static IntProperty BindCustom(Animator animator, string property) => default; // 0x0000000189B4FE60-0x0000000189B4FE98
		public int Get(AnimationStream stream) => default; // 0x0000000189B4FE98-0x0000000189B4FED4
		public void Set(AnimationStream stream, int v) {} // 0x0000000189B4FED4-0x0000000189B4FF10
	}

	public struct FloatProperty : IAnimatableProperty<float> // TypeDefIndex: 57811
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static FloatProperty Bind(Animator animator, Component component, string name) => default; // 0x0000000189B4E1A0-0x0000000189B4E230
		public static FloatProperty BindCustom(Animator animator, string property) => default; // 0x0000000189B4FDB0-0x0000000189B4FDE8
		public float Get(AnimationStream stream) => default; // 0x0000000189B4FDE8-0x0000000189B4FE24
		public void Set(AnimationStream stream, float v) {} // 0x0000000189B4FE24-0x0000000189B4FE60
	}

	public struct Vector2Property : IAnimatableProperty<Vector2> // TypeDefIndex: 57812
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
	
		// Methods
		public static Vector2Property Bind(Animator animator, Component component, string name) => default; // 0x0000000189B5C864-0x0000000189B5C984
		public static Vector2Property BindCustom(Animator animator, string name) => default; // 0x0000000189B5C79C-0x0000000189B5C864
		public Vector2 Get(AnimationStream stream) => default; // 0x0000000189B5C984-0x0000000189B5CA2C
		public void Set(AnimationStream stream, Vector2 value) {} // 0x0000000189B5CA2C-0x0000000189B5CAD8
	}

	public struct Vector3Property : IAnimatableProperty<Vector3> // TypeDefIndex: 57813
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3Property Bind(Animator animator, Component component, string name) => default; // 0x0000000189B5D488-0x0000000189B5D600
		public static Vector3Property BindCustom(Animator animator, string name) => default; // 0x0000000189B5D378-0x0000000189B5D488
		public Vector3 Get(AnimationStream stream) => default; // 0x0000000189B5D600-0x0000000189B5D700
		public void Set(AnimationStream stream, Vector3 value) {} // 0x0000000189B5D700-0x0000000189B5D7DC
	}

	public struct Vector3IntProperty : IAnimatableProperty<Vector3Int> // TypeDefIndex: 57814
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3IntProperty Bind(Animator animator, Component component, string name) => default; // 0x0000000189B5D038-0x0000000189B5D1B0
		public static Vector3IntProperty BindCustom(Animator animator, string name) => default; // 0x0000000189B5CF28-0x0000000189B5D038
		public Vector3Int Get(AnimationStream stream) => default; // 0x0000000189B5D1B0-0x0000000189B5D2A0
		public void Set(AnimationStream stream, Vector3Int value) {} // 0x0000000189B5D2A0-0x0000000189B5D378
	}

	public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool> // TypeDefIndex: 57815
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3BoolProperty Bind(Animator animator, Component component, string name) => default; // 0x0000000189B5CBE8-0x0000000189B5CD60
		public static Vector3BoolProperty BindCustom(Animator animator, string name) => default; // 0x0000000189B5CAD8-0x0000000189B5CBE8
		public Vector3Bool Get(AnimationStream stream) => default; // 0x0000000189B5CD60-0x0000000189B5CE50
		public void Set(AnimationStream stream, Vector3Bool value) {} // 0x0000000189B5CE50-0x0000000189B5CF28
	}

	public struct Vector4Property : IAnimatableProperty<Vector4> // TypeDefIndex: 57816
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
		public PropertyStreamHandle w; // 0x30
	
		// Methods
		public static Vector4Property Bind(Animator animator, Component component, string name) => default; // 0x0000000189B5D92C-0x0000000189B5DAF8
		public static Vector4Property BindCustom(Animator animator, string name) => default; // 0x0000000189B5D7DC-0x0000000189B5D92C
		public Vector4 Get(AnimationStream stream) => default; // 0x0000000189B5DAF8-0x0000000189B5DC44
		public void Set(AnimationStream stream, Vector4 value) {} // 0x0000000189B5DC44-0x0000000189B5DD60
	}

	public interface IAnimationJobBinder // TypeDefIndex: 57817
	{
		// Methods
		IAnimationJob Create(Animator animator, IAnimationJobData data, Component component = null);
		void Destroy(IAnimationJob job);
		void Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public abstract class AnimationJobBinder<TJob, TData> : IAnimationJobBinder // TypeDefIndex: 57818
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

	public interface IAnimationJobData // TypeDefIndex: 57819
	{
		// Methods
		bool IsValid();
		void SetDefaultValues();
	}

	public interface IWeightedAnimationJob : IAnimationJob // TypeDefIndex: 57820
	{
		// Properties
		FloatProperty jobWeight { get; set; }
	}

	[BurstCompile]
	public struct MultiAimConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57822
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x01FDA661
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
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76450-0x0000000183D76460 0x0000000183D76460-0x0000000183D76470
	
		// Nested types
		public enum WorldUpType // TypeDefIndex: 57821
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B50684-0x0000000189B515D4
		private Vector3 ComputeWorldUpVector(AnimationStream stream) => default; // 0x0000000189B50404-0x0000000189B50684
	}

	public interface IMultiAimConstraintData // TypeDefIndex: 57823
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

	public class MultiAimConstraintJobBinder<T> : AnimationJobBinder<MultiAimConstraintJob, T> // TypeDefIndex: 57824
		where T : struct, IAnimationJobData, IMultiAimConstraintData
	{
		// Constructors
		public MultiAimConstraintJobBinder() {}
	
		// Methods
		public override MultiAimConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiAimConstraintJob job) {}
	}

	[BurstCompile]
	public struct MultiParentConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57825
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x01FDA66A
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x28
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x38
		public NativeArray<AffineTransform> sourceOffsets; // 0x48
		public NativeArray<float> weightBuffer; // 0x58
		public Vector3 positionAxesMask; // 0x68
		public Vector3 rotationAxesMask; // 0x74
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D5AAF0-0x0000000183D5AB00 0x0000000183D68EB0-0x0000000183D68EC0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B51A08-0x0000000189B524D4
	}

	public interface IMultiParentConstraintData // TypeDefIndex: 57826
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

	public class MultiParentConstraintJobBinder<T> : AnimationJobBinder<MultiParentConstraintJob, T> // TypeDefIndex: 57827
		where T : struct, IAnimationJobData, IMultiParentConstraintData
	{
		// Constructors
		public MultiParentConstraintJobBinder() {}
	
		// Methods
		public override MultiParentConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiParentConstraintJob job) {}
	}

	[BurstCompile]
	public struct MultiPositionConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57828
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x01FDA66E
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Vector3> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76350-0x0000000183D76360 0x0000000183D76360-0x0000000183D76370
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B528D8-0x0000000189B52FD4
	}

	public interface IMultiPositionConstraintData // TypeDefIndex: 57829
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

	public class MultiPositionConstraintJobBinder<T> : AnimationJobBinder<MultiPositionConstraintJob, T> // TypeDefIndex: 57830
		where T : struct, IAnimationJobData, IMultiPositionConstraintData
	{
		// Constructors
		public MultiPositionConstraintJobBinder() {}
	
		// Methods
		public override MultiPositionConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiPositionConstraintJob job) {}
	}

	[BurstCompile]
	public struct MultiReferentialConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57831
	{
		// Fields
		public IntProperty driver; // 0x00
		public NativeArray<ReadWriteTransformHandle> sources; // 0x10
		public NativeArray<AffineTransform> sourceBindTx; // 0x20
		public NativeArray<AffineTransform> offsetTx; // 0x30
		private int m_PrevDriverIdx; // 0x40
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76190-0x0000000183D761A0 0x0000000183D761A0-0x0000000183D761B0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B5355C-0x0000000189B53A14
		internal void UpdateOffsets(int driver) {} // 0x0000000189B53A14-0x0000000189B53BAC
	}

	public interface IMultiReferentialConstraintData // TypeDefIndex: 57832
	{
		// Properties
		int driverValue { get; }
		string driverIntProperty { get; }
		Transform[] sourceObjects { get; }
	}

	public class MultiReferentialConstraintJobBinder<T> : AnimationJobBinder<MultiReferentialConstraintJob, T> // TypeDefIndex: 57833
		where T : struct, IAnimationJobData, IMultiReferentialConstraintData
	{
		// Constructors
		public MultiReferentialConstraintJobBinder() {}
	
		// Methods
		public override MultiReferentialConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiReferentialConstraintJob job) {}
	}

	[BurstCompile]
	public struct MultiRotationConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57834
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x01FDA672
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D76350-0x0000000183D76360 0x0000000183D76360-0x0000000183D76370
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B53EB8-0x0000000189B545A8
	}

	public interface IMultiRotationConstraintData // TypeDefIndex: 57835
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

	public class MultiRotationConstraintJobBinder<T> : AnimationJobBinder<MultiRotationConstraintJob, T> // TypeDefIndex: 57836
		where T : struct, IAnimationJobData, IMultiRotationConstraintData
	{
		// Constructors
		public MultiRotationConstraintJobBinder() {}
	
		// Methods
		public override MultiRotationConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(MultiRotationConstraintJob job) {}
	}

	[BurstCompile]
	public struct OverrideTransformJob : IWeightedAnimationJob // TypeDefIndex: 57838
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
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D75440-0x0000000183D75450 0x0000000183D754A0-0x0000000183D754B0
	
		// Nested types
		public enum Space // TypeDefIndex: 57837
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B54C74-0x0000000189B554D0
		internal void UpdateSpace(int space) {} // 0x0000000189B554D0-0x0000000189B55570
	}

	public interface IOverrideTransformData // TypeDefIndex: 57839
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

	public class OverrideTransformJobBinder<T> : AnimationJobBinder<OverrideTransformJob, T> // TypeDefIndex: 57840
		where T : struct, IAnimationJobData, IOverrideTransformData
	{
		// Constructors
		public OverrideTransformJobBinder() {}
	
		// Methods
		public override OverrideTransformJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(OverrideTransformJob job) {}
		public override void Update(OverrideTransformJob job, ref ref T data) {}
	}

	[BurstCompile]
	internal struct RigSyncSceneToStreamJob : IAnimationJob // TypeDefIndex: 57843
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
		public struct TransformSyncer : IDisposable // TypeDefIndex: 57841
		{
			// Fields
			public NativeArray<TransformSceneHandle> sceneHandles; // 0x00
			public NativeArray<TransformStreamHandle> streamHandles; // 0x10
	
			// Methods
			public static TransformSyncer Create(int size) => default; // 0x0000000189B5AF94-0x0000000189B5B044
			public void Dispose() {} // 0x0000000189B5B044-0x0000000189B5B0C0
			public void BindAt(int index, Animator animator, Transform transform) {} // 0x0000000189B5AF18-0x0000000189B5AF94
			public void Sync(ref AnimationStream stream) {} // 0x0000000189B5B0C0-0x0000000189B5B28C
		}
	
		internal struct PropertySyncer : IDisposable // TypeDefIndex: 57842
		{
			// Fields
			public NativeArray<PropertySceneHandle> sceneHandles; // 0x00
			public NativeArray<PropertyStreamHandle> streamHandles; // 0x10
			public NativeArray<float> buffer; // 0x20
	
			// Methods
			public static PropertySyncer Create(int size) => default; // 0x0000000189B5570C-0x0000000189B557FC
			public void Dispose() {} // 0x0000000189B557FC-0x0000000189B558A8
			public void BindAt(int index, Animator animator, Component component, string property) {} // 0x0000000189B55640-0x0000000189B5570C
			public void Sync(ref AnimationStream stream) {} // 0x0000000189B55924-0x0000000189B559EC
			public NativeArray<float> StreamValues(ref AnimationStream stream) => default; // 0x0000000189B558A8-0x0000000189B55924
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B58540-0x0000000189B5868C
	}

	internal struct SyncableProperties // TypeDefIndex: 57844
	{
		// Fields
		public RigProperties rig; // 0x00
		public ConstraintProperties[] constraints; // 0x08
	}

	internal interface IRigSyncSceneToStreamData // TypeDefIndex: 57845
	{
		// Properties
		Transform[] syncableTransforms { get; }
		SyncableProperties[] syncableProperties { get; }
		bool[] rigStates { get; }
	}

	internal class RigSyncSceneToStreamJobBinder<T> : AnimationJobBinder<RigSyncSceneToStreamJob, T> // TypeDefIndex: 57846
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

	public struct ReadWriteTransformHandle // TypeDefIndex: 57847
	{
		// Fields
		private TransformStreamHandle m_Handle; // 0x00
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x0000000189B5640C-0x0000000189B56464
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x0000000189B56464-0x0000000189B564B4
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x0000000189B564B4-0x0000000189B5650C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189B5650C-0x0000000189B5655C
		public void SetLocalPosition(AnimationStream stream, Vector3 position) {} // 0x0000000189B56730-0x0000000189B56784
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation) {} // 0x0000000189B56784-0x0000000189B567CC
		public void SetLocalScale(AnimationStream stream, Vector3 scale) {} // 0x0000000189B567CC-0x0000000189B56820
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false /* Metadata: 0x01FDA679 */) {} // 0x0000000189B56820-0x0000000189B568AC
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x0000000189B5655C-0x0000000189B565B4
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x0000000189B565B4-0x0000000189B56604
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189B563C8-0x0000000189B5640C
		public void SetPosition(AnimationStream stream, Vector3 position) {} // 0x0000000189B568AC-0x0000000189B56900
		public void SetRotation(AnimationStream stream, Quaternion rotation) {} // 0x0000000189B56900-0x0000000189B56948
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false /* Metadata: 0x01FDA67A */) {} // 0x0000000189B566B8-0x0000000189B56730
		public bool IsResolved(AnimationStream stream) => default; // 0x0000000189B56604-0x0000000189B56640
		public bool IsValid(AnimationStream stream) => default; // 0x0000000189B56640-0x0000000189B5667C
		public void Resolve(AnimationStream stream) {} // 0x0000000189B5667C-0x0000000189B566B8
		public static ReadWriteTransformHandle Bind(Animator animator, Transform transform) => default; // 0x0000000189B56234-0x0000000189B563C8
	}

	public struct ReadOnlyTransformHandle // TypeDefIndex: 57848
	{
		// Fields
		private TransformStreamHandle m_StreamHandle; // 0x00
		private TransformSceneHandle m_SceneHandle; // 0x0C
		private byte m_InStream; // 0x14
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream) => default; // 0x0000000189B55EBC-0x0000000189B55F34
		public Quaternion GetLocalRotation(AnimationStream stream) => default; // 0x0000000189B55F34-0x0000000189B55FA4
		public Vector3 GetLocalScale(AnimationStream stream) => default; // 0x0000000189B55FA4-0x0000000189B5601C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale) {
			position = default;
			rotation = default;
			scale = default;
		} // 0x0000000189B5601C-0x0000000189B56078
		public Vector3 GetPosition(AnimationStream stream) => default; // 0x0000000189B56078-0x0000000189B560F0
		public Quaternion GetRotation(AnimationStream stream) => default; // 0x0000000189B560F0-0x0000000189B56160
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000189B55E70-0x0000000189B55EBC
		public bool IsResolved(AnimationStream stream) => default; // 0x0000000189B56160-0x0000000189B561A4
		public bool IsValid(AnimationStream stream) => default; // 0x0000000189B561A4-0x0000000189B561F0
		public void Resolve(AnimationStream stream) {} // 0x0000000189B561F0-0x0000000189B56234
		public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform) => default; // 0x0000000189B55D24-0x0000000189B55E70
	}

	[BurstCompile]
	public struct TwistChainConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57849
	{
		// Fields
		public ReadWriteTransformHandle rootTarget; // 0x00
		public ReadWriteTransformHandle tipTarget; // 0x0C
		public NativeArray<ReadWriteTransformHandle> chain; // 0x18
		public NativeArray<float> steps; // 0x28
		public NativeArray<float> weights; // 0x38
		public NativeArray<Quaternion> rotations; // 0x48
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D50820-0x0000000183D50830 0x0000000183D71980-0x0000000183D71990
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B5B3E0-0x0000000189B5B8D8
	}

	public interface ITwistChainConstraintData // TypeDefIndex: 57850
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform rootTarget { get; }
		Transform tipTarget { get; }
		AnimationCurve curve { get; }
	}

	public class TwistChainConstraintJobBinder<T> : AnimationJobBinder<TwistChainConstraintJob, T> // TypeDefIndex: 57851
		where T : struct, IAnimationJobData, ITwistChainConstraintData
	{
		// Constructors
		public TwistChainConstraintJobBinder() {}
	
		// Methods
		public override TwistChainConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwistChainConstraintJob job) {}
	}

	[BurstCompile]
	public struct TwistCorrectionJob : IWeightedAnimationJob // TypeDefIndex: 57852
	{
		// Fields
		public ReadOnlyTransformHandle source; // 0x00
		public Quaternion sourceInverseBindRotation; // 0x18
		public Vector3 axisMask; // 0x28
		public NativeArray<ReadWriteTransformHandle> twistTransforms; // 0x38
		public NativeArray<PropertyStreamHandle> twistWeights; // 0x48
		public NativeArray<Quaternion> twistBindRotations; // 0x58
		public NativeArray<float> weightBuffer; // 0x68
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D58660-0x0000000183D58670 0x0000000183D6C700-0x0000000183D6C710
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B5BB2C-0x0000000189B5BEE8
		private static Quaternion TwistRotation(Vector3 axis, Quaternion rot) => default; // 0x0000000183D764A0-0x0000000183D764E0
	}

	public interface ITwistCorrectionData // TypeDefIndex: 57853
	{
		// Properties
		Transform source { get; }
		WeightedTransformArray twistNodes { get; }
		Vector3 twistAxis { get; }
		string twistNodesProperty { get; }
	}

	public class TwistCorrectionJobBinder<T> : AnimationJobBinder<TwistCorrectionJob, T> // TypeDefIndex: 57854
		where T : struct, IAnimationJobData, ITwistCorrectionData
	{
		// Constructors
		public TwistCorrectionJobBinder() {}
	
		// Methods
		public override TwistCorrectionJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwistCorrectionJob job) {}
	}

	[BurstCompile]
	public struct TwoBoneIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 57855
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
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] get; set; } // 0x0000000183D6C070-0x0000000183D6C080 0x0000000183D6C0F0-0x0000000183D6C100
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000189B5C28C-0x0000000189B5C62C
	}

	public interface ITwoBoneIKConstraintData // TypeDefIndex: 57856
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

	public class TwoBoneIKConstraintJobBinder<T> : AnimationJobBinder<TwoBoneIKConstraintJob, T> // TypeDefIndex: 57857
		where T : struct, IAnimationJobData, ITwoBoneIKConstraintData
	{
		// Constructors
		public TwoBoneIKConstraintJobBinder() {}
	
		// Methods
		public override TwoBoneIKConstraintJob Create(Animator animator, ref ref T data, Component component) => default;
		public override void Destroy(TwoBoneIKConstraintJob job) {}
	}

	public class WeightedTransformArrayBinder // TypeDefIndex: 57858
	{
		// Constructors
		public WeightedTransformArrayBinder() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle> transforms) {
			transforms = default;
		} // 0x0000000189B5DD60-0x0000000189B5DE74
		public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle> transforms) {
			transforms = default;
		} // 0x0000000189B5DE74-0x0000000189B5DF84
		public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle> weights) {
			weights = default;
		} // 0x0000000189B5DF84-0x0000000189B5E114
	}

	[Serializable]
	public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData // TypeDefIndex: 57859
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_SourceA; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_SourceB; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private bool m_BlendPosition; // 0x18
		[SerializeField]
		[SyncSceneToStream]
		private bool m_BlendRotation; // 0x19
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_PositionWeight; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_RotationWeight; // 0x20
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffsets; // 0x24
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffsets; // 0x25
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform sourceObjectA { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Transform sourceObjectB { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool blendPosition { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool blendRotation { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public float positionWeight { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000184270578-0x0000000184270590
		public float rotationWeight { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x00000001889D3648-0x00000001889D3660
		public bool maintainPositionOffsets { get => default; set {} } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
		public bool maintainRotationOffsets { get => default; set {} } // 0x0000000183D4F130-0x0000000183D4F140 0x0000000183D4F150-0x0000000183D4F160
		string IBlendConstraintData.blendPositionBoolProperty { get => default; } // 0x0000000189B4DA30-0x0000000189B4DA64 
		string IBlendConstraintData.blendRotationBoolProperty { get => default; } // 0x0000000189B4DA64-0x0000000189B4DA98 
		string IBlendConstraintData.positionWeightFloatProperty { get => default; } // 0x0000000189B4DA98-0x0000000189B4DACC 
		string IBlendConstraintData.rotationWeightFloatProperty { get => default; } // 0x0000000189B4DACC-0x0000000189B4DB00 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B4D94C-0x0000000189B4D9E4
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B4D9E4-0x0000000189B4DA30
	}

	[AddComponentMenu("Animation Rigging/Blend Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/BlendConstraint.html")]
	public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder<BlendConstraintData>> // TypeDefIndex: 57860
	{
		// Constructors
		public BlendConstraint() {} // 0x0000000189B4E0E8-0x0000000189B4E13C
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B4E084-0x0000000189B4E0E8
	}

	[Serializable]
	public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData // TypeDefIndex: 57861
	{
		// Fields
		internal const int k_MinIterations = 1; // Metadata: 0x01FDA67B
		internal const int k_MaxIterations = 50; // Metadata: 0x01FDA67C
		internal const float k_MinTolerance = 0f; // Metadata: 0x01FDA67D
		internal const float k_MaxTolerance = 0.01f; // Metadata: 0x01FDA681
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Tip; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Target; // 0x10
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_ChainRotationWeight; // 0x18
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TipRotationWeight; // 0x1C
		[NotKeyable]
		[Range(1f, 50f)]
		[SerializeField]
		private int m_MaxIterations; // 0x20
		[NotKeyable]
		[Range(0f, 0.01f)]
		[SerializeField]
		private float m_Tolerance; // 0x24
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetPositionOffset; // 0x28
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetRotationOffset; // 0x29
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform tip { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Transform target { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public float chainRotationWeight { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000187B4A6B8-0x0000000187B4A6EC
		public float tipRotationWeight { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000184270578-0x0000000184270590
		public int maxIterations { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000189B4E4A8-0x0000000189B4E4C8
		public float tolerance { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000189B4E4C8-0x0000000189B4E4EC
		public bool maintainTargetPositionOffset { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool maintainTargetRotationOffset { get => default; set {} } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		string IChainIKConstraintData.chainRotationWeightFloatProperty { get => default; } // 0x0000000189B4E440-0x0000000189B4E474 
		string IChainIKConstraintData.tipRotationWeightFloatProperty { get => default; } // 0x0000000189B4E474-0x0000000189B4E4A8 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B4E2A8-0x0000000189B4E3EC
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B4E3EC-0x0000000189B4E440
	}

	[AddComponentMenu("Animation Rigging/Chain IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/ChainIKConstraint.html")]
	public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder<ChainIKConstraintData>> // TypeDefIndex: 57862
	{
		// Constructors
		public ChainIKConstraint() {} // 0x0000000189B4ECB4-0x0000000189B4ED08
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B4EC00-0x0000000189B4ECB4
	}

	[Serializable]
	public struct DampedTransformData : IAnimationJobData, IDampedTransformData // TypeDefIndex: 57863
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Source; // 0x08
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_DampPosition; // 0x10
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_DampRotation; // 0x14
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainAim; // 0x18
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform sourceObject { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public float dampPosition { get => default; set {} } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000189B4F338-0x0000000189B4F350
		public float dampRotation { get => default; set {} } // 0x0000000183D51930-0x0000000183D51940 0x0000000189B4F350-0x0000000189B4F368
		public bool maintainAim { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		string IDampedTransformData.dampPositionFloatProperty { get => default; } // 0x0000000189B4F2D0-0x0000000189B4F304 
		string IDampedTransformData.dampRotationFloatProperty { get => default; } // 0x0000000189B4F304-0x0000000189B4F338 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B4F21C-0x0000000189B4F294
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B4F294-0x0000000189B4F2D0
	}

	[AddComponentMenu("Animation Rigging/Damped Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/DampedTransform.html")]
	public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder<DampedTransformData>> // TypeDefIndex: 57864
	{
		// Constructors
		public DampedTransform() {} // 0x0000000189B4FB74-0x0000000189B4FBC8
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B4FB10-0x0000000189B4FB74
	}

	[Serializable]
	public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData // TypeDefIndex: 57867
	{
		// Fields
		internal const float k_MinAngularLimit = -180f; // Metadata: 0x01FDA685
		internal const float k_MaxAngularLimit = 180f; // Metadata: 0x01FDA689
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[Range(-180f, 180f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_MinLimit; // 0x9C
		[Range(-180f, 180f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_MaxLimit; // 0xA0
		[NotKeyable]
		[SerializeField]
		private Axis m_AimAxis; // 0xA4
		[NotKeyable]
		[SerializeField]
		private Axis m_UpAxis; // 0xA8
		[NotKeyable]
		[SerializeField]
		private WorldUpType m_WorldUpType; // 0xAC
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_WorldUpObject; // 0xB0
		[NotKeyable]
		[SerializeField]
		private Axis m_WorldUpAxis; // 0xB8
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0xBC
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0xBD
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000183D763C0-0x0000000183D76420 0x0000000189B503A0-0x0000000189B50404
		public bool maintainOffset { get => default; set {} } // 0x0000000183D5B230-0x0000000183D5B240 0x0000000183D5B240-0x0000000183D5B250
		public Vector3 offset { get => default; set {} } // 0x0000000183D5B810-0x0000000183D5B830 0x0000000183D5E1E0-0x0000000183D5E200
		public Vector2 limits { get => default; set {} } // 0x0000000183D738E0-0x0000000183D73900 0x0000000189B50340-0x0000000189B503A0
		public Axis aimAxis { get => default; set {} } // 0x0000000183D51870-0x0000000183D51880 0x0000000183D518B0-0x0000000183D518C0
		public Axis upAxis { get => default; set {} } // 0x0000000183D51860-0x0000000183D51870 0x0000000183D518A0-0x0000000183D518B0
		public WorldUpType worldUpType { get => default; set {} } // 0x0000000183D51880-0x0000000183D51890 0x0000000183D518C0-0x0000000183D518D0
		public Axis worldUpAxis { get => default; set {} } // 0x0000000183D57DA0-0x0000000183D57DB0 0x0000000183D57DC0-0x0000000183D57DD0
		public Transform worldUpObject { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		public bool constrainedXAxis { get => default; set {} } // 0x0000000183D76390-0x0000000183D763A0 0x0000000183D76420-0x0000000183D76430
		public bool constrainedYAxis { get => default; set {} } // 0x0000000183D763A0-0x0000000183D763B0 0x0000000183D76430-0x0000000183D76440
		public bool constrainedZAxis { get => default; set {} } // 0x0000000183D763B0-0x0000000183D763C0 0x0000000183D76440-0x0000000183D76450
		Vector3 IMultiAimConstraintData.aimAxis { get => default; } // 0x0000000189B501D4-0x0000000189B50208 
		Vector3 IMultiAimConstraintData.upAxis { get => default; } // 0x0000000189B502D8-0x0000000189B5030C 
		int IMultiAimConstraintData.worldUpType { get => default; } // 0x0000000183D51880-0x0000000183D51890 
		Vector3 IMultiAimConstraintData.worldUpAxis { get => default; } // 0x0000000189B5030C-0x0000000189B50340 
		string IMultiAimConstraintData.offsetVector3Property { get => default; } // 0x0000000189B50270-0x0000000189B502A4 
		string IMultiAimConstraintData.minLimitFloatProperty { get => default; } // 0x0000000189B5023C-0x0000000189B50270 
		string IMultiAimConstraintData.maxLimitFloatProperty { get => default; } // 0x0000000189B50208-0x0000000189B5023C 
		string IMultiAimConstraintData.sourceObjectsProperty { get => default; } // 0x0000000189B502A4-0x0000000189B502D8 
	
		// Nested types
		public enum Axis // TypeDefIndex: 57865
		{
			X = 0,
			X_NEG = 1,
			Y = 2,
			Y_NEG = 3,
			Z = 4,
			Z_NEG = 5
		}
	
		public enum WorldUpType // TypeDefIndex: 57866
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B4FF7C-0x0000000189B50100
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B50100-0x0000000189B501D4
		private static Vector3 Convert(Axis axis) => default; // 0x0000000189B4FF10-0x0000000189B4FF7C
	}

	[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiAimConstraint.html")]
	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>> // TypeDefIndex: 57868
	{
		// Constructors
		public MultiAimConstraint() {} // 0x0000000189B51778-0x0000000189B517CC
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B515D4-0x0000000189B51778
	}

	[Serializable]
	public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData // TypeDefIndex: 57869
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedPositionAxes; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedRotationAxes; // 0x93
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffset; // 0x96
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffset; // 0x97
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000183D763C0-0x0000000183D76420 0x0000000189B503A0-0x0000000189B50404
		public bool maintainPositionOffset { get => default; set {} } // 0x0000000183D52040-0x0000000183D52050 0x0000000183D6C5E0-0x0000000183D6C5F0
		public bool maintainRotationOffset { get => default; set {} } // 0x0000000183D76470-0x0000000183D76480 0x0000000183D76490-0x0000000183D764A0
		public bool constrainedPositionXAxis { get => default; set {} } // 0x0000000183D58A70-0x0000000183D58A80 0x0000000183D58AB0-0x0000000183D58AC0
		public bool constrainedPositionYAxis { get => default; set {} } // 0x0000000183D50B80-0x0000000183D50B90 0x0000000183D50BA0-0x0000000183D50BB0
		public bool constrainedPositionZAxis { get => default; set {} } // 0x0000000183D50B90-0x0000000183D50BA0 0x0000000183D50BB0-0x0000000183D50BC0
		public bool constrainedRotationXAxis { get => default; set {} } // 0x0000000183D75420-0x0000000183D75430 0x0000000183D75BF0-0x0000000183D75C00
		public bool constrainedRotationYAxis { get => default; set {} } // 0x0000000183D6CD80-0x0000000183D6CD90 0x0000000183D6CD90-0x0000000183D6CDA0
		public bool constrainedRotationZAxis { get => default; set {} } // 0x0000000183D52050-0x0000000183D52060 0x0000000183D76480-0x0000000183D76490
		string IMultiParentConstraintData.sourceObjectsProperty { get => default; } // 0x0000000189B519D4-0x0000000189B51A08 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B517CC-0x0000000189B51950
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B51950-0x0000000189B519D4
	}

	[AddComponentMenu("Animation Rigging/Multi-Parent Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiParentConstraint.html")]
	public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder<MultiParentConstraintData>> // TypeDefIndex: 57870
	{
		// Constructors
		public MultiParentConstraint() {} // 0x0000000189B52610-0x0000000189B52664
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B524D4-0x0000000189B52610
	}

	[Serializable]
	public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData // TypeDefIndex: 57871
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000183D763C0-0x0000000183D76420 0x0000000189B503A0-0x0000000189B50404
		public bool maintainOffset { get => default; set {} } // 0x0000000183D6E0A0-0x0000000183D6E0B0 0x0000000183D6E0F0-0x0000000183D6E100
		public Vector3 offset { get => default; set {} } // 0x0000000183D5B810-0x0000000183D5B830 0x0000000183D5E1E0-0x0000000183D5E200
		public bool constrainedXAxis { get => default; set {} } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		public bool constrainedYAxis { get => default; set {} } // 0x0000000183D6E090-0x0000000183D6E0A0 0x0000000183D6E0E0-0x0000000183D6E0F0
		public bool constrainedZAxis { get => default; set {} } // 0x0000000183D6E0B0-0x0000000183D6E0C0 0x0000000183D6E100-0x0000000183D6E110
		string IMultiPositionConstraintData.offsetVector3Property { get => default; } // 0x0000000189B52870-0x0000000189B528A4 
		string IMultiPositionConstraintData.sourceObjectsProperty { get => default; } // 0x0000000189B528A4-0x0000000189B528D8 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B52664-0x0000000189B527E8
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B527E8-0x0000000189B52870
	}

	[AddComponentMenu("Animation Rigging/Multi-Position Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiPositionConstraint.html")]
	public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder<MultiPositionConstraintData>> // TypeDefIndex: 57872
	{
		// Constructors
		public MultiPositionConstraint() {} // 0x0000000189B53110-0x0000000189B53164
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B52FD4-0x0000000189B53110
	}

	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData // TypeDefIndex: 57873
	{
		// Fields
		[SerializeField]
		[SyncSceneToStream]
		private int m_Driver; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private List<Transform> m_SourceObjects; // 0x08
	
		// Properties
		public int driver { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000189B53490-0x0000000189B534EC
		public List<Transform> sourceObjects { get => default; set {} } // 0x0000000189B5340C-0x0000000189B53490 0x0000000189B534EC-0x0000000189B5355C
		Transform[] IMultiReferentialConstraintData.sourceObjects { get => default; } // 0x0000000189B53374-0x0000000189B533BC 
		int IMultiReferentialConstraintData.driverValue { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		string IMultiReferentialConstraintData.driverIntProperty { get => default; } // 0x0000000189B53340-0x0000000189B53374 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B53164-0x0000000189B532C8
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B532C8-0x0000000189B53340
		public void UpdateDriver() {} // 0x0000000189B533BC-0x0000000189B5340C
	}

	[AddComponentMenu("Animation Rigging/Multi-Referential Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiReferentialConstraint.html")]
	public class MultiReferentialConstraint : RigConstraint<MultiReferentialConstraintJob, MultiReferentialConstraintData, MultiReferentialConstraintJobBinder<MultiReferentialConstraintData>> // TypeDefIndex: 57874
	{
		// Constructors
		public MultiReferentialConstraint() {} // 0x0000000189B53BF0-0x0000000189B53C44
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B53BAC-0x0000000189B53BF0
	}

	[Serializable]
	public struct MultiRotationConstraintData : IAnimationJobData, IMultiRotationConstraintData // TypeDefIndex: 57875
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_Offset; // 0x90
		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes; // 0x9C
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset; // 0x9F
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public WeightedTransformArray sourceObjects { get => default; set {} } // 0x0000000183D763C0-0x0000000183D76420 0x0000000189B503A0-0x0000000189B50404
		public bool maintainOffset { get => default; set {} } // 0x0000000183D6E0A0-0x0000000183D6E0B0 0x0000000183D6E0F0-0x0000000183D6E100
		public Vector3 offset { get => default; set {} } // 0x0000000183D5B810-0x0000000183D5B830 0x0000000183D5E1E0-0x0000000183D5E200
		public bool constrainedXAxis { get => default; set {} } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		public bool constrainedYAxis { get => default; set {} } // 0x0000000183D6E090-0x0000000183D6E0A0 0x0000000183D6E0E0-0x0000000183D6E0F0
		public bool constrainedZAxis { get => default; set {} } // 0x0000000183D6E0B0-0x0000000183D6E0C0 0x0000000183D6E100-0x0000000183D6E110
		string IMultiRotationConstraintData.offsetVector3Property { get => default; } // 0x0000000189B53E50-0x0000000189B53E84 
		string IMultiRotationConstraintData.sourceObjectsProperty { get => default; } // 0x0000000189B53E84-0x0000000189B53EB8 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B53C44-0x0000000189B53DC8
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B53DC8-0x0000000189B53E50
	}

	[AddComponentMenu("Animation Rigging/Multi-Rotation Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiRotationConstraint.html")]
	public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder<MultiRotationConstraintData>> // TypeDefIndex: 57876
	{
		// Constructors
		public MultiRotationConstraint() {} // 0x0000000189B546E4-0x0000000189B54738
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B545A8-0x0000000189B546E4
	}

	[Serializable]
	public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData // TypeDefIndex: 57878
	{
		// Fields
		[SerializeField]
		private Transform m_ConstrainedObject; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_OverrideSource; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_OverridePosition; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Vector3 m_OverrideRotation; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_PositionWeight; // 0x28
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_RotationWeight; // 0x2C
		[NotKeyable]
		[SerializeField]
		private Space m_Space; // 0x30
	
		// Properties
		public Transform constrainedObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform sourceObject { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Space space { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public Vector3 position { get => default; set {} } // 0x0000000183D55550-0x0000000183D55570 0x0000000183D55570-0x0000000183D55580
		public Vector3 rotation { get => default; set {} } // 0x0000000183D568F0-0x0000000183D56910 0x0000000183D5CBC0-0x0000000183D5CBD0
		public float positionWeight { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000189B54C44-0x0000000189B54C5C
		public float rotationWeight { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000189B54C5C-0x0000000189B54C74
		int IOverrideTransformData.space { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		string IOverrideTransformData.positionWeightFloatProperty { get => default; } // 0x0000000189B54BA8-0x0000000189B54BDC 
		string IOverrideTransformData.rotationWeightFloatProperty { get => default; } // 0x0000000189B54C10-0x0000000189B54C44 
		string IOverrideTransformData.positionVector3Property { get => default; } // 0x0000000189B54B74-0x0000000189B54BA8 
		string IOverrideTransformData.rotationVector3Property { get => default; } // 0x0000000189B54BDC-0x0000000189B54C10 
	
		// Nested types
		[Serializable]
		public enum Space // TypeDefIndex: 57877
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B54AB4-0x0000000189B54B04
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B54B04-0x0000000189B54B74
	}

	[AddComponentMenu("Animation Rigging/Override Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/OverrideTransform.html")]
	public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder<OverrideTransformData>> // TypeDefIndex: 57879
	{
		// Constructors
		public OverrideTransform() {} // 0x0000000189B555D4-0x0000000189B55628
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B55570-0x0000000189B555D4
	}

	[Serializable]
	public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData // TypeDefIndex: 57880
	{
		// Fields
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Tip; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_RootTarget; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_TipTarget; // 0x18
		[SerializeField]
		private AnimationCurve m_Curve; // 0x20
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform tip { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Transform rootTarget { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Transform tipTarget { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public AnimationCurve curve { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B5B28C-0x0000000189B5B374
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B5B374-0x0000000189B5B3E0
	}

	[AddComponentMenu("Animation Rigging/Twist Chain Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistChainConstraint.html")]
	public class TwistChainConstraint : RigConstraint<TwistChainConstraintJob, TwistChainConstraintData, TwistChainConstraintJobBinder<TwistChainConstraintData>> // TypeDefIndex: 57881
	{
		// Constructors
		public TwistChainConstraint() {} // 0x0000000189B5B8D8-0x0000000189B5B92C
	}

	[Serializable]
	public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData // TypeDefIndex: 57883
	{
		// Fields
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Source; // 0x00
		[NotKeyable]
		[SerializeField]
		private Axis m_TwistAxis; // 0x08
		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(-1f, 1f)]
		private WeightedTransformArray m_TwistNodes; // 0x10
	
		// Properties
		public Transform sourceObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public WeightedTransformArray twistNodes { get => default; set {} } // 0x0000000183D62BB0-0x0000000183D62C10 0x0000000189B5BAC8-0x0000000189B5BB2C
		public Axis twistAxis { get => default; set {} } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		Transform ITwistCorrectionData.source { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		Vector3 ITwistCorrectionData.twistAxis { get => default; } // 0x0000000189B5BA64-0x0000000189B5BA94 
		string ITwistCorrectionData.twistNodesProperty { get => default; } // 0x0000000189B5BA94-0x0000000189B5BAC8 
	
		// Nested types
		public enum Axis // TypeDefIndex: 57882
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Methods
		private static Vector3 Convert(Axis axis) => default; // 0x00000001895F5C38-0x00000001895F5C78
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B5B92C-0x0000000189B5BA04
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B5BA04-0x0000000189B5BA64
	}

	[AddComponentMenu("Animation Rigging/Twist Correction")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistCorrection.html")]
	public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder<TwistCorrectionData>> // TypeDefIndex: 57884
	{
		// Constructors
		public TwistCorrection() {} // 0x0000000189B5C02C-0x0000000189B5C080
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B5BEE8-0x0000000189B5C02C
	}

	[Serializable]
	public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData // TypeDefIndex: 57885
	{
		// Fields
		[SerializeField]
		private Transform m_Root; // 0x00
		[SerializeField]
		private Transform m_Mid; // 0x08
		[SerializeField]
		private Transform m_Tip; // 0x10
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Target; // 0x18
		[SerializeField]
		[SyncSceneToStream]
		private Transform m_Hint; // 0x20
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TargetPositionWeight; // 0x28
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_TargetRotationWeight; // 0x2C
		[Range(0f, 1f)]
		[SerializeField]
		[SyncSceneToStream]
		private float m_HintWeight; // 0x30
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetPositionOffset; // 0x34
		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetRotationOffset; // 0x35
	
		// Properties
		public Transform root { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform mid { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Transform tip { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Transform target { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Transform hint { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public float targetPositionWeight { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000189B54C44-0x0000000189B54C5C
		public float targetRotationWeight { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000189B54C5C-0x0000000189B54C74
		public float hintWeight { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000189B5C274-0x0000000189B5C28C
		public bool maintainTargetPositionOffset { get => default; set {} } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
		public bool maintainTargetRotationOffset { get => default; set {} } // 0x0000000183D4F560-0x0000000183D4F570 0x0000000183D4F580-0x0000000183D4F590
		string ITwoBoneIKConstraintData.targetPositionWeightFloatProperty { get => default; } // 0x0000000189B5C20C-0x0000000189B5C240 
		string ITwoBoneIKConstraintData.targetRotationWeightFloatProperty { get => default; } // 0x0000000189B5C240-0x0000000189B5C274 
		string ITwoBoneIKConstraintData.hintWeightFloatProperty { get => default; } // 0x0000000189B5C1D8-0x0000000189B5C20C 
	
		// Methods
		bool IAnimationJobData.IsValid() => default; // 0x0000000189B5C080-0x0000000189B5C174
		void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B5C174-0x0000000189B5C1D8
	}

	[AddComponentMenu("Animation Rigging/Two Bone IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwoBoneIKConstraint.html")]
	public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder<TwoBoneIKConstraintData>> // TypeDefIndex: 57886
	{
		// Constructors
		public TwoBoneIKConstraint() {} // 0x0000000189B5C6A4-0x0000000189B5C6F8
	
		// Methods
		protected override void OnValidate() {} // 0x0000000189B5C62C-0x0000000189B5C6A4
	}

	public interface IRigConstraint // TypeDefIndex: 57887
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

	public interface IRigLayer // TypeDefIndex: 57888
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

	public class OverrideRigConstraint<TConstraint, TJob, TData, TBinder> : IRigConstraint // TypeDefIndex: 57889
		where TConstraint : MonoBehaviour, IRigConstraint
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		[SerializeField]
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
	public class OverrideRigLayer : IRigLayer // TypeDefIndex: 57890
	{
		// Fields
		[FormerlySerializedAs("rig")]
		[SerializeField]
		private Rig m_Rig; // 0x10
		[FormerlySerializedAs("active")]
		[SerializeField]
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
	
		// Properties
		public Rig rig { get => default; private set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool active { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public string name { get => default; } // 0x0000000189B54A24-0x0000000189B54AB4 
		public IRigConstraint[] constraints { get => default; } // 0x0000000189B54A04-0x0000000189B54A14 
		public IAnimationJob[] jobs { get => default; } // 0x0000000189B54A14-0x0000000189B54A24 
		public bool isInitialized { get; private set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
	
		// Constructors
		public OverrideRigLayer() {} // Dummy constructor
		public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true /* Metadata: 0x01FDA69E */) {} // 0x0000000189B549D4-0x0000000189B54A04
	
		// Methods
		public bool Initialize(Animator animator) => default; // 0x0000000189B54738-0x0000000189B54868
		public void Update() {} // 0x0000000189B54968-0x0000000189B549D4
		public void Reset() {} // 0x0000000189B548C4-0x0000000189B54968
		public bool IsValid() => default; // 0x0000000189B54868-0x0000000189B548C4
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-component")]
	public class Rig : MonoBehaviour, IRigEffectorHolder // TypeDefIndex: 57891
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Weight; // 0x18
		[SerializeField]
		private List<RigEffectorData> m_Effectors; // 0x20
	
		// Properties
		public float weight { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000187B4A6B8-0x0000000187B4A6EC
	
		// Constructors
		public Rig() {} // 0x0000000189B5A9D4-0x0000000189B5AA5C
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Builder")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-builder-component")]
	[RequireComponent(typeof(Animator))]
	public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder // TypeDefIndex: 57894
	{
		// Fields
		[SerializeField]
		private List<RigLayer> m_RigLayers; // 0x18
		private IRigLayer[] m_RuntimeRigLayers; // 0x20
		private SyncSceneToStreamLayer m_SyncSceneToStreamLayer; // 0x28
		[SerializeField]
		private List<RigEffectorData> m_Effectors; // 0x30
		public static OnAddRigBuilderCallback onAddRigBuilder; // 0x00
		public static OnRemoveRigBuilderCallback onRemoveRigBuilder; // 0x08
	
		// Properties
		public List<RigLayer> layers { get => default; set {} } // 0x0000000189B57DC4-0x0000000189B57E48 0x00000001822C3A90-0x00000001822C3AA0
		private SyncSceneToStreamLayer syncSceneToStreamLayer { get => default; set {} } // 0x0000000189B57E48-0x0000000189B57EA4 0x0000000182C92F10-0x0000000182C92F20
		public PlayableGraph graph { get; private set; } // 0x0000000183D5A120-0x0000000183D5A130 0x0000000183D5C3C0-0x0000000183D5C3D0
	
		// Nested types
		public delegate void OnAddRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 57892; 0x0000000182149960-0x0000000182149970
	
		public delegate void OnRemoveRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 57893; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public RigBuilder() {} // 0x0000000189B57D44-0x0000000189B57DC4
	
		// Methods
		private void OnEnable() {} // 0x0000000189B57A0C-0x0000000189B57A70
		private void OnDisable() {} // 0x0000000189B579A4-0x0000000189B57A0C
		private void OnDestroy() {} // 0x0000000189B5799C-0x0000000189B579A4
		private void Update() {} // 0x0000000189B57C50-0x0000000189B57D44
		public bool Build() => default; // 0x0000000189B5770C-0x0000000189B57884
		public void Clear() {} // 0x0000000189B57884-0x0000000189B5799C
		public void StartPreview() {} // 0x0000000189B57A70-0x0000000189B57B70
		public void StopPreview() {} // 0x0000000189B57B70-0x0000000189B57BA4
		public void UpdatePreviewGraph(PlayableGraph graph) {} // 0x0000000189B57BA4-0x0000000189B57C50
		public Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable) => default; // 0x0000000189B57450-0x0000000189B5770C
	}

	internal static class RigBuilderUtils // TypeDefIndex: 57896
	{
		// Fields
		private static readonly ushort k_AnimationOutputPriority; // 0x00
	
		// Nested types
		public struct PlayableChain // TypeDefIndex: 57895
		{
			// Fields
			public string name; // 0x00
			public Playable[] playables; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x0000000189B55628-0x0000000189B55640
		}
	
		// Constructors
		static RigBuilderUtils() {} // 0x0000000189B57418-0x0000000189B57450
	
		// Methods
		public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer) => default; // 0x0000000189B571F0-0x0000000189B57418
		public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) => default; // 0x0000000189B56C98-0x0000000189B571F0
		public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer) => default; // 0x0000000189B56948-0x0000000189B56C98
	}

	public class RigConstraint<TJob, TData, TBinder> : MonoBehaviour, IRigConstraint // TypeDefIndex: 57897
		where TJob : struct, IWeightedAnimationJob
		where TData : struct, IAnimationJobData
		where TBinder : AnimationJobBinder<TJob, TData>, new()
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		protected float m_Weight;
		[ExpandChildren]
		[SerializeField]
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
	public class RigLayer : IRigLayer // TypeDefIndex: 57898
	{
		// Fields
		[FormerlySerializedAs("rig")]
		[SerializeField]
		private Rig m_Rig; // 0x10
		[FormerlySerializedAs("active")]
		[SerializeField]
		private bool m_Active; // 0x18
		private IRigConstraint[] m_Constraints; // 0x20
		private IAnimationJob[] m_Jobs; // 0x28
	
		// Properties
		public Rig rig { get => default; private set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool active { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public string name { get => default; } // 0x0000000189B58144-0x0000000189B581D4 
		public IRigConstraint[] constraints { get => default; } // 0x0000000189B54A04-0x0000000189B54A14 
		public IAnimationJob[] jobs { get => default; } // 0x0000000189B54A14-0x0000000189B54A24 
		public bool isInitialized { get; private set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
	
		// Constructors
		public RigLayer() {} // Dummy constructor
		public RigLayer(Rig rig, bool active = true /* Metadata: 0x01FDA69F */) {} // 0x00000001892E5BF4-0x00000001892E5C1C
	
		// Methods
		public bool Initialize(Animator animator) => default; // 0x0000000189B57EF4-0x0000000189B57FDC
		public void Update() {} // 0x0000000189B580C0-0x0000000189B58144
		public void Reset() {} // 0x0000000189B58038-0x0000000189B580C0
		public bool IsValid() => default; // 0x0000000189B57FDC-0x0000000189B58038
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-transform")]
	public class RigTransform : MonoBehaviour // TypeDefIndex: 57899
	{
		// Constructors
		public RigTransform() {} // 0x000000018426FE60-0x000000018426FE68
	}

	internal static class RigUtils // TypeDefIndex: 57902
	{
		// Fields
		internal static readonly Dictionary<System.Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor; // 0x00
	
		// Properties
		public static IAnimationJobBinder syncSceneToStreamBinder { get; } // 0x0000000189B5A984-0x0000000189B5A9D4 
	
		// Nested types
		private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData // TypeDefIndex: 57900
		{
			// Fields
			private readonly bool m_IsValid; // 0x18
	
			// Properties
			public Transform[] syncableTransforms { [IsReadOnly] get; private set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
			public SyncableProperties[] syncableProperties { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
			public bool[] rigStates { [IsReadOnly] get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
			// Constructors
			public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount) : this() {
				m_IsValid = default;
			} // 0x0000000189B583B8-0x0000000189B58540
	
			// Methods
			private static int[] UniqueTransformIndices(Transform[] transforms) => default; // 0x0000000189B58230-0x0000000189B58388
			bool IAnimationJobData.IsValid() => default; // 0x0000000181002A50-0x0000000181002A60
			void IAnimationJobData.SetDefaultValues() {} // 0x0000000189B58388-0x0000000189B583B8
		}
	
		// Constructors
		static RigUtils() {} // 0x0000000189B5A5F8-0x0000000189B5A984
	
		// Methods
		public static IRigConstraint[] GetConstraints(Rig rig) => default; // 0x0000000189B5A3D8-0x0000000189B5A50C
		private static Transform[] GetSyncableRigTransforms(Animator animator) => default; // 0x0000000189B5A50C-0x0000000189B5A5F8
		private static bool ExtractTransformType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms) => default; // 0x0000000189B59A18-0x0000000189B59DC8
		private static bool ExtractPropertyType(System.Reflection.FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x01FDA6A0 */) => default; // 0x0000000189B598D8-0x0000000189B59A18
		private static bool ExtractWeightedTransforms(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties) => default; // 0x0000000189B59DC8-0x0000000189B5A3D8
		private static bool ExtractNestedPropertyType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x01FDA6A1 */) => default; // 0x0000000189B5938C-0x0000000189B598D8
		private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform> syncableTransforms, out List<SyncableProperties> syncableProperties) {
			syncableTransforms = default;
			syncableProperties = default;
		} // 0x0000000189B588FC-0x0000000189B5938C
		public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints) => default; // 0x0000000189B5868C-0x0000000189B58758
		public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs) {} // 0x0000000189B5888C-0x0000000189B588FC
		internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers) => default; // 0x0000000189B58758-0x0000000189B5888C
	}

	internal class SyncSceneToStreamLayer // TypeDefIndex: 57903
	{
		// Fields
		public IAnimationJob job; // 0x18
		private IAnimationJobData m_Data; // 0x20
		private List<int> m_RigIndices; // 0x28
	
		// Properties
		public bool isInitialized { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public SyncSceneToStreamLayer() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool Initialize(Animator animator, IList<IRigLayer> layers) => default; // 0x0000000189B5AA5C-0x0000000189B5AC50
		public void Update(IList<IRigLayer> layers) {} // 0x0000000189B5AD24-0x0000000189B5AF18
		public void Reset() {} // 0x0000000189B5AC64-0x0000000189B5AD24
		public bool IsValid() => default; // 0x0000000189B5AC50-0x0000000189B5AC64
	}

	public interface ITransformProvider // TypeDefIndex: 57904
	{
		// Properties
		Transform transform { get; set; }
	}

	public interface IWeightProvider // TypeDefIndex: 57905
	{
		// Properties
		float weight { get; set; }
	}

	[Serializable]
	public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform> // TypeDefIndex: 57906
	{
		// Fields
		public Transform transform; // 0x00
		public float weight; // 0x08
	
		// Properties
		Transform ITransformProvider.transform { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		float IWeightProvider.weight { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000189B5F764-0x0000000189B5F77C
	
		// Constructors
		public WeightedTransform(Transform transform, float weight) : this() {
			this.transform = default;
			this.weight = default;
		} // 0x0000000189B5F77C-0x0000000189B5F7A0
	
		// Methods
		public static WeightedTransform Default(float weight) => default; // 0x0000000189B5F6C4-0x0000000189B5F6EC
		public bool Equals(WeightedTransform other) => default; // 0x0000000189B5F6EC-0x0000000189B5F764
	}

	[Serializable]
	public struct WeightedTransformArray : IList<WeightedTransform>, IList // TypeDefIndex: 57908
	{
		// Fields
		public static readonly int k_MaxLength; // 0x00
		[NotKeyable]
		[SerializeField]
		private int m_Length; // 0x00
		[SerializeField]
		private WeightedTransform m_Item0; // 0x08
		[SerializeField]
		private WeightedTransform m_Item1; // 0x18
		[SerializeField]
		private WeightedTransform m_Item2; // 0x28
		[SerializeField]
		private WeightedTransform m_Item3; // 0x38
		[SerializeField]
		private WeightedTransform m_Item4; // 0x48
		[SerializeField]
		private WeightedTransform m_Item5; // 0x58
		[SerializeField]
		private WeightedTransform m_Item6; // 0x68
		[SerializeField]
		private WeightedTransform m_Item7; // 0x78
	
		// Properties
		object IList.this[int index] { get => default; set {} } // 0x0000000189B5F434-0x0000000189B5F4B0 0x0000000189B5F4B0-0x0000000189B5F538
		public WeightedTransform this[int index] { get => default; set {} } // 0x0000000189B5F5E8-0x0000000189B5F658 0x0000000189B5F658-0x0000000189B5F6C4
		public int Count { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsFixedSize { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		object ICollection.SyncRoot { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Nested types
		[Serializable]
		private struct Enumerator : IEnumerator<WeightedTransform> // TypeDefIndex: 57907
		{
			// Fields
			private WeightedTransformArray m_Array; // 0x00
			private int m_Index; // 0x88
	
			// Properties
			public WeightedTransform Current { get => default; } // 0x0000000189B4FD40-0x0000000189B4FDB0 
			object IEnumerator.Current { get => default; } // 0x0000000189B4FC1C-0x0000000189B4FC74 
	
			// Constructors
			public Enumerator(ref WeightedTransformArray array) : this() {
				m_Array = default;
				m_Index = default;
			} // 0x0000000189B4FC74-0x0000000189B4FD40
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189B4FBC8-0x0000000189B4FC1C
			public void Reset() {} // 0x0000000183D76380-0x0000000183D76390
			void IDisposable.Dispose() {} // 0x000000018350B670-0x000000018350B680
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
		} // 0x0000000189B5F574-0x0000000189B5F5E8
		static WeightedTransformArray() {
			k_MaxLength = default;
		} // 0x0000000189B5F538-0x0000000189B5F574
	
		// Methods
		public IEnumerator<WeightedTransform> GetEnumerator() => default; // 0x0000000189B5E610-0x0000000189B5E6D0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189B5F108-0x0000000189B5F1C8
		int IList.Add(object value) => default; // 0x0000000189B5F1C8-0x0000000189B5F244
		public void Add(WeightedTransform value) {} // 0x0000000189B5E114-0x0000000189B5E248
		public void Clear() {} // 0x0000000183D5BBD0-0x0000000183D5BBE0
		int IList.IndexOf(object value) => default; // 0x0000000189B5F2BC-0x0000000189B5F334
		public int IndexOf(WeightedTransform value) => default; // 0x0000000189B5E840-0x0000000189B5E8DC
		bool IList.Contains(object value) => default; // 0x0000000189B5F244-0x0000000189B5F2BC
		public bool Contains(WeightedTransform value) => default; // 0x0000000189B5E3AC-0x0000000189B5E448
		void ICollection.CopyTo(Array array, int arrayIndex) {} // 0x0000000189B5EF20-0x0000000189B5F108
		public void CopyTo(WeightedTransform[] array, int arrayIndex) {} // 0x0000000189B5E448-0x0000000189B5E610
		void IList.Remove(object value) {} // 0x0000000189B5F3BC-0x0000000189B5F434
		public bool Remove(WeightedTransform value) => default; // 0x0000000189B5EC08-0x0000000189B5ECF4
		public void RemoveAt(int index) {} // 0x0000000189B5EB70-0x0000000189B5EC08
		void IList.Insert(int index, object value) {} // 0x0000000189B5F334-0x0000000189B5F3BC
		public void Insert(int index, WeightedTransform value) {} // 0x0000000189B5E8DC-0x0000000189B5EAAC
		private static int ClampSize(int size) => default; // 0x0000000189B5E358-0x0000000189B5E3AC
		private void CheckOutOfRangeIndex(int index) {} // 0x0000000189B5E248-0x0000000189B5E358
		private WeightedTransform Get(int index) => default; // 0x0000000189B5E784-0x0000000189B5E840
		private void Set(int index, WeightedTransform value) {} // 0x0000000189B5EE24-0x0000000189B5EF20
		public void SetWeight(int index, float weight) {} // 0x0000000189B5ED94-0x0000000189B5EE24
		public float GetWeight(int index) => default; // 0x0000000189B5E728-0x0000000189B5E784
		public void SetTransform(int index, Transform transform) {} // 0x0000000189B5ECF4-0x0000000189B5ED94
		public Transform GetTransform(int index) => default; // 0x0000000189B5E6D0-0x0000000189B5E728
		public static void OnValidate(ref WeightedTransformArray array, float min = 0f /* Metadata: 0x01FDA6A2 */, float max = 1f /* Metadata: 0x01FDA6A6 */) {} // 0x0000000189B5EAAC-0x0000000189B5EB70
	}

	internal sealed class ExpandChildrenAttribute : PropertyAttribute // TypeDefIndex: 57909
	{
		// Constructors
		public ExpandChildrenAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class SyncSceneToStreamAttribute : Attribute // TypeDefIndex: 57910
	{
		// Constructors
		public SyncSceneToStreamAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum PropertyType : byte // TypeDefIndex: 57911
	{
		Bool = 0,
		Int = 1,
		Float = 2
	}

	internal struct PropertyDescriptor // TypeDefIndex: 57912
	{
		// Fields
		public int size; // 0x00
		public PropertyType type; // 0x04
	}

	internal struct Property // TypeDefIndex: 57913
	{
		// Fields
		public string name; // 0x00
		public PropertyDescriptor descriptor; // 0x08
	}

	internal struct RigProperties // TypeDefIndex: 57914
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
	
		// Constructors
		static RigProperties() {
			s_Weight = default;
		} // 0x0000000189B581D4-0x0000000189B58230
	}

	internal struct ConstraintProperties // TypeDefIndex: 57915
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
		public Property[] properties; // 0x08
	
		// Constructors
		static ConstraintProperties() {
			s_Weight = default;
		} // 0x0000000189B4ED08-0x0000000189B4ED64
	}

	[Obsolete("PropertyUtils is deprecated. Use ConstraintsUtils instead. (UnityUpgradable) -> ConstraintsUtils")]
	public static class PropertyUtils // TypeDefIndex: 57916
	{
		// Methods
		[Obsolete("ConstructConstraintDataPropertyName is deprecated. Use ConstraintsUtils.ConstructConstraintDataPropertyName instead.")]
		public static string ConstructConstraintDataPropertyName(string property) => default; // 0x0000000189B559EC-0x0000000189B559F4
		[Obsolete("ConstructCustomPropertyName is deprecated. Use ConstraintsUtils.ConstructCustomPropertyName instead.")]
		public static string ConstructCustomPropertyName(Component component, string property) => default; // 0x0000000189B559F4-0x0000000189B559FC
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class WeightRangeAttribute : PropertyAttribute // TypeDefIndex: 57917
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public WeightRangeAttribute() {} // Dummy constructor
		public WeightRangeAttribute(float min, float max) {} // 0x0000000183D5E2F0-0x0000000183D5E300
	}

	public interface IRigEffectorHolder // TypeDefIndex: 57918
	{
	}

	[Serializable]
	public class RigEffectorData // TypeDefIndex: 57920
	{
		// Fields
		[SerializeField]
		private Transform m_Transform; // 0x10
		[SerializeField]
		private Style m_Style; // 0x18
		[SerializeField]
		private bool m_Visible; // 0x50
	
		// Properties
		public Transform transform { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Style style { get => default; } // 0x0000000183D62FD0-0x0000000183D63000 
		public bool visible { get => default; set {} } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 57919
		{
			// Fields
			public Mesh shape; // 0x00
			public UnityEngine.Color color; // 0x08
			public float size; // 0x18
			public Vector3 position; // 0x1C
			public Vector3 rotation; // 0x28
		}
	
		// Constructors
		public RigEffectorData() {} // 0x0000000183D75180-0x0000000183D75190
	
		// Methods
		public void Initialize(Transform transform, Style style) {} // 0x0000000189B57EA4-0x0000000189B57EF4
	}

	[Serializable]
	public struct AffineTransform // TypeDefIndex: 57921
	{
		// Fields
		public Vector3 translation; // 0x00
		public Quaternion rotation; // 0x0C
	
		// Properties
		public static AffineTransform identity { get; } // 0x0000000189B4BC2C-0x0000000189B4BC8C 
	
		// Constructors
		public AffineTransform(Vector3 t, Quaternion r) : this() {
			translation = default;
			rotation = default;
		} // 0x0000000183D5C820-0x0000000183D5C840
		static AffineTransform() {
	
		} // 0x0000000189B4BBA0-0x0000000189B4BC2C
	
		// Methods
		public void Set(Vector3 t, Quaternion r) {} // 0x0000000183D5C820-0x0000000183D5C840
		public Vector3 Transform(Vector3 p) => default; // 0x0000000185E2197C-0x0000000185E21A08
		public Vector3 InverseTransform(Vector3 p) => default; // 0x0000000185E2180C-0x0000000185E218CC
		public AffineTransform Inverse() => default; // 0x0000000185E218CC-0x0000000185E2197C
		public AffineTransform InverseMul(AffineTransform transform) => default; // 0x0000000185E216E4-0x0000000185E2180C
		public static Vector3 operator *(AffineTransform lhs, Vector3 rhs) => default; // 0x0000000185E2197C-0x0000000185E21A08
		public static AffineTransform operator *(AffineTransform lhs, AffineTransform rhs) => default; // 0x0000000189B4BC8C-0x0000000189B4BDA0
		public static AffineTransform operator *(Quaternion lhs, AffineTransform rhs) => default; // 0x0000000185E21C08-0x0000000185E21CA8
		public static AffineTransform operator *(AffineTransform lhs, Quaternion rhs) => default; // 0x0000000185E21CA8-0x0000000185E21CFC
	}

	public static class AnimationRuntimeUtils // TypeDefIndex: 57922
	{
		// Fields
		private const float k_SqrEpsilon = 1E-08f; // Metadata: 0x01FDA6AD
	
		// Methods
		public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset) {} // 0x0000000189B4CB58-0x0000000189B4D8AC
		private static float TriangleAngle(float aLen, float aLen1, float aLen2) => default; // 0x0000000189B4D8FC-0x0000000189B4D94C
		public static bool SolveFABRIK(ref NativeArray<Vector3> linkPositions, ref NativeArray<float> linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations) => default; // 0x0000000189B4C6AC-0x0000000189B4CB58
		public static float SqrDistance(Vector3 lhs, Vector3 rhs) => default; // 0x0000000185671F48-0x0000000185671FA4
		public static float Square(float value) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t) => default; // 0x0000000189B4C380-0x0000000189B4C484
		public static float Select(float a, float b, float c) => default; // 0x0000000189B4C6A0-0x0000000189B4C6AC
		public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000189B4C644-0x0000000189B4C6A0
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) => default; // 0x0000000189B4C584-0x0000000189B4C644
		internal static float Sum(AnimationJobCache cache, CacheIndex index, int count) => default; // 0x0000000189B4D8D4-0x0000000189B4D8FC
		public static float Sum(NativeArray<float> floatBuffer) => default; // 0x0000000189B4D8AC-0x0000000189B4D8D4
		public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle) {} // 0x0000000189B4C484-0x0000000189B4C584
	}

	[AddComponentMenu("Animation Rigging/Setup/Bone Renderer")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#bone-renderer-component")]
	public class BoneRenderer : MonoBehaviour // TypeDefIndex: 57924
	{
		// Fields
		public BoneShape boneShape; // 0x18
		public bool drawBones; // 0x1C
		public bool drawTripods; // 0x1D
		[Range(0.01f, 5f)]
		public float boneSize; // 0x20
		[Range(0.01f, 5f)]
		public float tripodSize; // 0x24
		public UnityEngine.Color boneColor; // 0x28
		[SerializeField]
		private Transform[] m_Transforms; // 0x38
	
		// Properties
		public Transform[] transforms { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Nested types
		public enum BoneShape // TypeDefIndex: 57923
		{
			Line = 0,
			Pyramid = 1,
			Box = 2
		}
	
		// Constructors
		public BoneRenderer() {} // 0x0000000189B4E13C-0x0000000189B4E168
	}

	public static class ConstraintsUtils // TypeDefIndex: 57926
	{
		// Methods
		public static Transform[] ExtractChain(Transform root, Transform tip) => default; // 0x0000000189B4EED0-0x0000000189B4F020
		public static float[] ExtractLengths(Transform[] chain) => default; // 0x0000000189B4F020-0x0000000189B4F0EC
		public static float[] ExtractSteps(Transform[] chain) => default; // 0x0000000189B4F0EC-0x0000000189B4F21C
		public static string ConstructConstraintDataPropertyName(string property) => default; // 0x0000000189B4ED64-0x0000000189B4EDA0
		public static string ConstructCustomPropertyName(Component component, string property) => default; // 0x0000000189B4EDA0-0x0000000189B4EED0
	}

	public static class QuaternionExt // TypeDefIndex: 57927
	{
		// Fields
		private const float k_FloatMin = 1E-10f; // Metadata: 0x01FDA6B4
		public static readonly Quaternion zero; // 0x00
	
		// Constructors
		static QuaternionExt() {} // 0x0000000189B55CE8-0x0000000189B55D24
	
		// Methods
		public static Quaternion FromToRotation(Vector3 from, Vector3 to) => default; // 0x0000000189B55A80-0x0000000189B55C74
		public static Quaternion Add(Quaternion rhs, Quaternion lhs) => default; // 0x0000000189B559FC-0x0000000189B55A80
		public static Quaternion Scale(Quaternion q, float scale) => default; // 0x0000000182E260C0-0x0000000182E260E0
		public static Quaternion NormalizeSafe(Quaternion q) => default; // 0x0000000189B55C74-0x0000000189B55CE8
	}

	[Serializable]
	public struct Vector3Bool // TypeDefIndex: 57928
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
		} // 0x0000000183D764F0-0x0000000183D76500
		public Vector3Bool(bool x, bool y, bool z) {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D6B5F0-0x0000000183D6B600
	}
}
