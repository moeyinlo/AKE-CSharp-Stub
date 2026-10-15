/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

// Image 57: Unity.Animation.Rigging.dll - Assembly: Unity.Animation.Rigging, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88508-88643

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 88509
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 88510
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.Animations.Rigging
{
	public struct CacheIndex // TypeDefIndex: 88511
	{
		// Fields
		internal int idx; // 0x00
	}

	public struct AnimationJobCache : IDisposable // TypeDefIndex: 88512
	{
		// Fields
		private NativeArray<float> m_Data; // 0x00
	
		// Constructors
		internal AnimationJobCache(float[] data); // 0x000000018D291B50-0x000000018D291BB4
	
		// Methods
		public void Dispose(); // 0x000000018D291B14-0x000000018D291B50
		public float GetRaw(CacheIndex index, int offset = 0 /* Metadata: 0x026485C0 */); // 0x0000000187258EF0-0x0000000187258F00
		public void SetRaw(float val, CacheIndex index, int offset = 0 /* Metadata: 0x026485C1 */); // 0x0000000187258F00-0x0000000187258F10
		public T Get<T>(CacheIndex index, int offset = 0 /* Metadata: 0x026485C2 */)
			where T : struct;
		public void Set<T>(T val, CacheIndex index, int offset = 0 /* Metadata: 0x026485C3 */)
			where T : struct;
		public void SetArray<T>(T[] v, CacheIndex index, int offset = 0 /* Metadata: 0x026485C4 */)
			where T : struct;
	}

	public class AnimationJobCacheBuilder // TypeDefIndex: 88513
	{
		// Fields
		private List<float> m_Data; // 0x10
	
		// Constructors
		public AnimationJobCacheBuilder(); // 0x000000018D291A9C-0x000000018D291B14
	
		// Methods
		public CacheIndex Add(float v); // 0x000000018D291814-0x000000018D291884
		public CacheIndex Add(Vector2 v); // 0x000000018D291884-0x000000018D29190C
		public CacheIndex Add(Vector3 v); // 0x000000018D291694-0x000000018D29173C
		public CacheIndex Add(Vector4 v); // 0x000000018D2915D4-0x000000018D291694
		public CacheIndex Add(Quaternion v); // 0x000000018D2917F4-0x000000018D291814
		public CacheIndex Add(AffineTransform tx); // 0x000000018D29173C-0x000000018D2917F4
		public CacheIndex AllocateChunk(int size); // 0x000000018D29190C-0x000000018D2919A4
		public void SetValue(CacheIndex index, int offset, float value); // 0x000000018D291A10-0x000000018D291A9C
		public AnimationJobCache Build(); // 0x000000018D2919A4-0x000000018D291A10
	}

	[BurstCompile]
	public struct BlendConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88514
	{
		// Fields
		private const int k_BlendTranslationMask = 1; // Metadata: 0x026485C5
		private const int k_BlendRotationMask = 2; // Metadata: 0x026485C6
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle sourceA; // 0x0C
		public ReadOnlyTransformHandle sourceB; // 0x24
		public AffineTransform sourceAOffset; // 0x3C
		public AffineTransform sourceBOffset; // 0x58
		public BoolProperty blendPosition; // 0x74
		public BoolProperty blendRotation; // 0x84
		public FloatProperty positionWeight; // 0x94
		public FloatProperty rotationWeight; // 0xA4
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xB4
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187258F10-0x0000000187258F20 0x0000000187258F20-0x0000000187258F30
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D293328-0x000000018D2938B0
	}

	public interface IBlendConstraintData // TypeDefIndex: 88515
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

	public class BlendConstraintJobBinder<T> : AnimationJobBinder<BlendConstraintJob, T> // TypeDefIndex: 88516
		where T : struct, IAnimationJobData, IBlendConstraintData
	{
		// Constructors
		public BlendConstraintJobBinder();
	
		// Methods
		public override BlendConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(BlendConstraintJob job);
	}

	[BurstCompile]
	public struct ChainIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88517
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
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187258F30-0x0000000187258F40 0x0000000187258F40-0x0000000187258F50
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D293D2C-0x000000018D294440
	}

	public interface IChainIKConstraintData // TypeDefIndex: 88518
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

	public class ChainIKConstraintJobBinder<T> : AnimationJobBinder<ChainIKConstraintJob, T> // TypeDefIndex: 88519
		where T : struct, IAnimationJobData, IChainIKConstraintData
	{
		// Constructors
		public ChainIKConstraintJobBinder();
	
		// Methods
		public override ChainIKConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(ChainIKConstraintJob job);
		public override void Update(ChainIKConstraintJob job, ref ref T data);
	}

	[BurstCompile]
	public struct DampedTransformJob : IWeightedAnimationJob // TypeDefIndex: 88520
	{
		// Fields
		private const float k_FixedDt = 0.01667f; // Metadata: 0x026485C7
		private const float k_DampFactor = 40f; // Metadata: 0x026485CB
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle source; // 0x0C
		public AffineTransform localBindTx; // 0x24
		public Vector3 aimBindAxis; // 0x40
		public AffineTransform prevDrivenTx; // 0x4C
		public FloatProperty dampPosition; // 0x68
		public FloatProperty dampRotation; // 0x78
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x88
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187258F50-0x0000000187258F60 0x0000000187258F60-0x0000000187258F70
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D294BCC-0x000000018D29538C
	}

	public interface IDampedTransformData // TypeDefIndex: 88521
	{
		// Properties
		Transform constrainedObject { get; }
		Transform sourceObject { get; }
		bool maintainAim { get; }
		string dampPositionFloatProperty { get; }
		string dampRotationFloatProperty { get; }
	}

	public class DampedTransformJobBinder<T> : AnimationJobBinder<DampedTransformJob, T> // TypeDefIndex: 88522
		where T : struct, IAnimationJobData, IDampedTransformData
	{
		// Constructors
		public DampedTransformJobBinder();
	
		// Methods
		public override DampedTransformJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(DampedTransformJob job);
	}

	public interface IAnimatableProperty<T> // TypeDefIndex: 88523
	{
		// Methods
		T Get(AnimationStream stream);
		void Set(AnimationStream stream, T value);
	}

	public struct BoolProperty : IAnimatableProperty<bool> // TypeDefIndex: 88524
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static BoolProperty Bind(Animator animator, Component component, string name); // 0x000000018D2939DC-0x000000018D293A70
		public static BoolProperty BindCustom(Animator animator, string property); // 0x000000018D2939A4-0x000000018D2939DC
		public bool Get(AnimationStream stream); // 0x000000018D293A70-0x000000018D293AAC
		public void Set(AnimationStream stream, bool v); // 0x000000018D293AAC-0x000000018D293AE8
	}

	public struct IntProperty : IAnimatableProperty<int> // TypeDefIndex: 88525
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static IntProperty Bind(Animator animator, Component component, string name); // 0x000000018D2939DC-0x000000018D293A70
		public static IntProperty BindCustom(Animator animator, string property); // 0x000000018D2956E0-0x000000018D295718
		public int Get(AnimationStream stream); // 0x000000018D295718-0x000000018D295754
		public void Set(AnimationStream stream, int v); // 0x000000018D295754-0x000000018D295790
	}

	public struct FloatProperty : IAnimatableProperty<float> // TypeDefIndex: 88526
	{
		// Fields
		public PropertyStreamHandle value; // 0x00
	
		// Methods
		public static FloatProperty Bind(Animator animator, Component component, string name); // 0x000000018D2939DC-0x000000018D293A70
		public static FloatProperty BindCustom(Animator animator, string property); // 0x000000018D295630-0x000000018D295668
		public float Get(AnimationStream stream); // 0x000000018D295668-0x000000018D2956A4
		public void Set(AnimationStream stream, float v); // 0x000000018D2956A4-0x000000018D2956E0
	}

	public struct Vector2Property : IAnimatableProperty<Vector2> // TypeDefIndex: 88527
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
	
		// Methods
		public static Vector2Property Bind(Animator animator, Component component, string name); // 0x000000018D2A26D8-0x000000018D2A27FC
		public static Vector2Property BindCustom(Animator animator, string name); // 0x000000018D2A2608-0x000000018D2A26D8
		public Vector2 Get(AnimationStream stream); // 0x000000018D2A27FC-0x000000018D2A28A4
		public void Set(AnimationStream stream, Vector2 value); // 0x000000018D2A28A4-0x000000018D2A2950
	}

	public struct Vector3Property : IAnimatableProperty<Vector3> // TypeDefIndex: 88528
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3Property Bind(Animator animator, Component component, string name); // 0x000000018D2A3328-0x000000018D2A34A8
		public static Vector3Property BindCustom(Animator animator, string name); // 0x000000018D2A3210-0x000000018D2A3328
		public Vector3 Get(AnimationStream stream); // 0x000000018D2A34A8-0x000000018D2A35A8
		public void Set(AnimationStream stream, Vector3 value); // 0x000000018D2A35A8-0x000000018D2A3684
	}

	public struct Vector3IntProperty : IAnimatableProperty<Vector3Int> // TypeDefIndex: 88529
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3IntProperty Bind(Animator animator, Component component, string name); // 0x000000018D2A2EC8-0x000000018D2A3048
		public static Vector3IntProperty BindCustom(Animator animator, string name); // 0x000000018D2A2DB0-0x000000018D2A2EC8
		public Vector3Int Get(AnimationStream stream); // 0x000000018D2A3048-0x000000018D2A3138
		public void Set(AnimationStream stream, Vector3Int value); // 0x000000018D2A3138-0x000000018D2A3210
	}

	public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool> // TypeDefIndex: 88530
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
	
		// Methods
		public static Vector3BoolProperty Bind(Animator animator, Component component, string name); // 0x000000018D2A2A68-0x000000018D2A2BE8
		public static Vector3BoolProperty BindCustom(Animator animator, string name); // 0x000000018D2A2950-0x000000018D2A2A68
		public Vector3Bool Get(AnimationStream stream); // 0x000000018D2A2BE8-0x000000018D2A2CD8
		public void Set(AnimationStream stream, Vector3Bool value); // 0x000000018D2A2CD8-0x000000018D2A2DB0
	}

	public struct Vector4Property : IAnimatableProperty<Vector4> // TypeDefIndex: 88531
	{
		// Fields
		public PropertyStreamHandle x; // 0x00
		public PropertyStreamHandle y; // 0x10
		public PropertyStreamHandle z; // 0x20
		public PropertyStreamHandle w; // 0x30
	
		// Methods
		public static Vector4Property Bind(Animator animator, Component component, string name); // 0x000000018D2A37E0-0x000000018D2A39B8
		public static Vector4Property BindCustom(Animator animator, string name); // 0x000000018D2A3684-0x000000018D2A37E0
		public Vector4 Get(AnimationStream stream); // 0x000000018D2A39B8-0x000000018D2A3B04
		public void Set(AnimationStream stream, Vector4 value); // 0x000000018D2A3B04-0x000000018D2A3C20
	}

	public interface IAnimationJobBinder // TypeDefIndex: 88532
	{
		// Methods
		IAnimationJob Create(Animator animator, IAnimationJobData data, Component component = null);
		void Destroy(IAnimationJob job);
		void Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public abstract class AnimationJobBinder<TJob, TData> : IAnimationJobBinder // TypeDefIndex: 88533
		where TJob : struct, IAnimationJob
		where TData : struct, IAnimationJobData
	{
		// Constructors
		protected AnimationJobBinder();
	
		// Methods
		public abstract TJob Create(Animator animator, ref ref TData data, Component component);
		public abstract void Destroy(TJob job);
		public virtual void Update(TJob job, ref ref TData data);
		IAnimationJob IAnimationJobBinder.Create(Animator animator, IAnimationJobData data, Component component);
		void IAnimationJobBinder.Destroy(IAnimationJob job);
		void IAnimationJobBinder.Update(IAnimationJob job, IAnimationJobData data);
		AnimationScriptPlayable IAnimationJobBinder.CreatePlayable(PlayableGraph graph, IAnimationJob job);
	}

	public interface IAnimationJobData // TypeDefIndex: 88534
	{
		// Methods
		bool IsValid();
		void SetDefaultValues();
	}

	public interface IWeightedAnimationJob : IAnimationJob // TypeDefIndex: 88535
	{
		// Properties
		FloatProperty jobWeight { get; set; }
	}

	[BurstCompile]
	public struct MultiAimConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88537
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x026485CF
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
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x104
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258FE0-0x0000000187258FF0 0x0000000187258FF0-0x0000000187259000
	
		// Nested types
		public enum WorldUpType // TypeDefIndex: 88536
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D295FA0-0x000000018D296F00
		private Vector3 ComputeWorldUpVector(AnimationStream stream); // 0x000000018D295D20-0x000000018D295FA0
	}

	public interface IMultiAimConstraintData // TypeDefIndex: 88538
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

	public class MultiAimConstraintJobBinder<T> : AnimationJobBinder<MultiAimConstraintJob, T> // TypeDefIndex: 88539
		where T : struct, IAnimationJobData, IMultiAimConstraintData
	{
		// Constructors
		public MultiAimConstraintJobBinder();
	
		// Methods
		public override MultiAimConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiAimConstraintJob job);
	}

	[BurstCompile]
	public struct MultiParentConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88540
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x026485D8
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x28
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x38
		public NativeArray<AffineTransform> sourceOffsets; // 0x48
		public NativeArray<float> weightBuffer; // 0x58
		public Vector3 positionAxesMask; // 0x68
		public Vector3 rotationAxesMask; // 0x74
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x80
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018723E560-0x000000018723E570 0x0000000187233E20-0x0000000187233E30
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D2973CC-0x000000018D297E9C
	}

	public interface IMultiParentConstraintData // TypeDefIndex: 88541
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

	public class MultiParentConstraintJobBinder<T> : AnimationJobBinder<MultiParentConstraintJob, T> // TypeDefIndex: 88542
		where T : struct, IAnimationJobData, IMultiParentConstraintData
	{
		// Constructors
		public MultiParentConstraintJobBinder();
	
		// Methods
		public override MultiParentConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiParentConstraintJob job);
	}

	[BurstCompile]
	public struct MultiPositionConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88543
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x026485DC
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Vector3> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258F30-0x0000000187258F40 0x0000000187258F40-0x0000000187258F50
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D298338-0x000000018D298A3C
	}

	public interface IMultiPositionConstraintData // TypeDefIndex: 88544
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

	public class MultiPositionConstraintJobBinder<T> : AnimationJobBinder<MultiPositionConstraintJob, T> // TypeDefIndex: 88545
		where T : struct, IAnimationJobData, IMultiPositionConstraintData
	{
		// Constructors
		public MultiPositionConstraintJobBinder();
	
		// Methods
		public override MultiPositionConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiPositionConstraintJob job);
	}

	[BurstCompile]
	public struct MultiReferentialConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88546
	{
		// Fields
		public IntProperty driver; // 0x00
		public NativeArray<ReadWriteTransformHandle> sources; // 0x10
		public NativeArray<AffineTransform> sourceBindTx; // 0x20
		public NativeArray<AffineTransform> offsetTx; // 0x30
		private int m_PrevDriverIdx; // 0x40
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x44
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258E10-0x0000000187258E20 0x0000000187258E20-0x0000000187258E30
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D298FC8-0x000000018D299480
		internal void UpdateOffsets(int driver); // 0x000000018D299480-0x000000018D299618
	}

	public interface IMultiReferentialConstraintData // TypeDefIndex: 88547
	{
		// Properties
		int driverValue { get; }
		string driverIntProperty { get; }
		Transform[] sourceObjects { get; }
	}

	public class MultiReferentialConstraintJobBinder<T> : AnimationJobBinder<MultiReferentialConstraintJob, T> // TypeDefIndex: 88548
		where T : struct, IAnimationJobData, IMultiReferentialConstraintData
	{
		// Constructors
		public MultiReferentialConstraintJobBinder();
	
		// Methods
		public override MultiReferentialConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiReferentialConstraintJob job);
	}

	[BurstCompile]
	public struct MultiRotationConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88549
	{
		// Fields
		private const float k_Epsilon = 1E-05f; // Metadata: 0x026485E0
		public ReadWriteTransformHandle driven; // 0x00
		public ReadOnlyTransformHandle drivenParent; // 0x0C
		public Vector3Property drivenOffset; // 0x24
		public NativeArray<ReadOnlyTransformHandle> sourceTransforms; // 0x58
		public NativeArray<PropertyStreamHandle> sourceWeights; // 0x68
		public NativeArray<Quaternion> sourceOffsets; // 0x78
		public NativeArray<float> weightBuffer; // 0x88
		public Vector3 axesMask; // 0x98
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA4
	
		// Properties
		public FloatProperty jobWeight { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258F30-0x0000000187258F40 0x0000000187258F40-0x0000000187258F50
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D2999BC-0x000000018D29A0B4
	}

	public interface IMultiRotationConstraintData // TypeDefIndex: 88550
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

	public class MultiRotationConstraintJobBinder<T> : AnimationJobBinder<MultiRotationConstraintJob, T> // TypeDefIndex: 88551
		where T : struct, IAnimationJobData, IMultiRotationConstraintData
	{
		// Constructors
		public MultiRotationConstraintJobBinder();
	
		// Methods
		public override MultiRotationConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(MultiRotationConstraintJob job);
	}

	[BurstCompile]
	public struct OverrideTransformJob : IWeightedAnimationJob // TypeDefIndex: 88553
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
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x108
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187258060-0x0000000187258070 0x00000001872580E0-0x00000001872580F0
	
		// Nested types
		public enum Space // TypeDefIndex: 88552
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D29A7B0-0x000000018D29B000
		internal void UpdateSpace(int space); // 0x000000018D29B000-0x000000018D29B0A0
	}

	public interface IOverrideTransformData // TypeDefIndex: 88554
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

	public class OverrideTransformJobBinder<T> : AnimationJobBinder<OverrideTransformJob, T> // TypeDefIndex: 88555
		where T : struct, IAnimationJobData, IOverrideTransformData
	{
		// Constructors
		public OverrideTransformJobBinder();
	
		// Methods
		public override OverrideTransformJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(OverrideTransformJob job);
		public override void Update(OverrideTransformJob job, ref ref T data);
	}

	[BurstCompile]
	internal struct RigSyncSceneToStreamJob : IAnimationJob // TypeDefIndex: 88558
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
		public struct TransformSyncer : IDisposable // TypeDefIndex: 88556
		{
			// Fields
			public NativeArray<TransformSceneHandle> sceneHandles; // 0x00
			public NativeArray<TransformStreamHandle> streamHandles; // 0x10
	
			// Methods
			public static TransformSyncer Create(int size); // 0x000000018D2A0DF4-0x000000018D2A0EA4
			public void Dispose(); // 0x000000018D2A0EA4-0x000000018D2A0F20
			public void BindAt(int index, Animator animator, Transform transform); // 0x000000018D2A0D78-0x000000018D2A0DF4
			public void Sync(ref AnimationStream stream); // 0x000000018D2A0F20-0x000000018D2A10F4
		}
	
		internal struct PropertySyncer : IDisposable // TypeDefIndex: 88557
		{
			// Fields
			public NativeArray<PropertySceneHandle> sceneHandles; // 0x00
			public NativeArray<PropertyStreamHandle> streamHandles; // 0x10
			public NativeArray<float> buffer; // 0x20
	
			// Methods
			public static PropertySyncer Create(int size); // 0x000000018D29B244-0x000000018D29B334
			public void Dispose(); // 0x000000018D29B334-0x000000018D29B3E0
			public void BindAt(int index, Animator animator, Component component, string property); // 0x000000018D29B170-0x000000018D29B244
			public void Sync(ref AnimationStream stream); // 0x000000018D29B45C-0x000000018D29B524
			public NativeArray<float> StreamValues(ref AnimationStream stream); // 0x000000018D29B3E0-0x000000018D29B45C
		}
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D29E218-0x000000018D29E364
	}

	internal struct SyncableProperties // TypeDefIndex: 88559
	{
		// Fields
		public RigProperties rig; // 0x00
		public ConstraintProperties[] constraints; // 0x08
	}

	internal interface IRigSyncSceneToStreamData // TypeDefIndex: 88560
	{
		// Properties
		Transform[] syncableTransforms { get; }
		SyncableProperties[] syncableProperties { get; }
		bool[] rigStates { get; }
	}

	internal class RigSyncSceneToStreamJobBinder<T> : AnimationJobBinder<RigSyncSceneToStreamJob, T> // TypeDefIndex: 88561
		where T : struct, IAnimationJobData, IRigSyncSceneToStreamData
	{
		// Fields
		internal static string[] s_PropertyElementNames;
	
		// Constructors
		public RigSyncSceneToStreamJobBinder();
		static RigSyncSceneToStreamJobBinder();
	
		// Methods
		public override RigSyncSceneToStreamJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(RigSyncSceneToStreamJob job);
		public override void Update(RigSyncSceneToStreamJob job, ref ref T data);
	}

	public struct ReadWriteTransformHandle // TypeDefIndex: 88562
	{
		// Fields
		private TransformStreamHandle m_Handle; // 0x00
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018D29BF4C-0x000000018D29BFA4
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018D29BFA4-0x000000018D29BFF4
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018D29BFF4-0x000000018D29C04C
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D29C04C-0x000000018D29C09C
		public void SetLocalPosition(AnimationStream stream, Vector3 position); // 0x000000018D29C270-0x000000018D29C2C4
		public void SetLocalRotation(AnimationStream stream, Quaternion rotation); // 0x000000018D29C2C4-0x000000018D29C30C
		public void SetLocalScale(AnimationStream stream, Vector3 scale); // 0x000000018D29C30C-0x000000018D29C360
		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false /* Metadata: 0x026485E7 */); // 0x000000018D29C360-0x000000018D29C3F0
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018D29C09C-0x000000018D29C0F4
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018D29C0F4-0x000000018D29C144
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D29BF08-0x000000018D29BF4C
		public void SetPosition(AnimationStream stream, Vector3 position); // 0x000000018D29C3F0-0x000000018D29C444
		public void SetRotation(AnimationStream stream, Quaternion rotation); // 0x000000018D29C444-0x000000018D29C48C
		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false /* Metadata: 0x026485E8 */); // 0x000000018D29C1F8-0x000000018D29C270
		public bool IsResolved(AnimationStream stream); // 0x000000018D29C144-0x000000018D29C180
		public bool IsValid(AnimationStream stream); // 0x000000018D29C180-0x000000018D29C1BC
		public void Resolve(AnimationStream stream); // 0x000000018D29C1BC-0x000000018D29C1F8
		public static ReadWriteTransformHandle Bind(Animator animator, Transform transform); // 0x000000018D29BD74-0x000000018D29BF08
	}

	public struct ReadOnlyTransformHandle // TypeDefIndex: 88563
	{
		// Fields
		private TransformStreamHandle m_StreamHandle; // 0x00
		private TransformSceneHandle m_SceneHandle; // 0x0C
		private byte m_InStream; // 0x14
	
		// Methods
		public Vector3 GetLocalPosition(AnimationStream stream); // 0x000000018D29B9F8-0x000000018D29BA70
		public Quaternion GetLocalRotation(AnimationStream stream); // 0x000000018D29BA70-0x000000018D29BAE0
		public Vector3 GetLocalScale(AnimationStream stream); // 0x000000018D29BAE0-0x000000018D29BB58
		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale); // 0x000000018D29BB58-0x000000018D29BBB8
		public Vector3 GetPosition(AnimationStream stream); // 0x000000018D29BBB8-0x000000018D29BC30
		public Quaternion GetRotation(AnimationStream stream); // 0x000000018D29BC30-0x000000018D29BCA0
		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation); // 0x000000018D29B9A8-0x000000018D29B9F8
		public bool IsResolved(AnimationStream stream); // 0x000000018D29BCA0-0x000000018D29BCE4
		public bool IsValid(AnimationStream stream); // 0x000000018D29BCE4-0x000000018D29BD30
		public void Resolve(AnimationStream stream); // 0x000000018D29BD30-0x000000018D29BD74
		public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform); // 0x000000018D29B85C-0x000000018D29B9A8
	}

	[BurstCompile]
	public struct TwistChainConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88564
	{
		// Fields
		public ReadWriteTransformHandle rootTarget; // 0x00
		public ReadWriteTransformHandle tipTarget; // 0x0C
		public NativeArray<ReadWriteTransformHandle> chain; // 0x18
		public NativeArray<float> steps; // 0x28
		public NativeArray<float> weights; // 0x38
		public NativeArray<Quaternion> rotations; // 0x48
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x58
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000187234DB0-0x0000000187234DC0 0x0000000187234090-0x00000001872340A0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D2A1248-0x000000018D2A1740
	}

	public interface ITwistChainConstraintData // TypeDefIndex: 88565
	{
		// Properties
		Transform root { get; }
		Transform tip { get; }
		Transform rootTarget { get; }
		Transform tipTarget { get; }
		AnimationCurve curve { get; }
	}

	public class TwistChainConstraintJobBinder<T> : AnimationJobBinder<TwistChainConstraintJob, T> // TypeDefIndex: 88566
		where T : struct, IAnimationJobData, ITwistChainConstraintData
	{
		// Constructors
		public TwistChainConstraintJobBinder();
	
		// Methods
		public override TwistChainConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwistChainConstraintJob job);
	}

	[BurstCompile]
	public struct TwistCorrectionJob : IWeightedAnimationJob // TypeDefIndex: 88567
	{
		// Fields
		public ReadOnlyTransformHandle source; // 0x00
		public Quaternion sourceInverseBindRotation; // 0x18
		public Vector3 axisMask; // 0x28
		public NativeArray<ReadWriteTransformHandle> twistTransforms; // 0x38
		public NativeArray<PropertyStreamHandle> twistWeights; // 0x48
		public NativeArray<Quaternion> twistBindRotations; // 0x58
		public NativeArray<float> weightBuffer; // 0x68
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0x78
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018723C550-0x000000018723C560 0x00000001872577B0-0x00000001872577C0
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D2A1994-0x000000018D2A1D50
		private static Quaternion TwistRotation(Vector3 axis, Quaternion rot); // 0x0000000187259030-0x0000000187259070
	}

	public interface ITwistCorrectionData // TypeDefIndex: 88568
	{
		// Properties
		Transform source { get; }
		WeightedTransformArray twistNodes { get; }
		Vector3 twistAxis { get; }
		string twistNodesProperty { get; }
	}

	public class TwistCorrectionJobBinder<T> : AnimationJobBinder<TwistCorrectionJob, T> // TypeDefIndex: 88569
		where T : struct, IAnimationJobData, ITwistCorrectionData
	{
		// Constructors
		public TwistCorrectionJobBinder();
	
		// Methods
		public override TwistCorrectionJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwistCorrectionJob job);
	}

	[BurstCompile]
	public struct TwoBoneIKConstraintJob : IWeightedAnimationJob // TypeDefIndex: 88570
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
		[CompilerGenerated]
		private FloatProperty _jobWeight_k__BackingField; // 0xA0
	
		// Properties
		public FloatProperty jobWeight { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018724F4C0-0x000000018724F4D0 0x0000000187233E60-0x0000000187233E70
	
		// Methods
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessAnimation(AnimationStream stream); // 0x000000018D2A20F4-0x000000018D2A2498
	}

	public interface ITwoBoneIKConstraintData // TypeDefIndex: 88571
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

	public class TwoBoneIKConstraintJobBinder<T> : AnimationJobBinder<TwoBoneIKConstraintJob, T> // TypeDefIndex: 88572
		where T : struct, IAnimationJobData, ITwoBoneIKConstraintData
	{
		// Constructors
		public TwoBoneIKConstraintJobBinder();
	
		// Methods
		public override TwoBoneIKConstraintJob Create(Animator animator, ref ref T data, Component component);
		public override void Destroy(TwoBoneIKConstraintJob job);
	}

	public class WeightedTransformArrayBinder // TypeDefIndex: 88573
	{
		// Constructors
		public WeightedTransformArrayBinder(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle> transforms); // 0x000000018D2A3C20-0x000000018D2A3D34
		public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle> transforms); // 0x000000018D2A3D34-0x000000018D2A3E44
		public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle> weights); // 0x000000018D2A3E44-0x000000018D2A3FDC
	}

	[Serializable]
	public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData // TypeDefIndex: 88574
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform sourceObjectA { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Transform sourceObjectB { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public bool blendPosition { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool blendRotation { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public float positionWeight { get; set; } // 0x0000000187233410-0x0000000187233420 0x000000018C36F308-0x000000018C36F320
		public float rotationWeight { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018C36F2F0-0x000000018C36F308
		public bool maintainPositionOffsets { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
		public bool maintainRotationOffsets { get; set; } // 0x000000018225DFD0-0x000000018225DFE0 0x000000018225DFE0-0x000000018225DFF0
		string IBlendConstraintData.blendPositionBoolProperty { get; } // 0x000000018D293258-0x000000018D29328C 
		string IBlendConstraintData.blendRotationBoolProperty { get; } // 0x000000018D29328C-0x000000018D2932C0 
		string IBlendConstraintData.positionWeightFloatProperty { get; } // 0x000000018D2932C0-0x000000018D2932F4 
		string IBlendConstraintData.rotationWeightFloatProperty { get; } // 0x000000018D2932F4-0x000000018D293328 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D293174-0x000000018D29320C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D29320C-0x000000018D293258
	}

	[AddComponentMenu("Animation Rigging/Blend Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/BlendConstraint.html")]
	public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder<BlendConstraintData>> // TypeDefIndex: 88575
	{
		// Constructors
		public BlendConstraint(); // 0x000000018D293914-0x000000018D293968
	
		// Methods
		protected override void OnValidate(); // 0x000000018D2938B0-0x000000018D293914
	}

	[Serializable]
	public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData // TypeDefIndex: 88576
	{
		// Fields
		internal const int k_MinIterations = 1; // Metadata: 0x026485E9
		internal const int k_MaxIterations = 50; // Metadata: 0x026485EA
		internal const float k_MinTolerance = 0f; // Metadata: 0x026485EB
		internal const float k_MaxTolerance = 0.01f; // Metadata: 0x026485EF
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
		public Transform root { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform tip { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Transform target { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public float chainRotationWeight { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018B63B190-0x000000018B63B1A8
		public float tipRotationWeight { get; set; } // 0x0000000187233410-0x0000000187233420 0x000000018C36F308-0x000000018C36F320
		public int maxIterations { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018D293CE8-0x000000018D293D08
		public float tolerance { get; set; } // 0x0000000187236710-0x0000000187236720 0x000000018D293D08-0x000000018D293D2C
		public bool maintainTargetPositionOffset { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool maintainTargetRotationOffset { get; set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		string IChainIKConstraintData.chainRotationWeightFloatProperty { get; } // 0x000000018D293C80-0x000000018D293CB4 
		string IChainIKConstraintData.tipRotationWeightFloatProperty { get; } // 0x000000018D293CB4-0x000000018D293CE8 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D293AE8-0x000000018D293C2C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D293C2C-0x000000018D293C80
	}

	[AddComponentMenu("Animation Rigging/Chain IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/ChainIKConstraint.html")]
	public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder<ChainIKConstraintData>> // TypeDefIndex: 88577
	{
		// Constructors
		public ChainIKConstraint(); // 0x000000018D2944F4-0x000000018D294548
	
		// Methods
		protected override void OnValidate(); // 0x000000018D294440-0x000000018D2944F4
	}

	[Serializable]
	public struct DampedTransformData : IAnimationJobData, IDampedTransformData // TypeDefIndex: 88578
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform sourceObject { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public float dampPosition { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x000000018D294B9C-0x000000018D294BB4
		public float dampRotation { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x000000018D294BB4-0x000000018D294BCC
		public bool maintainAim { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		string IDampedTransformData.dampPositionFloatProperty { get; } // 0x000000018D294B34-0x000000018D294B68 
		string IDampedTransformData.dampRotationFloatProperty { get; } // 0x000000018D294B68-0x000000018D294B9C 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D294A80-0x000000018D294AF8
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D294AF8-0x000000018D294B34
	}

	[AddComponentMenu("Animation Rigging/Damped Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/DampedTransform.html")]
	public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder<DampedTransformData>> // TypeDefIndex: 88579
	{
		// Constructors
		public DampedTransform(); // 0x000000018D2953F0-0x000000018D295444
	
		// Methods
		protected override void OnValidate(); // 0x000000018D29538C-0x000000018D2953F0
	}

	[Serializable]
	public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData // TypeDefIndex: 88582
	{
		// Fields
		internal const float k_MinAngularLimit = -180f; // Metadata: 0x026485F3
		internal const float k_MaxAngularLimit = 180f; // Metadata: 0x026485F7
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public WeightedTransformArray sourceObjects { get; set; } // 0x000000018724A420-0x000000018724A480 0x000000018D295CBC-0x000000018D295D20
		public bool maintainOffset { get; set; } // 0x0000000187258E80-0x0000000187258E90 0x0000000187258E90-0x0000000187258EA0
		public Vector3 offset { get; set; } // 0x000000018723EC50-0x000000018723EC70 0x000000018723ECB0-0x000000018723ECD0
		public Vector2 limits { get; set; } // 0x00000001872565E0-0x0000000187256600 0x000000018D295C5C-0x000000018D295CBC
		public Axis aimAxis { get; set; } // 0x0000000187235BE0-0x0000000187235BF0 0x0000000187235C30-0x0000000187235C40
		public Axis upAxis { get; set; } // 0x0000000187235BD0-0x0000000187235BE0 0x0000000187235C20-0x0000000187235C30
		public WorldUpType worldUpType { get; set; } // 0x0000000187235BF0-0x0000000187235C00 0x0000000187235C40-0x0000000187235C50
		public Axis worldUpAxis { get; set; } // 0x000000018723B930-0x000000018723B940 0x0000000185FC1900-0x0000000185FC1910
		public Transform worldUpObject { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x0000000185017130-0x0000000185017150
		public bool constrainedXAxis { get; set; } // 0x0000000187258F80-0x0000000187258F90 0x0000000187258FB0-0x0000000187258FC0
		public bool constrainedYAxis { get; set; } // 0x0000000187258F90-0x0000000187258FA0 0x0000000187258FC0-0x0000000187258FD0
		public bool constrainedZAxis { get; set; } // 0x0000000187258FA0-0x0000000187258FB0 0x0000000187258FD0-0x0000000187258FE0
		Vector3 IMultiAimConstraintData.aimAxis { get; } // 0x000000018D295AF0-0x000000018D295B24 
		Vector3 IMultiAimConstraintData.upAxis { get; } // 0x000000018D295BF4-0x000000018D295C28 
		int IMultiAimConstraintData.worldUpType { get; } // 0x0000000187235BF0-0x0000000187235C00 
		Vector3 IMultiAimConstraintData.worldUpAxis { get; } // 0x000000018D295C28-0x000000018D295C5C 
		string IMultiAimConstraintData.offsetVector3Property { get; } // 0x000000018D295B8C-0x000000018D295BC0 
		string IMultiAimConstraintData.minLimitFloatProperty { get; } // 0x000000018D295B58-0x000000018D295B8C 
		string IMultiAimConstraintData.maxLimitFloatProperty { get; } // 0x000000018D295B24-0x000000018D295B58 
		string IMultiAimConstraintData.sourceObjectsProperty { get; } // 0x000000018D295BC0-0x000000018D295BF4 
	
		// Nested types
		public enum Axis // TypeDefIndex: 88580
		{
			X = 0,
			X_NEG = 1,
			Y = 2,
			Y_NEG = 3,
			Z = 4,
			Z_NEG = 5
		}
	
		public enum WorldUpType // TypeDefIndex: 88581
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D2957FC-0x000000018D295A10
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D295A10-0x000000018D295AF0
		private static Vector3 Convert(Axis axis); // 0x000000018D295790-0x000000018D2957FC
	}

	[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiAimConstraint.html")]
	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>> // TypeDefIndex: 88583
	{
		// Constructors
		public MultiAimConstraint(); // 0x000000018D2970A4-0x000000018D2970F8
	
		// Methods
		protected override void OnValidate(); // 0x000000018D296F00-0x000000018D2970A4
	}

	[Serializable]
	public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData // TypeDefIndex: 88584
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public WeightedTransformArray sourceObjects { get; set; } // 0x000000018724A420-0x000000018724A480 0x000000018D295CBC-0x000000018D295D20
		public bool maintainPositionOffset { get; set; } // 0x0000000187236270-0x0000000187236280 0x000000018723FB40-0x000000018723FB50
		public bool maintainRotationOffset { get; set; } // 0x0000000187259000-0x0000000187259010 0x0000000187259010-0x0000000187259020
		public bool constrainedPositionXAxis { get; set; } // 0x000000018226EDA0-0x000000018226EDB0 0x000000018226EDB0-0x000000018226EDC0
		public bool constrainedPositionYAxis { get; set; } // 0x0000000187235110-0x0000000187235120 0x0000000187235130-0x0000000187235140
		public bool constrainedPositionZAxis { get; set; } // 0x0000000187235120-0x0000000187235130 0x0000000187235140-0x0000000187235150
		public bool constrainedRotationXAxis { get; set; } // 0x0000000187258130-0x0000000187258140 0x0000000187258880-0x0000000187258890
		public bool constrainedRotationYAxis { get; set; } // 0x000000018723FB20-0x000000018723FB30 0x000000018723FB30-0x000000018723FB40
		public bool constrainedRotationZAxis { get; set; } // 0x0000000187236280-0x0000000187236290 0x000000018723FB50-0x000000018723FB60
		string IMultiParentConstraintData.sourceObjectsProperty { get; } // 0x000000018D297398-0x000000018D2973CC 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D2970F8-0x000000018D29730C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D29730C-0x000000018D297398
	}

	[AddComponentMenu("Animation Rigging/Multi-Parent Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiParentConstraint.html")]
	public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder<MultiParentConstraintData>> // TypeDefIndex: 88585
	{
		// Constructors
		public MultiParentConstraint(); // 0x000000018D297FD8-0x000000018D29802C
	
		// Methods
		protected override void OnValidate(); // 0x000000018D297E9C-0x000000018D297FD8
	}

	[Serializable]
	public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData // TypeDefIndex: 88586
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public WeightedTransformArray sourceObjects { get; set; } // 0x000000018724A420-0x000000018724A480 0x000000018D295CBC-0x000000018D295D20
		public bool maintainOffset { get; set; } // 0x00000001872510A0-0x00000001872510B0 0x00000001872510F0-0x0000000187251100
		public Vector3 offset { get; set; } // 0x000000018723EC50-0x000000018723EC70 0x000000018723ECB0-0x000000018723ECD0
		public bool constrainedXAxis { get; set; } // 0x0000000187240E10-0x0000000187240E20 0x0000000187240E30-0x0000000187240E40
		public bool constrainedYAxis { get; set; } // 0x0000000187251090-0x00000001872510A0 0x00000001872510E0-0x00000001872510F0
		public bool constrainedZAxis { get; set; } // 0x00000001872510B0-0x00000001872510C0 0x0000000187251100-0x0000000187251110
		string IMultiPositionConstraintData.offsetVector3Property { get; } // 0x000000018D2982D0-0x000000018D298304 
		string IMultiPositionConstraintData.sourceObjectsProperty { get; } // 0x000000018D298304-0x000000018D298338 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D29802C-0x000000018D298240
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D298240-0x000000018D2982D0
	}

	[AddComponentMenu("Animation Rigging/Multi-Position Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiPositionConstraint.html")]
	public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder<MultiPositionConstraintData>> // TypeDefIndex: 88587
	{
		// Constructors
		public MultiPositionConstraint(); // 0x000000018D298B78-0x000000018D298BCC
	
		// Methods
		protected override void OnValidate(); // 0x000000018D298A3C-0x000000018D298B78
	}

	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData // TypeDefIndex: 88588
	{
		// Fields
		[SerializeField]
		[SyncSceneToStream]
		private int m_Driver; // 0x00
		[SerializeField]
		[SyncSceneToStream]
		private List<Transform> m_SourceObjects; // 0x08
	
		// Properties
		public int driver { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x000000018D298EFC-0x000000018D298F58
		public List<Transform> sourceObjects { get; set; } // 0x000000018D298E78-0x000000018D298EFC 0x000000018D298F58-0x000000018D298FC8
		Transform[] IMultiReferentialConstraintData.sourceObjects { get; } // 0x000000018D298DE0-0x000000018D298E28 
		int IMultiReferentialConstraintData.driverValue { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		string IMultiReferentialConstraintData.driverIntProperty { get; } // 0x000000018D298DAC-0x000000018D298DE0 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D298BCC-0x000000018D298D30
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D298D30-0x000000018D298DAC
		public void UpdateDriver(); // 0x000000018D298E28-0x000000018D298E78
	}

	[AddComponentMenu("Animation Rigging/Multi-Referential Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiReferentialConstraint.html")]
	public class MultiReferentialConstraint : RigConstraint<MultiReferentialConstraintJob, MultiReferentialConstraintData, MultiReferentialConstraintJobBinder<MultiReferentialConstraintData>> // TypeDefIndex: 88589
	{
		// Constructors
		public MultiReferentialConstraint(); // 0x000000018D29965C-0x000000018D2996B0
	
		// Methods
		protected override void OnValidate(); // 0x000000018D299618-0x000000018D29965C
	}

	[Serializable]
	public struct MultiRotationConstraintData : IAnimationJobData, IMultiRotationConstraintData // TypeDefIndex: 88590
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public WeightedTransformArray sourceObjects { get; set; } // 0x000000018724A420-0x000000018724A480 0x000000018D295CBC-0x000000018D295D20
		public bool maintainOffset { get; set; } // 0x00000001872510A0-0x00000001872510B0 0x00000001872510F0-0x0000000187251100
		public Vector3 offset { get; set; } // 0x000000018723EC50-0x000000018723EC70 0x000000018723ECB0-0x000000018723ECD0
		public bool constrainedXAxis { get; set; } // 0x0000000187240E10-0x0000000187240E20 0x0000000187240E30-0x0000000187240E40
		public bool constrainedYAxis { get; set; } // 0x0000000187251090-0x00000001872510A0 0x00000001872510E0-0x00000001872510F0
		public bool constrainedZAxis { get; set; } // 0x00000001872510B0-0x00000001872510C0 0x0000000187251100-0x0000000187251110
		string IMultiRotationConstraintData.offsetVector3Property { get; } // 0x000000018D299954-0x000000018D299988 
		string IMultiRotationConstraintData.sourceObjectsProperty { get; } // 0x000000018D299988-0x000000018D2999BC 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D2996B0-0x000000018D2998C4
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D2998C4-0x000000018D299954
	}

	[AddComponentMenu("Animation Rigging/Multi-Rotation Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/MultiRotationConstraint.html")]
	public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder<MultiRotationConstraintData>> // TypeDefIndex: 88591
	{
		// Constructors
		public MultiRotationConstraint(); // 0x000000018D29A1F0-0x000000018D29A244
	
		// Methods
		protected override void OnValidate(); // 0x000000018D29A0B4-0x000000018D29A1F0
	}

	[Serializable]
	public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData // TypeDefIndex: 88593
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
		public Transform constrainedObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform sourceObject { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Space space { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public Vector3 position { get; set; } // 0x0000000184432B70-0x0000000184432B90 0x0000000187239670-0x0000000187239680
		public Vector3 rotation { get; set; } // 0x000000018723E2B0-0x000000018723E2D0 0x000000018723E2A0-0x000000018723E2B0
		public float positionWeight { get; set; } // 0x0000000187233430-0x0000000187233440 0x000000018D29A780-0x000000018D29A798
		public float rotationWeight { get; set; } // 0x0000000187233330-0x0000000187233340 0x000000018D29A798-0x000000018D29A7B0
		int IOverrideTransformData.space { get; } // 0x000000018226EBA0-0x000000018226EBB0 
		string IOverrideTransformData.positionWeightFloatProperty { get; } // 0x000000018D29A6E4-0x000000018D29A718 
		string IOverrideTransformData.rotationWeightFloatProperty { get; } // 0x000000018D29A74C-0x000000018D29A780 
		string IOverrideTransformData.positionVector3Property { get; } // 0x000000018D29A6B0-0x000000018D29A6E4 
		string IOverrideTransformData.rotationVector3Property { get; } // 0x000000018D29A718-0x000000018D29A74C 
	
		// Nested types
		[Serializable]
		public enum Space // TypeDefIndex: 88592
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D29A5EC-0x000000018D29A63C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D29A63C-0x000000018D29A6B0
	}

	[AddComponentMenu("Animation Rigging/Override Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/OverrideTransform.html")]
	public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder<OverrideTransformData>> // TypeDefIndex: 88594
	{
		// Constructors
		public OverrideTransform(); // 0x000000018D29B104-0x000000018D29B158
	
		// Methods
		protected override void OnValidate(); // 0x000000018D29B0A0-0x000000018D29B104
	}

	[Serializable]
	public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData // TypeDefIndex: 88595
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
		public Transform root { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform tip { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Transform rootTarget { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Transform tipTarget { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public AnimationCurve curve { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D2A10F4-0x000000018D2A11DC
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D2A11DC-0x000000018D2A1248
	}

	[AddComponentMenu("Animation Rigging/Twist Chain Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistChainConstraint.html")]
	public class TwistChainConstraint : RigConstraint<TwistChainConstraintJob, TwistChainConstraintData, TwistChainConstraintJobBinder<TwistChainConstraintData>> // TypeDefIndex: 88596
	{
		// Constructors
		public TwistChainConstraint(); // 0x000000018D2A1740-0x000000018D2A1794
	}

	[Serializable]
	public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData // TypeDefIndex: 88598
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
		public Transform sourceObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public WeightedTransformArray twistNodes { get; set; } // 0x00000001872458C0-0x0000000187245920 0x000000018D2A1930-0x000000018D2A1994
		public Axis twistAxis { get; set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		Transform ITwistCorrectionData.source { get; } // 0x0000000184431970-0x0000000184431980 
		Vector3 ITwistCorrectionData.twistAxis { get; } // 0x000000018D2A18CC-0x000000018D2A18FC 
		string ITwistCorrectionData.twistNodesProperty { get; } // 0x000000018D2A18FC-0x000000018D2A1930 
	
		// Nested types
		public enum Axis // TypeDefIndex: 88597
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Methods
		private static Vector3 Convert(Axis axis); // 0x000000018CDC9834-0x000000018CDC9874
		bool IAnimationJobData.IsValid(); // 0x000000018D2A1794-0x000000018D2A186C
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D2A186C-0x000000018D2A18CC
	}

	[AddComponentMenu("Animation Rigging/Twist Correction")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwistCorrection.html")]
	public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder<TwistCorrectionData>> // TypeDefIndex: 88599
	{
		// Constructors
		public TwistCorrection(); // 0x000000018D2A1E94-0x000000018D2A1EE8
	
		// Methods
		protected override void OnValidate(); // 0x000000018D2A1D50-0x000000018D2A1E94
	}

	[Serializable]
	public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData // TypeDefIndex: 88600
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
		public Transform root { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform mid { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Transform tip { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Transform target { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Transform hint { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public float targetPositionWeight { get; set; } // 0x0000000187233430-0x0000000187233440 0x000000018D29A780-0x000000018D29A798
		public float targetRotationWeight { get; set; } // 0x0000000187233330-0x0000000187233340 0x000000018D29A798-0x000000018D29A7B0
		public float hintWeight { get; set; } // 0x0000000187233870-0x0000000187233880 0x000000018D2A20DC-0x000000018D2A20F4
		public bool maintainTargetPositionOffset { get; set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
		public bool maintainTargetRotationOffset { get; set; } // 0x0000000182260CC0-0x0000000182260CD0 0x0000000182260CD0-0x0000000182260CE0
		string ITwoBoneIKConstraintData.targetPositionWeightFloatProperty { get; } // 0x000000018D2A2074-0x000000018D2A20A8 
		string ITwoBoneIKConstraintData.targetRotationWeightFloatProperty { get; } // 0x000000018D2A20A8-0x000000018D2A20DC 
		string ITwoBoneIKConstraintData.hintWeightFloatProperty { get; } // 0x000000018D2A2040-0x000000018D2A2074 
	
		// Methods
		bool IAnimationJobData.IsValid(); // 0x000000018D2A1EE8-0x000000018D2A1FDC
		void IAnimationJobData.SetDefaultValues(); // 0x000000018D2A1FDC-0x000000018D2A2040
	}

	[AddComponentMenu("Animation Rigging/Two Bone IK Constraint")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/constraints/TwoBoneIKConstraint.html")]
	public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder<TwoBoneIKConstraintData>> // TypeDefIndex: 88601
	{
		// Constructors
		public TwoBoneIKConstraint(); // 0x000000018D2A2510-0x000000018D2A2564
	
		// Methods
		protected override void OnValidate(); // 0x000000018D2A2498-0x000000018D2A2510
	}

	public interface IRigConstraint // TypeDefIndex: 88602
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

	public interface IRigLayer // TypeDefIndex: 88603
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

	public class OverrideRigConstraint<TConstraint, TJob, TData, TBinder> : IRigConstraint // TypeDefIndex: 88604
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
		IAnimationJobBinder IRigConstraint.binder { get; }
		IAnimationJobData IRigConstraint.data { get; }
		Component IRigConstraint.component { get; }
		public float weight { get; set; }
	
		// Constructors
		public OverrideRigConstraint(TConstraint baseConstraint);
		static OverrideRigConstraint();
	
		// Methods
		public IAnimationJob CreateJob(Animator animator);
		public void DestroyJob(IAnimationJob job);
		public void UpdateJob(IAnimationJob job);
		public bool IsValid();
	}

	[Serializable]
	public class OverrideRigLayer : IRigLayer // TypeDefIndex: 88605
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
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get; private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public bool active { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public string name { get; } // 0x000000018D29A55C-0x000000018D29A5EC 
		public IRigConstraint[] constraints { get; } // 0x000000018D29A53C-0x000000018D29A54C 
		public IAnimationJob[] jobs { get; } // 0x000000018D29A54C-0x000000018D29A55C 
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
	
		// Constructors
		public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true /* Metadata: 0x0264860C */); // 0x000000018D29A50C-0x000000018D29A53C
	
		// Methods
		public bool Initialize(Animator animator); // 0x000000018D29A244-0x000000018D29A374
		public void Update(); // 0x000000018D29A498-0x000000018D29A50C
		public void Reset(); // 0x000000018D29A3D0-0x000000018D29A498
		public bool IsValid(); // 0x000000018D29A374-0x000000018D29A3D0
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-component")]
	public class Rig : MonoBehaviour, IRigEffectorHolder // TypeDefIndex: 88606
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Weight; // 0x18
		[SerializeField]
		private List<RigEffectorData> m_Effectors; // 0x20
	
		// Properties
		public float weight { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018B63B190-0x000000018B63B1A8
	
		// Constructors
		public Rig(); // 0x000000018D2A0900-0x000000018D2A0988
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Builder")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-builder-component")]
	[RequireComponent(typeof(Animator))]
	public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder // TypeDefIndex: 88609
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
		[CompilerGenerated]
		private PlayableGraph _graph_k__BackingField; // 0x38
	
		// Properties
		public List<RigLayer> layers { get; set; } // 0x000000018D29DA94-0x000000018D29DB18 0x0000000187835500-0x0000000187835510
		private SyncSceneToStreamLayer syncSceneToStreamLayer { get; set; } // 0x000000018D29DB18-0x000000018D29DB58 0x0000000185CA30F0-0x0000000185CA3100
		public PlayableGraph graph { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723DAB0-0x000000018723DAC0 0x000000018723FA00-0x000000018723FA10
	
		// Nested types
		public delegate void OnAddRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 88607; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void OnRemoveRigBuilderCallback(RigBuilder rigBuilder); // TypeDefIndex: 88608; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public RigBuilder(); // 0x000000018D29DA14-0x000000018D29DA94
	
		// Methods
		private void OnEnable(); // 0x000000018D29D6A4-0x000000018D29D70C
		private void OnDisable(); // 0x000000018D29D63C-0x000000018D29D6A4
		private void OnDestroy(); // 0x000000018D29D634-0x000000018D29D63C
		private void Update(); // 0x000000018D29D908-0x000000018D29DA14
		public bool Build(); // 0x000000018D29D3B4-0x000000018D29D538
		public void Clear(); // 0x000000018D29D538-0x000000018D29D634
		public void StartPreview(); // 0x000000018D29D70C-0x000000018D29D81C
		public void StopPreview(); // 0x000000018D29D81C-0x000000018D29D850
		public void UpdatePreviewGraph(PlayableGraph graph); // 0x000000018D29D850-0x000000018D29D908
		public Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable); // 0x000000018D29D0E8-0x000000018D29D3B4
	}

	internal static class RigBuilderUtils // TypeDefIndex: 88611
	{
		// Fields
		private static readonly ushort k_AnimationOutputPriority; // 0x00
	
		// Nested types
		public struct PlayableChain // TypeDefIndex: 88610
		{
			// Fields
			public string name; // 0x00
			public Playable[] playables; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018D29B158-0x000000018D29B170
		}
	
		// Constructors
		static RigBuilderUtils(); // 0x000000018D29D0B0-0x000000018D29D0E8
	
		// Methods
		public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer); // 0x000000018D29CE80-0x000000018D29D0B0
		public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer); // 0x000000018D29C864-0x000000018D29CE80
		public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer); // 0x000000018D29C48C-0x000000018D29C864
	}

	public class RigConstraint<TJob, TData, TBinder> : MonoBehaviour, IRigConstraint // TypeDefIndex: 88612
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
		public ref TData data { get; }
		public float weight { get; set; }
		IAnimationJobBinder IRigConstraint.binder { get; }
		IAnimationJobData IRigConstraint.data { get; }
		Component IRigConstraint.component { get; }
	
		// Constructors
		public RigConstraint();
		static RigConstraint();
	
		// Methods
		public void Reset();
		public bool IsValid();
		protected virtual void OnValidate();
		public IAnimationJob CreateJob(Animator animator);
		public void DestroyJob(IAnimationJob job);
		public void UpdateJob(IAnimationJob job);
	}

	[Serializable]
	public class RigLayer : IRigLayer // TypeDefIndex: 88613
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
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x30
	
		// Properties
		public Rig rig { get; private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public bool active { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public string name { get; } // 0x000000018D29DE04-0x000000018D29DE94 
		public IRigConstraint[] constraints { get; } // 0x000000018D29A53C-0x000000018D29A54C 
		public IAnimationJob[] jobs { get; } // 0x000000018D29A54C-0x000000018D29A55C 
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
	
		// Constructors
		public RigLayer(Rig rig, bool active = true /* Metadata: 0x0264860D */); // 0x000000018CA8B454-0x000000018CA8B47C
	
		// Methods
		public bool Initialize(Animator animator); // 0x000000018D29DBA8-0x000000018D29DC90
		public void Update(); // 0x000000018D29DD64-0x000000018D29DE04
		public void Reset(); // 0x000000018D29DCD8-0x000000018D29DD64
		public bool IsValid(); // 0x000000018D29DC90-0x000000018D29DCD8
	}

	[AddComponentMenu("Animation Rigging/Setup/Rig Transform")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#rig-transform")]
	public class RigTransform : MonoBehaviour // TypeDefIndex: 88614
	{
		// Constructors
		public RigTransform(); // 0x00000001878364A0-0x00000001878364B8
	}

	internal static class RigUtils // TypeDefIndex: 88617
	{
		// Fields
		internal static readonly Dictionary<System.Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor; // 0x00
		[CompilerGenerated]
		private static readonly IAnimationJobBinder _syncSceneToStreamBinder_k__BackingField; // 0x08
	
		// Properties
		public static IAnimationJobBinder syncSceneToStreamBinder { [CompilerGenerated] get; } // 0x000000018D2A08B0-0x000000018D2A0900 
	
		// Nested types
		private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData // TypeDefIndex: 88615
		{
			// Fields
			[CompilerGenerated]
			private Transform[] _syncableTransforms_k__BackingField; // 0x00
			[CompilerGenerated]
			private SyncableProperties[] _syncableProperties_k__BackingField; // 0x08
			[CompilerGenerated]
			private bool[] _rigStates_k__BackingField; // 0x10
			private readonly bool m_IsValid; // 0x18
	
			// Properties
			public Transform[] syncableTransforms { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
			public SyncableProperties[] syncableProperties { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
			public bool[] rigStates { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
			// Constructors
			public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount); // 0x000000018D29E088-0x000000018D29E218
	
			// Methods
			private static int[] UniqueTransformIndices(Transform[] transforms); // 0x000000018D29DEF0-0x000000018D29E058
			bool IAnimationJobData.IsValid(); // 0x000000018225E050-0x000000018225E060
			void IAnimationJobData.SetDefaultValues(); // 0x000000018D29E058-0x000000018D29E088
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88616
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Reflection.FieldInfo, bool> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D2A25A4-0x000000018D2A2608
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ExtractNestedPropertyType_b__6_0(System.Reflection.FieldInfo info); // 0x000000018D2A2564-0x000000018D2A25A4
		}
	
		// Constructors
		static RigUtils(); // 0x000000018D2A0524-0x000000018D2A08B0
	
		// Methods
		public static IRigConstraint[] GetConstraints(Rig rig); // 0x000000018D2A02E8-0x000000018D2A042C
		private static Transform[] GetSyncableRigTransforms(Animator animator); // 0x000000018D2A042C-0x000000018D2A0524
		private static bool ExtractTransformType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms); // 0x000000018D29F800-0x000000018D29FC3C
		private static bool ExtractPropertyType(System.Reflection.FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0264860E */); // 0x000000018D29F6B8-0x000000018D29F800
		private static bool ExtractWeightedTransforms(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties); // 0x000000018D29FC3C-0x000000018D2A02E8
		private static bool ExtractNestedPropertyType(Animator animator, System.Reflection.FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "" /* Metadata: 0x0264860F */); // 0x000000018D29F1AC-0x000000018D29F6B8
		private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform> syncableTransforms, out List<SyncableProperties> syncableProperties); // 0x000000018D29E600-0x000000018D29F1AC
		public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints); // 0x000000018D29E364-0x000000018D29E430
		public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs); // 0x000000018D29E570-0x000000018D29E600
		internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers); // 0x000000018D29E430-0x000000018D29E570
	}

	internal class SyncSceneToStreamLayer // TypeDefIndex: 88618
	{
		// Fields
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField; // 0x10
		public IAnimationJob job; // 0x18
		private IAnimationJobData m_Data; // 0x20
		private List<int> m_RigIndices; // 0x28
	
		// Properties
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public SyncSceneToStreamLayer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool Initialize(Animator animator, IList<IRigLayer> layers); // 0x000000018D2A0988-0x000000018D2A0B58
		public void Update(IList<IRigLayer> layers); // 0x000000018D2A0BFC-0x000000018D2A0D78
		public void Reset(); // 0x000000018D2A0B6C-0x000000018D2A0BFC
		public bool IsValid(); // 0x000000018D2A0B58-0x000000018D2A0B6C
	}

	public interface ITransformProvider // TypeDefIndex: 88619
	{
		// Properties
		Transform transform { get; set; }
	}

	public interface IWeightProvider // TypeDefIndex: 88620
	{
		// Properties
		float weight { get; set; }
	}

	[Serializable]
	public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform> // TypeDefIndex: 88621
	{
		// Fields
		public Transform transform; // 0x00
		public float weight; // 0x08
	
		// Properties
		Transform ITransformProvider.transform { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		float IWeightProvider.weight { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018D2A5634-0x000000018D2A564C
	
		// Constructors
		public WeightedTransform(Transform transform, float weight); // 0x000000018D2A564C-0x000000018D2A5670
	
		// Methods
		public static WeightedTransform Default(float weight); // 0x000000018D2A5594-0x000000018D2A55BC
		public bool Equals(WeightedTransform other); // 0x000000018D2A55BC-0x000000018D2A5634
	}

	[Serializable]
	public struct WeightedTransformArray : IList<WeightedTransform>, IList // TypeDefIndex: 88623
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
		object IList.this[int index] { get => default; set {} } // 0x000000018D2A5304-0x000000018D2A5380 0x000000018D2A5380-0x000000018D2A5408
		public WeightedTransform this[int index] { get => default; set {} } // 0x000000018D2A54B8-0x000000018D2A5528 0x000000018D2A5528-0x000000018D2A5594
		public int Count { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public bool IsReadOnly { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public bool IsFixedSize { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool ICollection.IsSynchronized { get; } // 0x00000001851A4410-0x00000001851A4420 
		object ICollection.SyncRoot { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Nested types
		[Serializable]
		private struct Enumerator : IEnumerator<WeightedTransform> // TypeDefIndex: 88622
		{
			// Fields
			private WeightedTransformArray m_Array; // 0x00
			private int m_Index; // 0x88
	
			// Properties
			public WeightedTransform Current { get; } // 0x000000018D2955C0-0x000000018D295630 
			object IEnumerator.Current { get; } // 0x000000018D295498-0x000000018D2954F0 
	
			// Constructors
			public Enumerator(ref WeightedTransformArray array); // 0x000000018D2954F0-0x000000018D2955C0
	
			// Methods
			public bool MoveNext(); // 0x000000018D295444-0x000000018D295498
			public void Reset(); // 0x0000000187258F70-0x0000000187258F80
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public WeightedTransformArray(int size); // 0x000000018D2A5444-0x000000018D2A54B8
		static WeightedTransformArray(); // 0x000000018D2A5408-0x000000018D2A5444
	
		// Methods
		public IEnumerator<WeightedTransform> GetEnumerator(); // 0x000000018D2A44E0-0x000000018D2A45A0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D2A4FD8-0x000000018D2A5098
		int IList.Add(object value); // 0x000000018D2A5098-0x000000018D2A5114
		public void Add(WeightedTransform value); // 0x000000018D2A3FDC-0x000000018D2A4110
		public void Clear(); // 0x000000018723EDD0-0x000000018723EDE0
		int IList.IndexOf(object value); // 0x000000018D2A518C-0x000000018D2A5204
		public int IndexOf(WeightedTransform value); // 0x000000018D2A4710-0x000000018D2A47AC
		bool IList.Contains(object value); // 0x000000018D2A5114-0x000000018D2A518C
		public bool Contains(WeightedTransform value); // 0x000000018D2A4274-0x000000018D2A4310
		void ICollection.CopyTo(Array array, int arrayIndex); // 0x000000018D2A4DF0-0x000000018D2A4FD8
		public void CopyTo(WeightedTransform[] array, int arrayIndex); // 0x000000018D2A4310-0x000000018D2A44E0
		void IList.Remove(object value); // 0x000000018D2A528C-0x000000018D2A5304
		public bool Remove(WeightedTransform value); // 0x000000018D2A4AD8-0x000000018D2A4BC4
		public void RemoveAt(int index); // 0x000000018D2A4A40-0x000000018D2A4AD8
		void IList.Insert(int index, object value); // 0x000000018D2A5204-0x000000018D2A528C
		public void Insert(int index, WeightedTransform value); // 0x000000018D2A47AC-0x000000018D2A497C
		private static int ClampSize(int size); // 0x000000018D2A4220-0x000000018D2A4274
		private void CheckOutOfRangeIndex(int index); // 0x000000018D2A4110-0x000000018D2A4220
		private WeightedTransform Get(int index); // 0x000000018D2A4654-0x000000018D2A4710
		private void Set(int index, WeightedTransform value); // 0x000000018D2A4CF4-0x000000018D2A4DF0
		public void SetWeight(int index, float weight); // 0x000000018D2A4C64-0x000000018D2A4CF4
		public float GetWeight(int index); // 0x000000018D2A45F8-0x000000018D2A4654
		public void SetTransform(int index, Transform transform); // 0x000000018D2A4BC4-0x000000018D2A4C64
		public Transform GetTransform(int index); // 0x000000018D2A45A0-0x000000018D2A45F8
		public static void OnValidate(ref WeightedTransformArray array, float min = 0f /* Metadata: 0x02648610 */, float max = 1f /* Metadata: 0x02648614 */); // 0x000000018D2A497C-0x000000018D2A4A40
	}

	internal sealed class ExpandChildrenAttribute : PropertyAttribute // TypeDefIndex: 88624
	{
		// Constructors
		public ExpandChildrenAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class SyncSceneToStreamAttribute : Attribute // TypeDefIndex: 88625
	{
		// Constructors
		public SyncSceneToStreamAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum PropertyType : byte // TypeDefIndex: 88626
	{
		Bool = 0,
		Int = 1,
		Float = 2
	}

	internal struct PropertyDescriptor // TypeDefIndex: 88627
	{
		// Fields
		public int size; // 0x00
		public PropertyType type; // 0x04
	}

	internal struct Property // TypeDefIndex: 88628
	{
		// Fields
		public string name; // 0x00
		public PropertyDescriptor descriptor; // 0x08
	}

	internal struct RigProperties // TypeDefIndex: 88629
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
	
		// Constructors
		static RigProperties(); // 0x000000018D29DE94-0x000000018D29DEF0
	}

	internal struct ConstraintProperties // TypeDefIndex: 88630
	{
		// Fields
		public static string s_Weight; // 0x00
		public Component component; // 0x00
		public Property[] properties; // 0x08
	
		// Constructors
		static ConstraintProperties(); // 0x000000018D294548-0x000000018D2945A4
	}

	[Obsolete("PropertyUtils is deprecated. Use ConstraintsUtils instead. (UnityUpgradable) -> ConstraintsUtils")]
	public static class PropertyUtils // TypeDefIndex: 88631
	{
		// Methods
		[Obsolete("ConstructConstraintDataPropertyName is deprecated. Use ConstraintsUtils.ConstructConstraintDataPropertyName instead.")]
		public static string ConstructConstraintDataPropertyName(string property); // 0x000000018D29B524-0x000000018D29B52C
		[Obsolete("ConstructCustomPropertyName is deprecated. Use ConstraintsUtils.ConstructCustomPropertyName instead.")]
		public static string ConstructCustomPropertyName(Component component, string property); // 0x000000018D29B52C-0x000000018D29B534
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class WeightRangeAttribute : PropertyAttribute // TypeDefIndex: 88632
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public WeightRangeAttribute(float min, float max); // 0x0000000187240DF0-0x0000000187240E00
	}

	public interface IRigEffectorHolder // TypeDefIndex: 88633
	{
	}

	[Serializable]
	public class RigEffectorData // TypeDefIndex: 88635
	{
		// Fields
		[SerializeField]
		private Transform m_Transform; // 0x10
		[SerializeField]
		private Style m_Style; // 0x18
		[SerializeField]
		private bool m_Visible; // 0x50
	
		// Properties
		public Transform transform { get; } // 0x00000001829260F0-0x0000000182926100 
		public Style style { get; } // 0x0000000187246390-0x00000001872463C0 
		public bool visible { get; set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 88634
		{
			// Fields
			public Mesh shape; // 0x00
			public UnityEngine.Color color; // 0x08
			public float size; // 0x18
			public Vector3 position; // 0x1C
			public Vector3 rotation; // 0x28
		}
	
		// Constructors
		public RigEffectorData(); // 0x0000000187259020-0x0000000187259030
	
		// Methods
		public void Initialize(Transform transform, Style style); // 0x000000018D29DB58-0x000000018D29DBA8
	}

	[Serializable]
	public struct AffineTransform // TypeDefIndex: 88636
	{
		// Fields
		public Vector3 translation; // 0x00
		public Quaternion rotation; // 0x0C
		[CompilerGenerated]
		private static readonly AffineTransform _identity_k__BackingField; // 0x00
	
		// Properties
		public static AffineTransform identity { [CompilerGenerated] get; } // 0x000000018D291460-0x000000018D2914C0 
	
		// Constructors
		public AffineTransform(Vector3 t, Quaternion r); // 0x000000018723FF60-0x000000018723FF80
		static AffineTransform(); // 0x000000018D2913D4-0x000000018D291460
	
		// Methods
		public void Set(Vector3 t, Quaternion r); // 0x000000018723FF60-0x000000018723FF80
		public Vector3 Transform(Vector3 p); // 0x0000000189564CD4-0x0000000189564D60
		public Vector3 InverseTransform(Vector3 p); // 0x0000000189564B64-0x0000000189564C24
		public AffineTransform Inverse(); // 0x0000000189564C24-0x0000000189564CD4
		public AffineTransform InverseMul(AffineTransform transform); // 0x0000000189564A3C-0x0000000189564B64
		public static Vector3 operator *(AffineTransform lhs, Vector3 rhs); // 0x0000000189564CD4-0x0000000189564D60
		public static AffineTransform operator *(AffineTransform lhs, AffineTransform rhs); // 0x000000018D2914C0-0x000000018D2915D4
		public static AffineTransform operator *(Quaternion lhs, AffineTransform rhs); // 0x0000000189564F60-0x0000000189565000
		public static AffineTransform operator *(AffineTransform lhs, Quaternion rhs); // 0x0000000189565000-0x0000000189565054
	}

	public static class AnimationRuntimeUtils // TypeDefIndex: 88637
	{
		// Fields
		private const float k_SqrEpsilon = 1E-08f; // Metadata: 0x0264861B
	
		// Methods
		public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset); // 0x000000018D292380-0x000000018D2930D4
		private static float TriangleAngle(float aLen, float aLen1, float aLen2); // 0x000000018D293124-0x000000018D293174
		public static bool SolveFABRIK(ref NativeArray<Vector3> linkPositions, ref NativeArray<float> linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations); // 0x000000018D291EDC-0x000000018D292380
		public static float SqrDistance(Vector3 lhs, Vector3 rhs); // 0x0000000188B979E0-0x0000000188B97A3C
		public static float Square(float value); // 0x00000001872355E0-0x00000001872355F0
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t); // 0x000000018D291BB4-0x000000018D291CB8
		public static float Select(float a, float b, float c); // 0x000000018D291ED0-0x000000018D291EDC
		public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c); // 0x000000018D291E7C-0x000000018D291ED0
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal); // 0x000000018D291DBC-0x000000018D291E7C
		internal static float Sum(AnimationJobCache cache, CacheIndex index, int count); // 0x000000018D2930FC-0x000000018D293124
		public static float Sum(NativeArray<float> floatBuffer); // 0x000000018D2930D4-0x000000018D2930FC
		public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle); // 0x000000018D291CB8-0x000000018D291DBC
	}

	[AddComponentMenu("Animation Rigging/Setup/Bone Renderer")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.1/manual/RiggingWorkflow.html#bone-renderer-component")]
	public class BoneRenderer : MonoBehaviour // TypeDefIndex: 88639
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
		public Transform[] transforms { get; } // 0x0000000182986470-0x0000000182986480 
	
		// Nested types
		public enum BoneShape // TypeDefIndex: 88638
		{
			Line = 0,
			Pyramid = 1,
			Box = 2
		}
	
		// Constructors
		public BoneRenderer(); // 0x000000018D293968-0x000000018D2939A4
	}

	public static class ConstraintsUtils // TypeDefIndex: 88641
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 88640
		{
			// Fields
			public float totalLength; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ExtractSteps_b__0(float length); // 0x0000000187259070-0x0000000187259080
		}
	
		// Methods
		public static Transform[] ExtractChain(Transform root, Transform tip); // 0x000000018D294710-0x000000018D294860
		public static float[] ExtractLengths(Transform[] chain); // 0x000000018D294860-0x000000018D294950
		public static float[] ExtractSteps(Transform[] chain); // 0x000000018D294950-0x000000018D294A80
		public static string ConstructConstraintDataPropertyName(string property); // 0x000000018D2945A4-0x000000018D2945E0
		public static string ConstructCustomPropertyName(Component component, string property); // 0x000000018D2945E0-0x000000018D294710
	}

	public static class QuaternionExt // TypeDefIndex: 88642
	{
		// Fields
		private const float k_FloatMin = 1E-10f; // Metadata: 0x02648622
		public static readonly Quaternion zero; // 0x00
	
		// Constructors
		static QuaternionExt(); // 0x000000018D29B820-0x000000018D29B85C
	
		// Methods
		public static Quaternion FromToRotation(Vector3 from, Vector3 to); // 0x000000018D29B5B8-0x000000018D29B7AC
		public static Quaternion Add(Quaternion rhs, Quaternion lhs); // 0x000000018D29B534-0x000000018D29B5B8
		public static Quaternion Scale(Quaternion q, float scale); // 0x00000001855D4360-0x00000001855D4380
		public static Quaternion NormalizeSafe(Quaternion q); // 0x000000018D29B7AC-0x000000018D29B820
	}

	[Serializable]
	public struct Vector3Bool // TypeDefIndex: 88643
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Constructors
		public Vector3Bool(bool val); // 0x0000000187259080-0x0000000187259090
		public Vector3Bool(bool x, bool y, bool z); // 0x000000018724E9E0-0x000000018724E9F0
	}
}
